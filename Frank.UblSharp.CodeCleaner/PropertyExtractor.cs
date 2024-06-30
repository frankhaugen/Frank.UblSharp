using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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