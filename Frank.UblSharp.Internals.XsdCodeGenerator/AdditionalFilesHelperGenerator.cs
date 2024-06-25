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

        var sourceBuilder = new StringBuilder();
        var additionalFiles = context.AdditionalFiles;

        if (TryGetProjectDir(context, out var projectDir)) return;
        if (TryGetRootNamespace(context, out var rootNamespace)) return;

        var root = new ClassMember(rootClassName);
        var members = new List<Member>();
        foreach (var file in additionalFiles)
        {
            var member = GenerateMember(file, projectDir);
            members.Add(member);
            var parent = root.GetOrAddNestedClass(member.Directories);
            parent.MemberDeclarationSyntaxes.Add(member.MemberDeclarationSyntax);
        }
        
        IEnumerable<FileInfo> files = members.Select(m => new FileInfo(m.RelativePath));
        var filesProperty = GenerateEmbeddedResourcePropertyFileInfoCollection("Files", files, projectDir);
        
        var getXmlSchemaSetMethod = GenerateGetXmlSchemaSetMethod();
        
        root.MemberDeclarationSyntaxes.Add(getXmlSchemaSetMethod);
        root.MemberDeclarationSyntaxes.Add(filesProperty);

        var rootClass = GenerateClassRecursively(root);
        var compilationUnit = SyntaxFactory.CompilationUnit()
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Reflection")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.IO")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Xml.Schema")))
                .AddMembers(SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(rootNamespace))
                    .AddMembers(rootClass))
            ;

        sourceBuilder.Append(compilationUnit.NormalizeWhitespace().ToFullString());

        var sourceString = sourceBuilder.ToString();
        var fileName = rootClassName + ".g.cs";

        var sourceText = SourceText.From(sourceString, Encoding.UTF8);
        context.AddSource(fileName, sourceText);
    }

    private static MemberDeclarationSyntax GenerateEmbeddedResourcePropertyFileInfoCollection(string files, IEnumerable<FileInfo> fileInfos, string projectDir) =>
        SyntaxFactory
            .PropertyDeclaration(
                SyntaxFactory.ParseTypeName("IEnumerable<FileInfo>"), files)
            .WithExpressionBody(
                SyntaxFactory.ArrowExpressionClause(SyntaxFactory.ArrayCreationExpression(
                        SyntaxFactory.ArrayType(SyntaxFactory.ParseTypeName("FileInfo[]"))
                    ).WithInitializer(
                        SyntaxFactory.InitializerExpression(SyntaxKind.ArrayInitializerExpression, SyntaxFactory.SeparatedList(GetSeparatedSyntaxNodes(fileInfos, projectDir)))
                    )
                ))
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
            .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                SyntaxFactory.Token(SyntaxKind.StaticKeyword)));

    private static IEnumerable<ExpressionSyntax> GetSeparatedSyntaxNodes(IEnumerable<FileInfo> fileInfos, string projectDir)
    {
        var syntaxNodes = fileInfos.Select(fileInfo => SyntaxFactory.ObjectCreationExpression(SyntaxFactory.ParseTypeName("FileInfo"))
                .WithArgumentList(SyntaxFactory.ArgumentList(SyntaxFactory.SingletonSeparatedList(GenerateArgumentSyntax(fileInfo, projectDir)))))
            .Cast<ExpressionSyntax>()
            .ToList();

        syntaxNodes.RemoveAt(syntaxNodes.Count - 1);
        return syntaxNodes;
    }

    private static ArgumentSyntax GenerateArgumentSyntax(FileInfo fileInfo, string projectDir) =>
        GenerateArgumentSyntax(GetRelativePath(fileInfo, projectDir));

    private static string GetRelativePath(FileInfo fileInfo, string projectDir) => Path.GetRelativePath(projectDir, fileInfo.FullName).Replace("\\", "/").Replace("../", "");

    private static ClassDeclarationSyntax GenerateClassRecursively(ClassMember classMember)
    {
        var className = ConvertPathToClassName(classMember.Name);
        var classDeclaration = SyntaxFactory
            .ClassDeclaration(className)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.InternalKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword));

        classDeclaration = classMember.NestedClasses.Aggregate(classDeclaration, (current, nestedClass) => current.AddMembers(GenerateClassRecursively(nestedClass.Value)));
        classDeclaration = classDeclaration.AddMembers(classMember.MemberDeclarationSyntaxes.ToArray());

        return classDeclaration;
    }

    private static Member GenerateMember(AdditionalText file, string projectDir)
    {
        var relativePath = GetRelativePath(file, projectDir);
        var directoryPath = relativePath.Replace(Path.GetFileName(relativePath), "");
        var directories = directoryPath.Split('/', StringSplitOptions.RemoveEmptyEntries).ToList();
        var memberDeclarationSyntax = GenerateEmbeddedResourcePropertyFileInfo(GetMethodName(file), relativePath);

        return new Member
        {
            MemberDeclarationSyntax = memberDeclarationSyntax,
            Directories = directories,
            RelativePath = relativePath
        };
    }

    private static bool TryGetRootNamespace(GeneratorExecutionContext context, out string? rootNamespace)
    {
        if (context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.rootnamespace", out rootNamespace)) return false;
        context.ReportDiagnostic(Diagnostic.Create(
            new DiagnosticDescriptor("FRANK0002", "Failed to generate resource helper class, no root",
                "Failed to generate resource helper class, no root", "Frank", DiagnosticSeverity.Error, true),
            Location.None));
        return true;
    }

    private static bool TryGetProjectDir(GeneratorExecutionContext context, out string? projectDir)
    {
        if (context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.projectdir", out projectDir)) return false;
        context.ReportDiagnostic(Diagnostic.Create(
            new DiagnosticDescriptor("FRANK0001", "Failed to generate resource helper class",
                "Failed to generate resource helper class", "Frank", DiagnosticSeverity.Error, true),
            Location.None));
        return true;
    }

    private static string GetRelativePath(AdditionalText additionalText, string projectPath) => Path.GetRelativePath(projectPath, additionalText.Path).Replace("\\", "/");

    private static PropertyDeclarationSyntax GenerateEmbeddedResourcePropertyFileInfo(string name, string relativeAssetFilePath) =>
        SyntaxFactory
            .PropertyDeclaration(
                SyntaxFactory.ParseTypeName("FileInfo"), name)
            .WithExpressionBody(
                SyntaxFactory.ArrowExpressionClause(SyntaxFactory.InvocationExpression(
                        SyntaxFactory.ObjectCreationExpression(SyntaxFactory.ParseTypeName("FileInfo"))
                    ).WithArgumentList(
                        SyntaxFactory.ArgumentList(
                            SyntaxFactory.SingletonSeparatedList(
                                GenerateArgumentSyntax(relativeAssetFilePath)
                            )
                        )
                    )
                )
            )
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
            .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                SyntaxFactory.Token(SyntaxKind.StaticKeyword)));

    private static ArgumentSyntax GenerateArgumentSyntax(string relativeAssetFilePath)
    {
        return SyntaxFactory.Argument(
            SyntaxFactory.InvocationExpression(
                    SyntaxFactory.MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        SyntaxFactory.IdentifierName("Path"),
                        SyntaxFactory.IdentifierName("Combine")))
                .WithArgumentList(
                    SyntaxFactory.ArgumentList(
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
                                    SyntaxFactory.Literal(relativeAssetFilePath))
                            )
                        })
                    )
                )
        );
    }

    private static string ConvertPathToClassName(string path)
    {
        var className = Path.GetFileName(path);
        className = Regex.Replace(className, @"[\W]", "_");
        className = char.ToUpper(className[0]) + (className.Length > 1 ? className.Substring(1) : "");
        return className;
    }

    private static string GetMethodName(AdditionalText additionalText)
    {
        var name = Path.GetFileNameWithoutExtension(additionalText.Path);
        var nameParts = name.Split("-");
        var methodName = string.Empty;

        if (nameParts.First() == "UBL")
        {
            methodName = nameParts[1];
        }
        else
        {
            methodName = nameParts.First();
        }
        
        
        return methodName;
    }
    
    public static MethodDeclarationSyntax GenerateGetXmlSchemaSetMethod()
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
        var foreachStatement = SyntaxFactory.ForEachStatement(
            varType,
            SyntaxFactory.Identifier("xsdFile"),
            SyntaxFactory.IdentifierName("Files"),
            SyntaxFactory.Block(
                // schemaSet.Add(XmlSchema.Read(xsdFile.OpenText(), null));
                SyntaxFactory.ExpressionStatement(
                    SyntaxFactory.InvocationExpression(
                        SyntaxFactory.MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            SyntaxFactory.IdentifierName("schemaSet"),
                            SyntaxFactory.IdentifierName("Add")))
                    .WithArgumentList(
                        SyntaxFactory.ArgumentList(
                            SyntaxFactory.SingletonSeparatedList(
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
                                            }))))))))));

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
            if (classPath.Count == 0) return this;

            var nextClass = classPath[0];
            if (!NestedClasses.TryGetValue(nextClass, out var nextClassMember))
            {
                nextClassMember = new ClassMember(nextClass);
                NestedClasses.Add(nextClass, nextClassMember);
            }

            classPath.RemoveAt(0);
            return nextClassMember.GetOrAddNestedClass(classPath);
        }
    }
}