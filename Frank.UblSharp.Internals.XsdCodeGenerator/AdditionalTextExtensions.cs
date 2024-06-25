using System;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.Internals.XsdCodeGenerator
{
    internal static class AdditionalTextExtensions
    {
        public static Member GenerateMember(this AdditionalText file, string projectDir)
    {
        var relativePath = file.GetRelativePath(projectDir);
        var directories = relativePath.Split('/').ToList();
        var memberDeclarationSyntax = file.GenerateFileInfoProperty(relativePath);

        return new Member
        {
            MemberDeclarationSyntax = memberDeclarationSyntax,
            Directories = directories,
            RelativePath = relativePath
        };
    }

        private static string GetRelativePath(this AdditionalText additionalText, string projectDir)
        {
            return GetRelativePath(projectDir, additionalText.Path).Replace("\\", "/");
        }

        private static PropertyDeclarationSyntax GenerateFileInfoProperty(this AdditionalText file, string relativeAssetFilePath)
    {
        var name = file.GetMethodName();
        var fileInfoCreation = SyntaxFactory.ObjectCreationExpression(SyntaxFactory.IdentifierName("FileInfo"))
            .WithArgumentList(SyntaxFactory.ArgumentList(
                SyntaxFactory.SingletonSeparatedList(
                    SyntaxFactory.Argument(
                        SyntaxFactory.InvocationExpression(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    SyntaxFactory.IdentifierName("Path"),
                                    SyntaxFactory.IdentifierName("Combine")))
                            .WithArgumentList(SyntaxFactory.ArgumentList(
                                SyntaxFactory.SeparatedList(new[]
                                {
                                    SyntaxFactory.Argument(
                                        SyntaxFactory.MemberAccessExpression(
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            SyntaxFactory.IdentifierName("AppContext"),
                                            SyntaxFactory.IdentifierName("BaseDirectory"))),
                                    SyntaxFactory.Argument(
                                        SyntaxFactory.LiteralExpression(
                                            SyntaxKind.StringLiteralExpression,
                                            SyntaxFactory.Literal(relativeAssetFilePath)))
                                })))))));

        return SyntaxFactory.PropertyDeclaration(
                SyntaxFactory.ParseTypeName("FileInfo"), name)
            .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)))
            .WithExpressionBody(SyntaxFactory.ArrowExpressionClause(fileInfoCreation))
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));
    }


        private static string GetMethodName(this AdditionalText additionalText)
    {
        var name = Path.GetFileNameWithoutExtension(additionalText.Path);
        var nameParts = name.Split('-');
        return nameParts.Length > 1 && nameParts.First() == "UBL"
            ? nameParts[1]
            : nameParts.First();
    }
        
        public static string GetRelativePath(string relativeTo, string path)
        {
            if (string.IsNullOrEmpty(relativeTo)) throw new ArgumentNullException(nameof(relativeTo));
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path));

            Uri fromUri = new Uri(AppendDirectorySeparatorChar(relativeTo));
            Uri toUri = new Uri(AppendDirectorySeparatorChar(path));

            if (fromUri.Scheme != toUri.Scheme)
            {
                return path; // Path can't be made relative.
            }

            Uri relativeUri = fromUri.MakeRelativeUri(toUri);
            string relativePath = Uri.UnescapeDataString(relativeUri.ToString());

            if (string.Equals(toUri.Scheme, Uri.UriSchemeFile, StringComparison.OrdinalIgnoreCase))
            {
                relativePath = relativePath.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
            }

            return relativePath;
        }

        private static string AppendDirectorySeparatorChar(string path)
        {
            // Append a slash only if the path is a directory and doesn't have one.
            if (!Path.HasExtension(path) && !path.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                return path + Path.DirectorySeparatorChar;
            }

            return path;
        }

    }
    
    
}