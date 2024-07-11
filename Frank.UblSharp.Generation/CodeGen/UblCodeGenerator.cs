using System.CodeDom;
using System.Text;
using System.Xml.Schema;
using Frank.UblSharp.Resources;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using XmlSchemaClassGenerator;

namespace Frank.UblSharp.Generation.CodeGen;

[Generator]
public class UblCodeGenerator : ISourceGenerator
{
    private XmlSchemaSet? _xmlSchemaSet;
    private DirectoryInfo? _outputDir;
    
    /// <inheritdoc />
    public void Initialize(GeneratorInitializationContext context)
    {
    }
    
    /// <inheritdoc />
    public void Execute(GeneratorExecutionContext context)
    {
        var xmlSchemaSet = ResourcesHelper.GetXmlSchemaSet();
        var schemaFilter = new UblMainDocumentXmlSchemaFilter();
        xmlSchemaSet = schemaFilter.Filter(xmlSchemaSet);
        
        var visitor = new XmlSchemaMetaVisitor();
        visitor.VisitAsync(xmlSchemaSet).GetAwaiter().GetResult();
        
        _xmlSchemaSet = xmlSchemaSet;
        if (_xmlSchemaSet is null) return;
        
        if (!context.TryGetProjectDir(out var projectDir) || !context.TryGetRootNamespace(out var rootNamespace)) return;
        if (projectDir is null) return;
        if (rootNamespace is null) return;

        var codeWriter = new CodeWriter();
        codeWriter.CodeNamespaceGenerated += CodeWriterOnCodeNamespaceGenerated;
        _outputDir = new DirectoryInfo(projectDir);
        var generator = UblGeneratorFactory.Create(_outputDir, s => context.ReportDiagnostic(Diagnostic.Create(new DiagnosticDescriptor("FRANK0003", "Failed to generate UBL classes", s, "Frank", DiagnosticSeverity.Error, true), Location.None)), codeWriter);
        generator.Generate(_xmlSchemaSet);
    }

    private void CodeWriterOnCodeNamespaceGenerated(object? sender, CodeNamespace e)
    {
        var rewriter = new CompilationUnitSyntaxRewriter();
        
        var compilationUnit = GetCompilationUnit(e);
        
        var newCompilationUnit = rewriter.Visit(compilationUnit);
        
        var sourceText = SourceText.From(newCompilationUnit.NormalizeWhitespace().ToFullString(), Encoding.UTF8);
        var fileName = $"{e.Name}.g.cs";
        var filePath = Path.Combine(_outputDir!.FullName, fileName);
        var file = new FileInfo(filePath);
        file.Directory?.Create();
        using var fileStream = file.OpenWrite();
        using var textWriter = new StreamWriter(fileStream);
        sourceText.Write(textWriter);
        
        
    }

    private CompilationUnitSyntax GetCompilationUnit(CodeNamespace codeNamespace)
    {
        var compilationUnit = SyntaxFactory.CompilationUnit().AddMembers(SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(codeNamespace.Name)));
        
        foreach (CodeTypeDeclaration codeNamespaceType in codeNamespace.Types)
        {
            var classDeclaration = SyntaxFactory.ClassDeclaration(codeNamespaceType.Name);
            foreach (CodeTypeMember codeTypeMember in codeNamespaceType.Members)
            {
                if (codeTypeMember is CodeMemberField codeMemberField)
                {
                    var fieldDeclaration = SyntaxFactory.FieldDeclaration(SyntaxFactory.VariableDeclaration(SyntaxFactory.ParseTypeName(codeMemberField.Type.BaseType), SyntaxFactory.SeparatedList(new[] {SyntaxFactory.VariableDeclarator(codeMemberField.Name)})));
                    classDeclaration = classDeclaration.AddMembers(fieldDeclaration);
                }
                
                if (codeTypeMember is CodeMemberProperty codeMemberProperty)
                {
                    var propertyDeclaration = SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName(codeMemberProperty.Type.BaseType), codeMemberProperty.Name)
                        .WithAccessorList(SyntaxFactory.AccessorList(SyntaxFactory.List(new[]
                        {
                            SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                            SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                        })));
                    classDeclaration = classDeclaration.AddMembers(propertyDeclaration);
                }
                
                if (codeTypeMember is CodeMemberMethod codeMemberMethod)
                {
                    var methodDeclaration = SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName(codeMemberMethod.ReturnType.BaseType), codeMemberMethod.Name)
                        .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                        .WithBody(SyntaxFactory.Block());
                    classDeclaration = classDeclaration.AddMembers(methodDeclaration);
                }
                
                if (codeTypeMember is CodeTypeDeclaration codeTypeDeclaration)
                {
                    var nestedClassDeclaration = SyntaxFactory.ClassDeclaration(codeTypeDeclaration.Name);
                    foreach (CodeTypeMember nestedCodeTypeMember in codeTypeDeclaration.Members)
                    {
                        if (nestedCodeTypeMember is CodeMemberField nestedCodeMemberField)
                        {
                            var fieldDeclaration = SyntaxFactory.FieldDeclaration(SyntaxFactory.VariableDeclaration(SyntaxFactory.ParseTypeName(nestedCodeMemberField.Type.BaseType), SyntaxFactory.SeparatedList(new[] {SyntaxFactory.VariableDeclarator(nestedCodeMemberField.Name)})));
                            nestedClassDeclaration = nestedClassDeclaration.AddMembers(fieldDeclaration);
                        }
                        
                        if (nestedCodeTypeMember is CodeMemberProperty nestedCodeMemberProperty)
                        {
                            var propertyDeclaration = SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName(nestedCodeMemberProperty.Type.BaseType), nestedCodeMemberProperty.Name)
                                .WithAccessorList(SyntaxFactory.AccessorList(SyntaxFactory.List(new[]
                                {
                                    SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                                    SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                                })));
                            nestedClassDeclaration = nestedClassDeclaration.AddMembers(propertyDeclaration);
                        }
                        
                        if (nestedCodeTypeMember is CodeMemberMethod nestedCodeMemberMethod)
                        {
                            var methodDeclaration = SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName(nestedCodeMemberMethod.ReturnType.BaseType), nestedCodeMemberMethod.Name)
                                .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                                .WithBody(SyntaxFactory.Block());
                            nestedClassDeclaration = nestedClassDeclaration.AddMembers(methodDeclaration);
                        }
                    }
                    classDeclaration = classDeclaration.AddMembers(nestedClassDeclaration);
                }
            }
            compilationUnit = compilationUnit.AddMembers(classDeclaration);
        }
        
        
        return compilationUnit;
    }

    private class CodeWriter : OutputWriter
    {
        public override void Write(CodeNamespace cn) => CodeNamespaceGenerated.Invoke(this, cn);

        public event EventHandler<CodeNamespace> CodeNamespaceGenerated;
    }
}