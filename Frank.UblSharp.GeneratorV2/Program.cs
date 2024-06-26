using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;

namespace Frank.UblSharp.GeneratorV2;

public class Program
{
    public static async Task Main()
    {
        var outputDirectory = new DirectoryInfo(@"D:\frankrepos\Frank.UblSharp\Frank.UblSharp");
        new DirectoryVisitor().VisitDirectory(outputDirectory);
    }


    public class DirectoryVisitor
    {
        public void VisitDirectory(DirectoryInfo directory)
        {
            var files = directory.GetFiles("*.cs", SearchOption.AllDirectories);
            foreach (var file in files) new FileVisitor().VisitFile(file);
        }
    }

    public class FileVisitor
    {
        public void VisitFile(FileInfo file)
        {
            var code = File.ReadAllText(file.FullName);
            var syntaxTree = CSharpSyntaxTree.ParseText(code);
            
            var rewriter = new SyntaxTreeRewriter();
            rewriter.Rewrite(ref syntaxTree);

            var newCode = Formatter.Format(syntaxTree.GetRoot(), new AdhocWorkspace()).ToFullString();

            File.WriteAllText(file.FullName, newCode);
        }
    }
    
    private class SyntaxTreeRewriter
    {
        public void Rewrite(ref SyntaxTree syntaxTree)
        {
            var rootNode = syntaxTree.GetRoot();
            var compilation = CSharpCompilation.Create("YourCompilation")
                .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
                .AddSyntaxTrees(syntaxTree); // Add the SyntaxTree here
        
            var propertiesWithBackingFields = new PropertyExtractor(compilation.GetSemanticModel(syntaxTree)).ExtractPropertiesWithBackingFields(rootNode);
        
            foreach (var propertiesWithBackingField in propertiesWithBackingFields)
            {
                var rewriter = new PropertyRewriter(compilation.GetSemanticModel(syntaxTree), propertiesWithBackingField.BackingField, propertiesWithBackingField.Property);
                var newRootNode = rewriter.Visit(rootNode);
        
                // After doing the rewrite, refresh the syntax tree and semantic model.
                var newSyntaxTree = newRootNode.SyntaxTree;
                rootNode = newRootNode;
                compilation = compilation.ReplaceSyntaxTree(syntaxTree, newSyntaxTree);
                syntaxTree = newSyntaxTree;
            }
        }
    }

    private class PropertyRewriter : CSharpSyntaxRewriter
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

        public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax name)
        {
            if (_backingField != null && name.Identifier.ValueText.Equals(_backingField.Name))
            {
                var symbolInfo = _semanticModel.GetSymbolInfo(name);
                if (symbolInfo.Symbol != null && Equals(symbolInfo.Symbol.OriginalDefinition, _backingField))
                {
                    name = name.WithIdentifier(SyntaxFactory.Identifier(_property.Identifier.ValueText));
                    return name.WithAdditionalAnnotations(Formatter.Annotation);
                }
            }

            return name;
        }

        public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax propertyDeclaration)
        {
            if (propertyDeclaration == _property) return ConvertToAutoProperty(propertyDeclaration).WithAdditionalAnnotations(Formatter.Annotation);
            return base.VisitPropertyDeclaration(propertyDeclaration);
        }

        public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax field)
        {
            if (field == null)
                return null;
            if (field.Declaration.Variables.Count == 1 && Equals(_semanticModel.GetDeclaredSymbol(field.Declaration.Variables.First()), _backingField)) return null;
            return field;
        }

        public override SyntaxNode VisitVariableDeclarator(VariableDeclaratorSyntax variable)
        {
            if (variable.Parent.Parent is FieldDeclarationSyntax field && field.Declaration.Variables.Count == 1 && Equals(_semanticModel.GetDeclaredSymbol(variable), _backingField)) return null;
            return variable;
        }

        private PropertyDeclarationSyntax ConvertToAutoProperty(PropertyDeclarationSyntax propertyDeclaration)
        {
            return propertyDeclaration.WithAccessorList(SyntaxFactory.AccessorList(SyntaxFactory.List(new[]
            {
                SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
            })));
        }
    }

    public class PropertyExtractor
    {
        private readonly SemanticModel _semanticModel;

        public PropertyExtractor(SemanticModel semanticModel)
        {
            _semanticModel = semanticModel;
        }

        public IEnumerable<PropertyWithBackingField> ExtractPropertiesWithBackingFields(SyntaxNode root)
        {
            var properties = root.DescendantNodes().OfType<PropertyDeclarationSyntax>();
            foreach (var property in properties)
            {
                if (property.AccessorList == null || property.AccessorList.Accessors.Count != 2)
                    continue;
                var backingField = GetBackingFieldSymbol(property);
                if (backingField != null)
                    yield return new PropertyWithBackingField(backingField, property);
            }
        }

        private ISymbol? GetBackingFieldSymbol(PropertyDeclarationSyntax property)
        {
            var propertySymbol = _semanticModel.GetDeclaredSymbol(property);
            if (propertySymbol == null) return null;
            if (propertySymbol.SetMethod?.DeclaringSyntaxReferences == null) return null;

            foreach (var accessor in propertySymbol.GetMethod?.DeclaringSyntaxReferences.Concat(propertySymbol.SetMethod?.DeclaringSyntaxReferences ?? []) ?? [])
            {
                var syntaxNode = accessor.GetSyntax() as AccessorDeclarationSyntax;
                var identifier = syntaxNode?.DescendantNodes().OfType<IdentifierNameSyntax>().FirstOrDefault();
                if (identifier == null) continue;
                var symbol = _semanticModel.GetSymbolInfo(identifier).Symbol;
                if (symbol is { Kind: SymbolKind.Field })
                    return symbol;
            }

            return null;
        }
    }

    public struct PropertyWithBackingField
    {
        public ISymbol BackingField { get; }
        public PropertyDeclarationSyntax Property { get; }

        public PropertyWithBackingField(ISymbol backingField, PropertyDeclarationSyntax property)
        {
            BackingField = backingField;
            Property = property;
        }
    }
}