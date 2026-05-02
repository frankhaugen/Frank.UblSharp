using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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

    public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax name)
    {
        if (name.Identifier.ValueText.Equals(_backingField.Name, StringComparison.Ordinal))
        {
            var symbolInfo = _semanticModel.GetSymbolInfo(name);
            if (symbolInfo.Symbol is { } sym
                && SymbolEqualityComparer.Default.Equals(sym.OriginalDefinition, _backingField))
            {
                name = name.WithIdentifier(SyntaxFactory.Identifier(_property.Identifier.ValueText));
                return name;
            }
        }

        return base.VisitIdentifierName(name);
    }

    public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax propertyDeclaration)
    {
        if (propertyDeclaration == _property)
            return ConvertToAutoProperty(propertyDeclaration);
        return base.VisitPropertyDeclaration(propertyDeclaration);
    }

    public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax field)
    {
        if (field.Declaration.Variables.Count == 1
            && SymbolEqualityComparer.Default.Equals(
                _semanticModel.GetDeclaredSymbol(field.Declaration.Variables.First()),
                _backingField))
        {
            return null;
        }

        return base.VisitFieldDeclaration(field);
    }

    public override SyntaxNode? VisitVariableDeclarator(VariableDeclaratorSyntax variable)
    {
        if (variable.Parent?.Parent is FieldDeclarationSyntax field
            && field.Declaration.Variables.Count == 1
            && SymbolEqualityComparer.Default.Equals(_semanticModel.GetDeclaredSymbol(variable), _backingField))
        {
            return null;
        }

        return base.VisitVariableDeclarator(variable);
    }

    private static PropertyDeclarationSyntax ConvertToAutoProperty(PropertyDeclarationSyntax propertyDeclaration)
    {
        return propertyDeclaration.WithAccessorList(SyntaxFactory.AccessorList(SyntaxFactory.List(new[]
        {
            SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
            SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
        })));
    }
}
