using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.Internals.XsdCodeGenerator
{
    internal static class MemberExtensions
    {
        public static PropertyDeclarationSyntax GenerateFilesProperty(this List<Member> members, string projectDir)
    {
        var fileInfoArray = SyntaxFactory.ArrayCreationExpression(
                SyntaxFactory.ArrayType(SyntaxFactory.IdentifierName("FileInfo"))
                    .WithRankSpecifiers(SyntaxFactory.SingletonList(
                        SyntaxFactory.ArrayRankSpecifier(SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(
                            SyntaxFactory.OmittedArraySizeExpression())))))
            .WithInitializer(
                SyntaxFactory.InitializerExpression(SyntaxKind.ArrayInitializerExpression, GenerateFileInfos(members, projectDir)));

        return SyntaxFactory.PropertyDeclaration(
                SyntaxFactory.ParseTypeName("IEnumerable<FileInfo>"), "Files")
            .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)))
            .WithExpressionBody(SyntaxFactory.ArrowExpressionClause(fileInfoArray))
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));
    }

        private static SeparatedSyntaxList<ExpressionSyntax> GenerateFileInfos(List<Member> members, string projectDir)
    {
        return SyntaxFactory.SeparatedList<ExpressionSyntax>(members.Select(member => SyntaxFactory.ObjectCreationExpression(
                SyntaxFactory.ParseTypeName("FileInfo"),
                GenerateFileInfoArguments(member, projectDir),
                null
                )));
    }

        private static ArgumentListSyntax GenerateFileInfoArguments(Member member, string projectDir)
    {
        return SyntaxFactory.ArgumentList(
            SyntaxFactory.SingletonSeparatedList(
                SyntaxFactory.Argument(
                    SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression,
                        SyntaxFactory.Literal(Path.Combine(projectDir,
                                member.RelativePath)
                            .Replace("\\",
                                "/")
                        ))
                )
            )
        );
    }
    }
}