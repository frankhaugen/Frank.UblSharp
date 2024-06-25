using System.Text;
using System.Text.RegularExpressions;
using Frank.UblSharp.Resources;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using XmlSchemaClassGenerator;

namespace Frank.UblSharp.GeneratorV2;

public class Program
{
    public static async Task Main()
    {
        var outputDirectory = new DirectoryInfo(@"D:\frankrepos\Frank.UblSharp\Frank.UblSharp");
        
        // GenerateFiles(outputDirectory);

        await PropertyAutoPropertyConverter.ConvertAsync(outputDirectory);
    }

    private static void GenerateFiles(DirectoryInfo outputDirectory)
    {
        var fileLog = new List<string>();
        var schemaSet = ResourcesHelper.GetXmlSchemaSet();
        var converter = UblGenerator.CreateGenerator(outputDirectory, "Frank.UblSharp", fileLog);

        converter.GenerateNullables = true;
        converter.CollectionSettersMode = CollectionSettersMode.PublicWithoutConstructorInitialization;
        
        converter.Generate(schemaSet);
        
        foreach (var log in fileLog)
        {
            Console.Error.WriteLine(log);
        }
    }
}

public static class PropertyAutoPropertyConverter
{
    public static async Task ConvertAsync(DirectoryInfo directoryInfo)
    {
        var files = directoryInfo.GetFiles("*.cs", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            var code = await File.ReadAllTextAsync(file.FullName);
            var newCode = Convert(code);
            await File.WriteAllTextAsync(file.FullName, newCode);
        }
    }
    
    public static string Convert(string code)
    {
        var tree = CSharpSyntaxTree.ParseText(code);
        var root = tree.GetRoot();
        var newRoot = new PropertyRewriter().Visit(root);
        return newRoot.ToString();
    }
    
    internal class PropertyRewriter : CSharpSyntaxRewriter
{
    public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        if (node.AccessorList != null && node.AccessorList.Accessors.Count == 2)
        {
            var getAccessor = node.AccessorList.Accessors.FirstOrDefault(a => a.Kind() == SyntaxKind.GetAccessorDeclaration);
            var setAccessor = node.AccessorList.Accessors.FirstOrDefault(a => a.Kind() == SyntaxKind.SetAccessorDeclaration);

            if (getAccessor != null && setAccessor != null &&
                getAccessor.Body == null && setAccessor.Body == null)
            {
                var fieldName = GetBackingField(node);
                if (fieldName != null)
                {
                    // Create a new property declaration with auto-property syntax and preserve the attributes
                    var newProperty = node
                        .WithAccessorList(SyntaxFactory.AccessorList(SyntaxFactory.List(new[]
                        {
                            SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                            SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                        })))
                        .WithTrailingTrivia(SyntaxFactory.Whitespace(Environment.NewLine))
                        .WithLeadingTrivia(node.GetLeadingTrivia())
                        .WithTriviaFrom(node);

                    return newProperty;
                }
            }
        }

        return base.VisitPropertyDeclaration(node);
    }

    private string? GetBackingField(PropertyDeclarationSyntax property)
    {
        var classDeclaration = property.Ancestors().OfType<ClassDeclarationSyntax>().FirstOrDefault();
        if (classDeclaration == null) return null;

        // Find the field with a similar name to the property
        var fieldName = property.Identifier.Text;
        var backingField = classDeclaration.Members
            .OfType<FieldDeclarationSyntax>()
            .FirstOrDefault(f =>
            {
                var fieldIdentifier = f.Declaration.Variables.First().Identifier.Text;
                return string.Equals(fieldIdentifier.TrimStart('_'), fieldName, StringComparison.OrdinalIgnoreCase);
            });

        return backingField?.Declaration.Variables.First().Identifier.Text;
    }
}

    private class PropertyRewriterV1 : CSharpSyntaxRewriter
    {
        public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            Console.WriteLine($"Property: {node.Identifier.Text}");
            
            if (node.AccessorList != null && node.AccessorList.Accessors.Count == 2)
            {
                var getAccessor = node.AccessorList.Accessors.FirstOrDefault(a => a.Kind() == SyntaxKind.GetAccessorDeclaration);
                var setAccessor = node.AccessorList.Accessors.FirstOrDefault(a => a.Kind() == SyntaxKind.SetAccessorDeclaration);

                if (getAccessor != null && setAccessor != null &&
                    getAccessor.Body == null && setAccessor.Body == null)
                {
                    var fieldName = GetBackingField(node);
                    if (fieldName != null)
                    {
                        return node.WithoutLeadingTrivia().WithTrailingTrivia(SyntaxFactory.Whitespace(Environment.NewLine))
                            .WithAccessorList(SyntaxFactory.AccessorList(SyntaxFactory.List(new[]
                            {
                                SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                                SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                            })))
                            .WithTriviaFrom(node);
                    }
                }
            }

            return base.VisitPropertyDeclaration(node);
        }

        private string? GetBackingField(PropertyDeclarationSyntax property)
        {
            var classDeclaration = property.Ancestors().OfType<ClassDeclarationSyntax>().FirstOrDefault();
            if (classDeclaration == null) return null;

            var fieldName = property.Identifier.Text;
            var backingField = classDeclaration.Members
                .OfType<FieldDeclarationSyntax>()
                .FirstOrDefault(f => f.Declaration.Variables.Any(v => v.Identifier.Text.Contains(fieldName, StringComparison.OrdinalIgnoreCase)));

            return backingField?.Declaration.Variables.First().Identifier.Text;
        }
    }
}

