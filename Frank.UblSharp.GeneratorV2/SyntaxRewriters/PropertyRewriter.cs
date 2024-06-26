using Microsoft.CodeAnalysis.CSharp;

namespace Frank.UblSharp.GeneratorV2.SyntaxRewriters;

/// <summary>
/// Rewrites the syntax tree to look at properties and make them auto-properties, ([Accessor] [Type] [Name] { get; set; }), then removes the backing fields afterwords.
/// </summary>
public class AutoPropertyRewriter : CSharpSyntaxRewriter
{
    
}