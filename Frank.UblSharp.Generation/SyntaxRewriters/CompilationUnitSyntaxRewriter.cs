using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

internal class CompilationUnitSyntaxRewriter : CSharpSyntaxRewriter
{
    /// <inheritdoc />
    public override SyntaxNode? VisitCompilationUnit(CompilationUnitSyntax node)
    {
        var syntaxTree = node.SyntaxTree;
        var rootNode = syntaxTree.GetRoot();
        var compilation = CSharpCompilation.Create("YourCompilation")
            .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
            .AddSyntaxTrees(syntaxTree);
        
        var propertiesWithBackingFields = ExtractPropertiesWithBackingFields(rootNode, compilation.GetSemanticModel(syntaxTree));

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
        
        return syntaxTree.GetRoot();
    }
    
    private IEnumerable<PropertyWithBackingField> ExtractPropertiesWithBackingFields(SyntaxNode root, SemanticModel semanticModel)
    {
        var properties = root.DescendantNodes().OfType<PropertyDeclarationSyntax>();
        foreach (var property in properties)
        {
            if (property.AccessorList == null || property.AccessorList.Accessors.Count != 2)
                continue;
            var backingField = GetBackingFieldSymbol(property, semanticModel);
            if (backingField != null)
                yield return new PropertyWithBackingField(backingField, property);
        }
    }

    private ISymbol? GetBackingFieldSymbol(PropertyDeclarationSyntax property, SemanticModel semanticModel)
    {
        var propertySymbol = semanticModel.GetDeclaredSymbol(property);
        if (propertySymbol == null) return null;

        foreach (var accessor in propertySymbol.GetMethod?.DeclaringSyntaxReferences.Concat(propertySymbol.SetMethod?.DeclaringSyntaxReferences) ?? [])
        {
            var syntaxNode = accessor.GetSyntax() as AccessorDeclarationSyntax;
            if (syntaxNode == null) continue;

            foreach (var identifier in syntaxNode.DescendantNodes().OfType<IdentifierNameSyntax>())
            {
                var symbol = semanticModel.GetSymbolInfo(identifier).Symbol;
                if (symbol is IFieldSymbol fieldSymbol && fieldSymbol.ContainingType == propertySymbol.ContainingType)
                    return symbol;
            }
        }

        return null;
    }
}