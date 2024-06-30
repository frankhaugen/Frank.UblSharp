using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV4.Experimental;

public class ClassDeclarationResult
{
    public string ClassName { get; set; }
    public ClassDeclarationSyntax ClassDeclaration { get; set; }
}