public static class UblGenerator
{
    public static Generator CreateGenerator(DirectoryInfo outputDirectory, string rootNamespace, List<string> fileLog)
    {
        return new Generator
        {
            OutputFolder = outputDirectory.FullName,
            Log = fileLog.Add,
            PrivateMemberPrefix = "_",
            IntegerDataType = typeof(int),
            CollectionImplementationType = typeof(List<>),
            CollectionType = typeof(List<>),
            NamingScheme = NamingScheme.PascalCase,
            DataAnnotationMode = DataAnnotationMode.Partial,
            CollectionSettersMode = CollectionSettersMode.PublicWithoutConstructorInitialization,
            CodeTypeReferenceOptions = System.CodeDom.CodeTypeReferenceOptions.GenericTypeParameter,
            NamespaceProvider = new NamespaceProvider()
            {
                GenerateNamespace = x =>
                {
                    var namespaceBuilder = new StringBuilder();

                    namespaceBuilder.Append(rootNamespace);
                    namespaceBuilder.Append(".");
                    
                    var customNamespace = new Regex("[^a-zA-Z0-9]").Replace(x.XmlSchemaNamespace, "_");

                    if (customNamespace.StartsWith("urn_oasis_names_specification_ubl_schema_xsd_"))
                    {
                        var documentName = customNamespace
                            .Replace("urn_oasis_names_specification_ubl_schema_xsd_", "")
                            .Replace("_2", "");
                        namespaceBuilder.Append(documentName);
                    }
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonExtensionComponents_2")
                    {
                        namespaceBuilder.Append("CommonExtensionComponents");
                    }
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonSignatureComponents_2")
                    {
                        namespaceBuilder.Append("CommonSignatureComponents");
                    }
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_SignatureBasicComponents_2")
                    {
                        namespaceBuilder.Append("SignatureBasicComponents");
                    }
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_SignatureAggregateComponents_2")
                    {
                        namespaceBuilder.Append("SignatureAggregateComponents");
                    }
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonAggregateComponents_2")
                    {
                        namespaceBuilder.Append("CommonAggregateComponents");
                    }
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonBasicComponents_2")
                    {
                        namespaceBuilder.Append("CommonBasicComponents");
                    }
                    if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_UnqualifiedDataTypes_2")
                    {
                        namespaceBuilder.Append("UnqualifiedDataTypes");
                    }
                    if (customNamespace == "urn_un_unece_uncefact_data_specification_CoreComponentTypeSchemaModule_2")
                    {
                        namespaceBuilder.Append("CoreComponentTypes");
                    }
                    if (customNamespace.StartsWith("http___"))
                    {
                        namespaceBuilder.Append("CoreComponentTypes");
                    }

                    return namespaceBuilder.ToString();
                }
            },
            GenerateInterfaces = true,
            NetCoreSpecificCode = true,
            SeparateClasses = true,
            EntityFramework = false,
            EnumAsString = true,
            MapUnionToWidestCommonType = true,
            GenerateNullables = true,
            DoNotForceIsNullable = false,
            EmitOrder = false,
            SeparateNamespaceHierarchy = false,
            DisableComments = false,
            GenerateDescriptionAttribute = false,
            EnableNullableReferenceAttributes = true,
            CompactTypeNames = true,
            SeparateSubstitutes = true,
            GenerateSerializableAttribute = true,
            CreateGeneratedCodeAttributeVersion = true,
            AssemblyVisible = false,
            EnableUpaCheck = true,
            UseShouldSerializePattern = false,
            GenerateDesignerCategoryAttribute = false,
        };
    }
}