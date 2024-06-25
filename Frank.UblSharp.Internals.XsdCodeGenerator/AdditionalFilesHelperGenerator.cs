using System.Text;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Frank.UblSharp.Internals.XsdCodeGenerator;

[Generator]
public class AdditionalFilesHelperGenerator : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
    }

    public void Execute(GeneratorExecutionContext context)
    {
        GenerateResourceHelperClass(context);
    }

    private static void GenerateResourceHelperClass(GeneratorExecutionContext context)
    {
        const string rootClassName = "AdditionalResources";

        if (!TryGetProjectDir(context, out var projectDir) || !TryGetRootNamespace(context, out var rootNamespace)) return;

        var root = new ClassMember(rootClassName);
        var members = new List<Member>();
        foreach (var file in context.AdditionalFiles)
        {
            var member = GenerateMember(file, projectDir);
            members.Add(member);
            var parent = root.GetOrAddNestedClass(member.Directories);
            parent.MemberDeclarationSyntaxes.Add(member.MemberDeclarationSyntax);
        }

        var filesProperty = GenerateFilesProperty(members, projectDir);
        var getXmlSchemaSetMethod = GenerateGetXmlSchemaSetMethod();

        root.MemberDeclarationSyntaxes.Add(filesProperty);
        root.MemberDeclarationSyntaxes.Add(getXmlSchemaSetMethod);

        var rootClass = GenerateClassRecursively(root);
        var compilationUnit = SyntaxFactory.CompilationUnit()
            .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Reflection")))
            .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.IO")))
            .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Xml.Schema")))
            .AddMembers(SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(rootNamespace))
                .AddMembers(rootClass));

        var sourceText = SourceText.From(compilationUnit.NormalizeWhitespace().ToFullString(), Encoding.UTF8);
        context.AddSource($"{rootClassName}.g.cs", sourceText);
    }

    private static PropertyDeclarationSyntax GenerateFilesProperty(List<Member> members, string projectDir)
    {
        var fileInfoArray = SyntaxFactory.ArrayCreationExpression(
                SyntaxFactory.ArrayType(SyntaxFactory.IdentifierName("FileInfo"))
                    .WithRankSpecifiers(SyntaxFactory.SingletonList(
                        SyntaxFactory.ArrayRankSpecifier(SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(
                            SyntaxFactory.OmittedArraySizeExpression())))))
            .WithInitializer(SyntaxFactory.InitializerExpression(SyntaxKind.ArrayInitializerExpression,
                SyntaxFactory.SeparatedList<ExpressionSyntax>(
                    members.Select(member => SyntaxFactory.ObjectCreationExpression(SyntaxFactory.IdentifierName("FileInfo"))
                        .WithArgumentList(SyntaxFactory.ArgumentList(
                            SyntaxFactory.SingletonSeparatedList(
                                SyntaxFactory.Argument(
                                    SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression,
                                        SyntaxFactory.Literal(Path.Combine(projectDir, member.RelativePath).Replace("\\", "/")))))))))));

        return SyntaxFactory.PropertyDeclaration(
                SyntaxFactory.ParseTypeName("IEnumerable<FileInfo>"), "Files")
            .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)))
            .WithExpressionBody(SyntaxFactory.ArrowExpressionClause(fileInfoArray))
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));
    }

    private static MethodDeclarationSyntax GenerateGetXmlSchemaSetMethod()
    {
        // Using statements
        var varType = SyntaxFactory.IdentifierName("var");
        var xmlSchemaSetType = SyntaxFactory.ParseTypeName("XmlSchemaSet");

        // var schemaSet = new XmlSchemaSet();
        var schemaSetDeclaration = SyntaxFactory.LocalDeclarationStatement(
            SyntaxFactory.VariableDeclaration(varType)
                .WithVariables(
                    SyntaxFactory.SingletonSeparatedList(
                        SyntaxFactory.VariableDeclarator("schemaSet")
                            .WithInitializer(
                                SyntaxFactory.EqualsValueClause(
                                    SyntaxFactory.ObjectCreationExpression(xmlSchemaSetType)
                                        .WithArgumentList(SyntaxFactory.ArgumentList()))))));

        // foreach (var xsdFile in Files)
        var foreachStatement = GenerateForeachStatement();

        // schemaSet.Compile();
        var compileStatement = SyntaxFactory.ExpressionStatement(
            SyntaxFactory.InvocationExpression(
                SyntaxFactory.MemberAccessExpression(
                    SyntaxKind.SimpleMemberAccessExpression,
                    SyntaxFactory.IdentifierName("schemaSet"),
                    SyntaxFactory.IdentifierName("Compile"))));

        // return schemaSet;
        var returnStatement = SyntaxFactory.ReturnStatement(SyntaxFactory.IdentifierName("schemaSet"));

        // Combine into method body
        var methodBody = SyntaxFactory.Block(schemaSetDeclaration, foreachStatement, compileStatement, returnStatement);

        // Create method declaration
        return SyntaxFactory.MethodDeclaration(xmlSchemaSetType, "GetXmlSchemaSet")
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword))
            .WithBody(methodBody);
    }

    private static ForEachStatementSyntax GenerateForeachStatement()
    {
        return SyntaxFactory.ForEachStatement(
            SyntaxFactory.IdentifierName("var"),
            SyntaxFactory.Identifier("xsdFile"),
            SyntaxFactory.IdentifierName("Files"),
            SyntaxFactory.Block(
                SyntaxFactory.ExpressionStatement(
                    SyntaxFactory.InvocationExpression(
                            SyntaxFactory.MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                SyntaxFactory.IdentifierName("schemaSet"),
                                SyntaxFactory.IdentifierName("Add")))
                        .WithArgumentList(
                            SyntaxFactory.ArgumentList(
                                SyntaxFactory.SeparatedList(new[]
                                {
                                    SyntaxFactory.Argument(
                                        SyntaxFactory.InvocationExpression(
                                                SyntaxFactory.MemberAccessExpression(
                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                    SyntaxFactory.IdentifierName("XmlSchema"),
                                                    SyntaxFactory.IdentifierName("Read")))
                                            .WithArgumentList(
                                                SyntaxFactory.ArgumentList(
                                                    SyntaxFactory.SeparatedList(new[]
                                                    {
                                                        SyntaxFactory.Argument(
                                                            SyntaxFactory.InvocationExpression(
                                                                SyntaxFactory.MemberAccessExpression(
                                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                                    SyntaxFactory.IdentifierName("xsdFile"),
                                                                    SyntaxFactory.IdentifierName("OpenText")))),
                                                        SyntaxFactory.Argument(
                                                            SyntaxFactory.LiteralExpression(SyntaxKind.NullLiteralExpression))
                                                    }))))
                                }))))));
    }

    private static ClassDeclarationSyntax GenerateClassRecursively(ClassMember classMember)
    {
        var classDeclaration = SyntaxFactory.ClassDeclaration(ConvertPathToClassName(classMember.Name))
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.InternalKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword))
            .AddMembers(classMember.MemberDeclarationSyntaxes.ToArray());

        foreach (var nestedClass in classMember.NestedClasses.Values) classDeclaration = classDeclaration.AddMembers(GenerateClassRecursively(nestedClass));

        return classDeclaration;
    }

    private static Member GenerateMember(AdditionalText file, string projectDir)
    {
        var relativePath = GetRelativePath(file, projectDir);
        var directories = relativePath.Split('/', StringSplitOptions.RemoveEmptyEntries).ToList();
        var memberDeclarationSyntax = GenerateFileInfoProperty(GetMethodName(file), relativePath);

        return new Member
        {
            MemberDeclarationSyntax = memberDeclarationSyntax,
            Directories = directories,
            RelativePath = relativePath
        };
    }

    private static PropertyDeclarationSyntax GenerateFileInfoProperty(string name, string relativeAssetFilePath)
    {
        return SyntaxFactory.PropertyDeclaration(
                SyntaxFactory.ParseTypeName("FileInfo"), name)
            .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)))
            .WithExpressionBody(SyntaxFactory.ArrowExpressionClause(
                SyntaxFactory.ObjectCreationExpression(SyntaxFactory.IdentifierName("FileInfo"))
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
                                        })))))))))
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));
    }

    private static string GetRelativePath(AdditionalText additionalText, string projectDir)
    {
        return Path.GetRelativePath(projectDir, additionalText.Path).Replace("\\", "/");
    }

    private static bool TryGetRootNamespace(GeneratorExecutionContext context, out string? rootNamespace)
    {
        if (context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.rootnamespace", out rootNamespace))
            return true;

        context.ReportDiagnostic(Diagnostic.Create(
            new DiagnosticDescriptor("FRANK0002", "Failed to generate resource helper class, no root namespace",
                "Failed to generate resource helper class, no root namespace", "Frank", DiagnosticSeverity.Error, true),
            Location.None));
        return false;
    }

    private static bool TryGetProjectDir(GeneratorExecutionContext context, out string? projectDir)
    {
        if (context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.projectdir", out projectDir))
            return true;

        context.ReportDiagnostic(Diagnostic.Create(
            new DiagnosticDescriptor("FRANK0001", "Failed to generate resource helper class, no project directory",
                "Failed to generate resource helper class, no project directory", "Frank", DiagnosticSeverity.Error, true),
            Location.None));
        return false;
    }

    private static string ConvertPathToClassName(string path)
    {
        var className = Path.GetFileNameWithoutExtension(path);
        className = Regex.Replace(className, @"[\W]", "_");
        return char.ToUpper(className[0]) + className.Substring(1);
    }

    private static string GetMethodName(AdditionalText additionalText)
    {
        var name = Path.GetFileNameWithoutExtension(additionalText.Path);
        var nameParts = name.Split("-");
        return nameParts.Length > 1 && nameParts.First() == "UBL"
            ? nameParts[1]
            : nameParts.First();
    }

    private struct Member
    {
        public MemberDeclarationSyntax MemberDeclarationSyntax { get; set; }
        public List<string> Directories { get; set; }
        public string RelativePath { get; set; }
    }

    private class ClassMember
    {
        public ClassMember(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public Dictionary<string, ClassMember> NestedClasses { get; } = new();
        public List<MemberDeclarationSyntax> MemberDeclarationSyntaxes { get; } = new();

        public ClassMember GetOrAddNestedClass(List<string> classPath)
        {
            if (!classPath.Any()) return this;

            var nextClass = classPath.First();
            if (!NestedClasses.TryGetValue(nextClass, out var nextClassMember))
            {
                nextClassMember = new ClassMember(nextClass);
                NestedClasses[nextClass] = nextClassMember;
            }

            classPath.RemoveAt(0);
            return nextClassMember.GetOrAddNestedClass(classPath);
        }
    }
}