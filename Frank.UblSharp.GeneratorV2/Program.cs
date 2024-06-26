using Frank.UblSharp.GeneratorV2.SyntaxRewriters;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;

namespace Frank.UblSharp.GeneratorV2;

        // GenerateFiles(outputDirectory);

public class Program
{
    public static async Task Main()
    {
        var outputDirectory = new DirectoryInfo(@"D:\frankrepos\Frank.UblSharp\Frank.UblSharp");

        var files = outputDirectory.GetFiles("*.cs", SearchOption.AllDirectories);

        foreach (var file in files)
        {
            var before = await File.ReadAllTextAsync(file.FullName);
            var syntaxTree = CSharpSyntaxTree.ParseText(before);
            var root = await syntaxTree.GetRootAsync();
            var compilation = CSharpCompilation.Create("YourCompilation")
                .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
                .AddSyntaxTrees(syntaxTree);
            var semanticModel = compilation.GetSemanticModel(syntaxTree);
        
            var extractor = new PropertyExtractor(semanticModel);
            var propertiesWithBackingFields = extractor.ExtractPropertiesWithBackingFields(root);

            foreach (var propertiesWithBackingField in propertiesWithBackingFields)
            {
                var rewriter = new PropertyRewriter(semanticModel, propertiesWithBackingField.BackingField, propertiesWithBackingField.Property);
                root = rewriter.Visit(root);
            }
        
            var formattedRoot = Formatter.Format(root, new AdhocWorkspace());
            var after = formattedRoot.ToFullString();
            if (before != after)
            {
                await File.WriteAllTextAsync(file.FullName, after);
            }
        }
    }
    
    class PropertyRewriter : CSharpSyntaxRewriter
{
    private readonly SemanticModel _semanticModel;
    private readonly ISymbol _backingField;
    private readonly PropertyDeclarationSyntax _property;

    public PropertyRewriter(SemanticModel semanticModel, ISymbol backingField, PropertyDeclarationSyntax property)
    {
        _semanticModel = semanticModel;
        _backingField = backingField;
        _property = property;
    }

    public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax name)
    {
        if (_backingField != null && name.Identifier.ValueText.Equals(_backingField.Name))
        {
            var symbolInfo = _semanticModel.GetSymbolInfo(name);
            if (symbolInfo.Symbol != null && Equals(symbolInfo.Symbol.OriginalDefinition, _backingField))
            {
                name = name.WithIdentifier(SyntaxFactory.Identifier(_property.Identifier.ValueText));
                return name.WithAdditionalAnnotations(Formatter.Annotation);
            }
        }
        return name;
    }

    public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax propertyDeclaration)
    {
        if (propertyDeclaration == _property)
        {
            return ConvertToAutoProperty(propertyDeclaration).WithAdditionalAnnotations(Formatter.Annotation);
        }
        return base.VisitPropertyDeclaration(propertyDeclaration);
    }

    public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax field)
    {
        if (field.Declaration.Variables.Count == 1 && Equals(_semanticModel.GetDeclaredSymbol(field.Declaration.Variables.First()), _backingField))
        {
            return null;
        }
        return field;
    }

    public override SyntaxNode VisitVariableDeclarator(VariableDeclaratorSyntax variable)
    {
        if (variable.Parent.Parent is FieldDeclarationSyntax field && field.Declaration.Variables.Count == 1 && Equals(_semanticModel.GetDeclaredSymbol(variable), _backingField))
        {
            return null;
        }
        return variable;
    }

    private PropertyDeclarationSyntax ConvertToAutoProperty(PropertyDeclarationSyntax propertyDeclaration)
    {
        return propertyDeclaration.WithAccessorList(SyntaxFactory.AccessorList(SyntaxFactory.List(new[]
        {
            SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
            SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
        })));
    }
}
    public class PropertyExtractor
    {
        private readonly SemanticModel _semanticModel;

        public PropertyExtractor(SemanticModel semanticModel) => _semanticModel = semanticModel;

        public IEnumerable<PropertyWithBackingField> ExtractPropertiesWithBackingFields(SyntaxNode root)
        {
            var properties = root.DescendantNodes().OfType<PropertyDeclarationSyntax>();
            foreach (var property in properties)
            {
                if (property.AccessorList == null || property.AccessorList.Accessors.Count != 2)
                    continue;
                var backingField = GetBackingFieldSymbol(property);
                if (backingField != null)
                    yield return new PropertyWithBackingField(backingField, property);
            }
        }

        private ISymbol? GetBackingFieldSymbol(PropertyDeclarationSyntax property)
        {
            var propertySymbol = _semanticModel.GetDeclaredSymbol(property);
            if (propertySymbol == null) return null;
            if (propertySymbol.SetMethod?.DeclaringSyntaxReferences == null) return null;
            
            foreach (var accessor in propertySymbol.GetMethod?.DeclaringSyntaxReferences.Concat(propertySymbol.SetMethod?.DeclaringSyntaxReferences?? []) ?? [])
            {
                var syntaxNode = accessor.GetSyntax() as AccessorDeclarationSyntax;
                var identifier = syntaxNode?.DescendantNodes().OfType<IdentifierNameSyntax>().FirstOrDefault();
                if (identifier == null) continue;
                var symbol = _semanticModel.GetSymbolInfo(identifier).Symbol;
                if (symbol is { Kind: SymbolKind.Field })
                    return symbol;
            }

            return null;
        }
    }
    
    public struct PropertyWithBackingField
    {
        public ISymbol BackingField { get; }
        public PropertyDeclarationSyntax Property { get; }

        public PropertyWithBackingField(ISymbol backingField, PropertyDeclarationSyntax property)
        {
            BackingField = backingField;
            Property = property;
        }
    }
}
    // private static void GenerateFiles(DirectoryInfo outputDirectory)
    // {
    //     var fileLog = new List<string>();
    //     var schemaSet = ResourcesHelper.GetXmlSchemaSet();
    //     var converter = UblGeneratorFactory.Create(outputDirectory, "Frank.UblSharp", fileLog);
    //
    //     converter.GenerateNullables = true;
    //     converter.CollectionSettersMode = CollectionSettersMode.PublicWithoutConstructorInitialization;
    //
    //     converter.Generate(schemaSet);
    //
    //     foreach (var log in fileLog) Console.Error.WriteLine(log);
    // }
