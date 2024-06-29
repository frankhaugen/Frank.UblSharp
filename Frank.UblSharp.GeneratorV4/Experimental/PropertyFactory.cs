using System.Diagnostics;
using System.Xml.Schema;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV4.Experimental;

public static class PropertyFactory
{
    public static List<PropertyDeclarationSyntax> GenerateProperties(IEnumerable<XmlSchemaElement> elements)
    {
        var propertyDeclarations = new List<PropertyDeclarationSyntax>();

        foreach (var childElement in elements)
            try
            {
                var propertyName = childElement.QualifiedName.Name;
                var propertyType = GetCSharpType(childElement.ElementSchemaType);
                var propertyDeclaration = GenerateProperty(propertyName, propertyType);
                propertyDeclarations.Add(propertyDeclaration);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        return propertyDeclarations;
    }

    public static List<PropertyDeclarationSyntax> GenerateProperties(XmlSchemaComplexType complexType)
    {
        var propertyDeclarations = new List<PropertyDeclarationSyntax>();

        switch (complexType.Particle)
        {
            case XmlSchemaSequence schemaSequence:
                propertyDeclarations.AddRange(GenerateProperties(schemaSequence.Items.OfType<XmlSchemaElement>()));
                break;
            case XmlSchemaChoice schemaChoice:
                propertyDeclarations.AddRange(GenerateProperties(schemaChoice.Items.OfType<XmlSchemaElement>()));
                break;
            case XmlSchemaAll schemaAll:
                propertyDeclarations.AddRange(GenerateProperties(schemaAll.Items.OfType<XmlSchemaElement>()));
                break;
            case XmlSchemaAny schemaAny:
                Debugger.Break();
                break;
        }
        
        propertyDeclarations = propertyDeclarations
            .GroupBy(p => p.Identifier.Text)
            .Select(g => g.First())
            .ToList();
        
        propertyDeclarations = propertyDeclarations
            .Where(p => complexType.BaseXmlSchemaType == null || complexType.BaseXmlSchemaType.QualifiedName.Name != p.Identifier.Text)
            .ToList();
        
        return propertyDeclarations;
    }

    public static PropertyDeclarationSyntax GenerateProperty(string propertyName, string propertyType)
    {
        var propertyDeclaration = SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName(propertyType), propertyName)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .AddAccessorListAccessors(
                SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)));

        return propertyDeclaration;
    }

    public static string? GetCSharpType(XmlSchemaType? schemaType) 
        => schemaType switch
        {
            null => null,
            XmlSchemaComplexType complexType => complexType.Name + "?",
            _ => schemaType.Name switch
            {
                "string" => "string?",
                "int" => "int?",
                "integer" => "int?",
                "boolean" => "bool?",
                "date" => "DateOnly?",
                "dateTime" => "DateTime?",
                "decimal" => "decimal?",
                _ => "object?",
            }
        };

    public static string? GetCSharpType(XmlSchemaDatatype? complexTypeDatatype)
    {
        if (complexTypeDatatype == null)
        {
            return null;
        }

        return complexTypeDatatype.TypeCode switch
        {
            XmlTypeCode.String => "string?",
            XmlTypeCode.Int => "int?",
            XmlTypeCode.Integer => "int?",
            XmlTypeCode.Boolean => "bool?",
            XmlTypeCode.Date => "DateOnly?",
            XmlTypeCode.DateTime => "DateTime?",
            XmlTypeCode.Decimal => "decimal?",
            XmlTypeCode.Byte => "byte?",
            XmlTypeCode.Base64Binary => "byte[]?",
            XmlTypeCode.Duration => "TimeSpan?",
            XmlTypeCode.Float => "decimal?",
            XmlTypeCode.Text => "string?",
            XmlTypeCode.Long => "long?",
            _ => "object?",
        };
    }
}