using System.Xml.Schema;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV4.Experimental;

public class XsdToCSharpGenerator
{
    private readonly Dictionary<string, ClassDeclarationSyntax> _classDefinitions = new();
    private readonly XmlSchemaSet _schemaSet;

    public XsdToCSharpGenerator(XmlSchemaSet schemaSet)
    {
        _schemaSet = schemaSet;
    }

    public CodeGenerationResult Generate()
    {
        foreach (XmlSchema schema in _schemaSet.Schemas())
        {
            var complexTypes = schema.Items.OfType<XmlSchemaComplexType>();
            foreach (var item in complexTypes)
            {
                var classDeclarationSyntax = ClassFactory.GenerateClass(item);
                _classDefinitions.TryAdd(item.Name!, classDeclarationSyntax);
            }
            
            IEnumerable<XmlSchemaSimpleType?> simpleTypes = schema.Items.OfType<XmlSchemaSimpleType>();
            foreach (var item in simpleTypes)
            {
                var classDeclarationSyntax = ClassFactory.GenerateClass(item);
                _classDefinitions.TryAdd(item.Name!, classDeclarationSyntax);
            }
        }

        return new CodeGenerationResult
        {
            ClassDeclarations = _classDefinitions.Select(kvp => new ClassDeclarationResult
            {
                ClassName = kvp.Key,
                ClassDeclaration = kvp.Value
            }).ToList()
        };
    }
}