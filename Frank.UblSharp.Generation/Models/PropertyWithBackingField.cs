using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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