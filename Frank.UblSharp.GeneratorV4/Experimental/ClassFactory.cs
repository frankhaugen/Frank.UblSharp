using System.Diagnostics;
using System.Xml.Schema;
using Frank.UblSharp.GeneratorV4.Experimental;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public static class ClassFactory
{
    public static ClassDeclarationSyntax GenerateClass(XmlSchemaComplexType complexType)
    {
        var className = complexType.Name;
        var classDeclaration = SyntaxFactory.ClassDeclaration(className)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));

        if (complexType.BaseXmlSchemaType != null && complexType.BaseXmlSchemaType.QualifiedName.Namespace != "http://www.w3.org/2001/XMLSchema")
        {
            var baseTypeName = complexType.BaseXmlSchemaType.QualifiedName.Name;
            var baseTypeNamespace = complexType.BaseXmlSchemaType.QualifiedName.Namespace;
            classDeclaration = classDeclaration.AddBaseListTypes(SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName(baseTypeName)));
        }
        
        var properties = PropertyFactory.GenerateProperties(complexType);

        if (properties.Count > 0)
        {
            classDeclaration = classDeclaration.AddMembers(properties.ToArray());
        }
        else
        {
            var typeName = PropertyFactory.GetCSharpType(complexType.Datatype) ?? PropertyFactory.GetCSharpType(complexType) ?? PropertyFactory.GetCSharpType(complexType);
            var propertyDeclaration = PropertyFactory.GenerateProperty("Value", typeName ?? "string?");
            classDeclaration = classDeclaration.AddMembers(propertyDeclaration);
        }

        return classDeclaration;
    }

    public static ClassDeclarationSyntax GenerateClass(XmlSchemaSimpleType? simpleType)
    {
        var className = simpleType.Name;
        var classDeclaration = SyntaxFactory.ClassDeclaration(className)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));
        
        if (simpleType.Content is XmlSchemaSimpleTypeRestriction restriction)
        {
            foreach (var facet in restriction.Facets.OfType<XmlSchemaEnumerationFacet>())
            {
                var propertyName = facet.Value;
                var propertyType = PropertyFactory.GetCSharpType(simpleType);
                var propertyDeclaration = PropertyFactory.GenerateProperty(propertyName, propertyType);
                classDeclaration = classDeclaration.AddMembers(propertyDeclaration);
            }
        }
        else
        {
            Console.WriteLine("Unknown content type: " + simpleType.Name + " " + simpleType.GetType().Name);
        }

        return classDeclaration;
    }
}