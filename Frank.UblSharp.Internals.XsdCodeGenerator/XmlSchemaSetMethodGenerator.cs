using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Frank.UblSharp.Internals.XsdCodeGenerator
{
    internal static class XmlSchemaSetMethodGenerator
    {
        public static MethodDeclarationSyntax GenerateGetXmlSchemaSetMethod()
        {
            var varType = SyntaxFactory.IdentifierName("var");
            var xmlSchemaSetType = SyntaxFactory.ParseTypeName("XmlSchemaSet");

            var schemaSetDeclaration = SyntaxFactory.LocalDeclarationStatement(
                SyntaxFactory.VariableDeclaration(varType)
                    .WithVariables(
                        SyntaxFactory.SingletonSeparatedList(
                            SyntaxFactory.VariableDeclarator("schemaSet")
                                .WithInitializer(
                                    SyntaxFactory.EqualsValueClause(
                                        SyntaxFactory.ObjectCreationExpression(xmlSchemaSetType)
                                            .WithArgumentList(SyntaxFactory.ArgumentList()))))));

            var foreachStatement = GenerateForeachStatement();

            var compileStatement = SyntaxFactory.ExpressionStatement(
                SyntaxFactory.InvocationExpression(
                    SyntaxFactory.MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        SyntaxFactory.IdentifierName("schemaSet"),
                        SyntaxFactory.IdentifierName("Compile"))));

            var returnStatement = SyntaxFactory.ReturnStatement(SyntaxFactory.IdentifierName("schemaSet"));

            var methodBody = SyntaxFactory.Block(schemaSetDeclaration, foreachStatement, compileStatement, returnStatement);

            return SyntaxFactory.MethodDeclaration(xmlSchemaSetType, "GetXmlSchemaSet")
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword))
                .WithBody(methodBody);
        }

        private static ForEachStatementSyntax GenerateForeachStatement()
        {
            return SyntaxFactory.ForEachStatement(
                SyntaxFactory.IdentifierName("var"),
                SyntaxFactory.Identifier("xsdFile"),
                SyntaxFactory.IdentifierName("Files"),
                SyntaxFactory.Block(
                    SyntaxFactory.ExpressionStatement(
                        SyntaxFactory.InvocationExpression(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    SyntaxFactory.IdentifierName("schemaSet"),
                                    SyntaxFactory.IdentifierName("Add")))
                            .WithArgumentList(
                                SyntaxFactory.ArgumentList(
                                    SyntaxFactory.SeparatedList(new[]
                                    {
                                        SyntaxFactory.Argument(
                                            SyntaxFactory.InvocationExpression(
                                                    SyntaxFactory.MemberAccessExpression(
                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                        SyntaxFactory.IdentifierName("XmlSchema"),
                                                        SyntaxFactory.IdentifierName("Read")))
                                                .WithArgumentList(
                                                    SyntaxFactory.ArgumentList(
                                                        SyntaxFactory.SeparatedList(new[]
                                                        {
                                                            SyntaxFactory.Argument(
                                                                SyntaxFactory.InvocationExpression(
                                                                    SyntaxFactory.MemberAccessExpression(
                                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                                        SyntaxFactory.IdentifierName("xsdFile"),
                                                                        SyntaxFactory.IdentifierName("OpenText")))),
                                                            SyntaxFactory.Argument(
                                                                SyntaxFactory.LiteralExpression(SyntaxKind.NullLiteralExpression))
                                                        }))))
                                    }))))));
        }
    }
}