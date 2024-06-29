using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV4.Experimental;

public class PropertyDefinitionResult
{
    public string ClassName { get; set; }
    public PropertyDeclarationSyntax PropertyDeclaration { get; set; }
}