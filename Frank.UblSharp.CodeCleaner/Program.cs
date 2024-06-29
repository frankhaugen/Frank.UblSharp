// See https://aka.ms/new-console-template for more information

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;

var outputDirectory = new DirectoryInfo(@"D:\frankrepos\Frank.UblSharp\Frank.UblSharp");

var fileTypesExtractor = new FileTypesExtractor();

var files = outputDirectory.GetFiles("*.cs", SearchOption.TopDirectoryOnly).ToList();
foreach (var file in files)
{
    await fileTypesExtractor.ExtractTypesAsync(file);
}
Console.WriteLine("Types extracted.");

// var directoryVisitor = new DirectoryVisitor();
// directoryVisitor.VisitDirectory(outputDirectory);


internal class FileTypesExtractor
{
    public async Task ExtractTypesAsync(FileInfo file)
    {
        var code = await File.ReadAllTextAsync(file.FullName);
        var syntaxTree = CSharpSyntaxTree.ParseText(code);

        var types = (await syntaxTree.GetRootAsync()).DescendantNodes().OfType<TypeDeclarationSyntax>().ToList();
        
        foreach (var type in types)
        {
            var newSyntaxTree = CSharpSyntaxTree.ParseText(type.NormalizeWhitespace().ToFullString());
            var newCode = Microsoft.CodeAnalysis.Formatting.Formatter.Format(await newSyntaxTree.GetRootAsync(), new AdhocWorkspace()).ToFullString();
            await File.WriteAllTextAsync(Path.Combine(file.DirectoryName, $"{type.Identifier.ValueText}.cs"), newCode);
        }
        
        file.Delete();
    }
}

internal class DirectoryVisitor
{
    public void VisitDirectory(DirectoryInfo directory)
    {
        var files = directory.GetFiles("*.cs", SearchOption.AllDirectories).ToList();
        
        var parallelOptions = new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount };
        
        Parallel.ForEach(files, parallelOptions, file => new FileVisitor().VisitFile(file));
    }
}

internal class FileVisitor
{
    public void VisitFile(FileInfo file)
    {
        Console.WriteLine($"Visiting file {file.Name}");
        var code = File.ReadAllText(file.FullName);
        var syntaxTree = CSharpSyntaxTree.ParseText(code);

        var rewriter = new SyntaxTreeRewriter();
        rewriter.Rewrite(ref syntaxTree);

        var newCode = Microsoft.CodeAnalysis.Formatting.Formatter.Format(syntaxTree.GetRoot(), new AdhocWorkspace()).ToFullString();

        File.WriteAllText(file.FullName, newCode);
    }
}

internal class SyntaxTreeRewriter
{
    public void Rewrite(ref SyntaxTree syntaxTree)
    {
        var rootNode = syntaxTree.GetRoot();
        var compilation = CSharpCompilation.Create("YourCompilation")
            .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
            .AddSyntaxTrees(syntaxTree); // Add the SyntaxTree here

        var propertiesWithBackingFields = new PropertyExtractor(compilation.GetSemanticModel(syntaxTree)).ExtractPropertiesWithBackingFields(rootNode);

        foreach (var propertiesWithBackingField in propertiesWithBackingFields)
        {
            var rewriter = new PropertyRewriter(compilation.GetSemanticModel(syntaxTree), propertiesWithBackingField.BackingField, propertiesWithBackingField.Property);
            var newRootNode = rewriter.Visit(rootNode);

            // After doing the rewrite, refresh the syntax tree and semantic model.
            var newSyntaxTree = newRootNode.SyntaxTree;
            rootNode = newRootNode;
            compilation = compilation.ReplaceSyntaxTree(syntaxTree, newSyntaxTree);
            syntaxTree = newSyntaxTree;
        }
    }
}

internal class PropertyRewriter : CSharpSyntaxRewriter
{
    private readonly ISymbol _backingField;
    private readonly PropertyDeclarationSyntax _property;
    private readonly SemanticModel _semanticModel;

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
                return name.WithAdditionalAnnotations(Microsoft.CodeAnalysis.Formatting.Formatter.Annotation);
            }
        }

        return name;
    }

    public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax propertyDeclaration)
    {
        if (propertyDeclaration == _property) return ConvertToAutoProperty(propertyDeclaration).WithAdditionalAnnotations(Formatter.Annotation);
        return base.VisitPropertyDeclaration(propertyDeclaration);
    }

    public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax field)
    {
        if (field == null)
            return null;
        if (field.Declaration.Variables.Count == 1 && Equals(_semanticModel.GetDeclaredSymbol(field.Declaration.Variables.First()), _backingField)) return null;
        return field;
    }

    public override SyntaxNode VisitVariableDeclarator(VariableDeclaratorSyntax variable)
    {
        if (variable.Parent.Parent is FieldDeclarationSyntax field && field.Declaration.Variables.Count == 1 && Equals(_semanticModel.GetDeclaredSymbol(variable), _backingField)) return null;
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

internal class PropertyExtractor
{
    private readonly SemanticModel _semanticModel;

    public PropertyExtractor(SemanticModel semanticModel)
    {
        _semanticModel = semanticModel;
    }

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

        foreach (var accessor in propertySymbol.GetMethod?.DeclaringSyntaxReferences.Concat(propertySymbol.SetMethod?.DeclaringSyntaxReferences) ?? Enumerable.Empty<SyntaxReference>())
        {
            var syntaxNode = accessor.GetSyntax() as AccessorDeclarationSyntax;
            if (syntaxNode == null) continue;

            foreach (var identifier in syntaxNode.DescendantNodes().OfType<IdentifierNameSyntax>())
            {
                var symbol = _semanticModel.GetSymbolInfo(identifier).Symbol;
                if (symbol is IFieldSymbol fieldSymbol && fieldSymbol.ContainingType == propertySymbol.ContainingType)
                    return symbol;
            }
        }

        return null;
    }
}

internal struct PropertyWithBackingField
{
    public ISymbol BackingField { get; }
    public PropertyDeclarationSyntax Property { get; }

    public PropertyWithBackingField(ISymbol backingField, PropertyDeclarationSyntax property)
    {
        BackingField = backingField;
        Property = property;
    }
}