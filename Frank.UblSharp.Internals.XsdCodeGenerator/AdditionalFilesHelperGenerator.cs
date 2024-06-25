using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;

namespace Frank.UblSharp.Internals.XsdCodeGenerator
{
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

            if (!context.TryGetProjectDir(out var projectDir) || !context.TryGetRootNamespace(out var rootNamespace)) return;
            if (projectDir is null) return;
            if (rootNamespace is null) return;

            var root = new ClassMember(rootClassName);
            var members = new List<Member>();

            foreach (var file in context.AdditionalFiles)
            {
                var member = file.GenerateMember(projectDir);
                members.Add(member);
                var parent = root.GetOrAddNestedClass(member.Directories);
                parent.MemberDeclarationSyntaxes.Add(member.MemberDeclarationSyntax);
            }

            var filesProperty = members.GenerateFilesProperty(projectDir);
            var getXmlSchemaSetMethod = XmlSchemaSetMethodGenerator.GenerateGetXmlSchemaSetMethod();

            root.MemberDeclarationSyntaxes.Add(filesProperty);
            root.MemberDeclarationSyntaxes.Add(getXmlSchemaSetMethod);
        
            var rootClass = root.GenerateClassRecursively();
            var compilationUnit = SyntaxFactory.CompilationUnit()
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Reflection")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.IO")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Xml.Schema")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Xml")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Collections.Generic")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Linq")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Text.RegularExpressions")))
                .AddMembers(SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(rootNamespace))
                    .AddMembers(rootClass));

            var sourceText = SourceText.From(compilationUnit.NormalizeWhitespace().ToFullString(), Encoding.UTF8);
            context.AddSource($"{rootClassName}.g.cs", sourceText);
        }
    }
}