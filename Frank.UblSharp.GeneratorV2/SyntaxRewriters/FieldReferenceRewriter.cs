using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.GeneratorV2.SyntaxRewriters;

public class FieldReferenceRewriter : CSharpSyntaxRewriter
{
    private readonly string _fieldName;
    private readonly string _propertyName;

    public FieldReferenceRewriter(string fieldName, string propertyName)
    {
        _fieldName = fieldName;
        _propertyName = propertyName;
    }

    public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
    {
        if (node.Identifier.Text == _fieldName)
        {
            return SyntaxFactory.IdentifierName(_propertyName)
                .WithTriviaFrom(node);
        }

        return base.VisitIdentifierName(node);
    }
}