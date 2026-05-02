using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Schema;
using Frank.UblSharp.Internals.XsdCodeGenerator;
using Frank.UblSharp.Resources;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using XmlSchemaClassGenerator;

namespace Frank.UblSharp.Generation.CodeGen;

[Generator]
public class UblCodeGenerator : ISourceGenerator
{
    private static readonly string[] CodeAnalysisAttributeNames =
    [
        "AllowNull", "DisallowNull", "MaybeNull", "NotNull", "DoesNotReturn", "DoesNotReturnIf",
        "MemberNotNull", "MemberNotNullWhen", "NotNullIfNotNull", "NotNullWhen", "SetsRequiredMembers",
    ];

    private static readonly string[] DataAnnotationsAttributeNames =
    [
        "Required", "StringLength", "MaxLength", "MinLength", "Range", "Key", "EmailAddress", "Phone", "Url",
        "CreditCard", "Compare", "RegularExpression",
    ];

    /// <summary>CLR types CodeDom may emit as <c>global::Byte</c> etc., which are not in the global namespace.</summary>
    private static readonly string[] GlobalSystemTypeAliases =
    [
        "Boolean", "Byte", "SByte", "Int16", "UInt16", "Int32", "UInt32", "Int64", "UInt64", "Char", "Single", "Double",
        "Decimal", "String", "Object", "IntPtr", "UIntPtr", "Void", "DateTime", "DateTimeOffset", "TimeSpan", "Guid",
    ];

    /// <inheritdoc />
    public void Initialize(GeneratorInitializationContext context)
    {
    }

    /// <inheritdoc />
    public void Execute(GeneratorExecutionContext context)
    {
        var xmlSchemaSet = ResourcesHelper.GetXmlSchemaSet();
        // Run fixups on the full schema set before filtering; renamers depend on imported CCT/UDT schemas.
        new XmlSchemaMetaVisitor().Visit(xmlSchemaSet);
        var schemaFilter = new UblMainDocumentXmlSchemaFilter();
        xmlSchemaSet = schemaFilter.Filter(xmlSchemaSet);

        if (!context.TryGetProjectDir(out var projectDir) || !context.TryGetRootNamespace(out var rootNamespace)) return;
        if (projectDir is null) return;
        if (rootNamespace is null) return;

        var outputDir = new DirectoryInfo(projectDir);
        var codeWriter = new CodeWriter(cn => EmitNamespaceSource(context, cn));
        var generator = UblGeneratorFactory.Create(
            outputDir,
            s => context.ReportDiagnostic(Diagnostic.Create(
                new DiagnosticDescriptor("FRANK0003", "Failed to generate UBL classes", s, "Frank", DiagnosticSeverity.Error, true),
                Location.None)),
            codeWriter);
        generator.Generate(xmlSchemaSet);
    }

    private static void EmitNamespaceSource(GeneratorExecutionContext context, CodeNamespace codeNamespace)
    {
        using var stringWriter = new StringWriter();
        using var provider = CodeDomProvider.CreateProvider("CSharp");
        var options = new CodeGeneratorOptions
        {
            BracingStyle = "C",
            BlankLinesBetweenMembers = false,
        };
        provider.GenerateCodeFromNamespace(codeNamespace, stringWriter, options);
        var raw = stringWriter.ToString();
        var parseOptions = CSharpParseOptions.Default.WithLanguageVersion(LanguageVersion.Preview);
        var tree = CSharpSyntaxTree.ParseText(SourceText.From(raw, Encoding.UTF8), parseOptions);
        var root = tree.GetCompilationUnitRoot();
        var rewriter = new CompilationUnitSyntaxRewriter();
        var rewritten = rewriter.Visit(root);
        var formatted = rewritten?.NormalizeWhitespace() ?? root.NormalizeWhitespace();
        var text = FixDoubledAttributeTypeNames(formatted.ToFullString());
        var sourceText = SourceText.From(text, Encoding.UTF8);
        var hint = Regex.Replace(codeNamespace.Name, @"[^\w]", "_");
        context.AddSource($"{hint}.g.cs", sourceText);
    }

    /// <summary>
    /// XmlSchemaClassGenerator + CodeDom with <see cref="CodeTypeReferenceOptions.GlobalReference"/> can emit
    /// <c>FooAttributeAttribute</c> / <c>global::FooAttributeAttribute</c> for attribute types that already end in <c>Attribute</c>.
    /// </summary>
    private static string FixDoubledAttributeTypeNames(string source)
    {
        // Doubled "Attribute" suffix (CodeDom + GlobalReference edge cases).
        source = Regex.Replace(
            source,
            @"global::(Xml[A-Za-z0-9_]*)AttributeAttribute\b",
            static m => "global::System.Xml.Serialization." + m.Groups[1].Value + "Attribute",
            RegexOptions.CultureInvariant);
        source = Regex.Replace(
            source,
            @"global::System\.Xml\.Serialization\.(Xml[A-Za-z0-9_]*)AttributeAttribute\b",
            static m => "global::System.Xml.Serialization." + m.Groups[1].Value + "Attribute",
            RegexOptions.CultureInvariant);
        source = Regex.Replace(
            source,
            @"(?<![A-Za-z0-9_\.])(Xml[A-Za-z0-9_]*)AttributeAttribute\b",
            static m => "global::System.Xml.Serialization." + m.Groups[1].Value + "Attribute",
            RegexOptions.CultureInvariant);

        // CodeDom emits [global::XmlTypeAttribute(...)] — one "Attribute", but still in the wrong (global) namespace.
        source = Regex.Replace(
            source,
            @"global::(Xml[A-Za-z0-9_]*)Attribute\b(?![A-Za-z0-9_])",
            static m =>
            {
                var g = m.Groups[1].Value;
                return g == "Xml"
                    ? "global::System.Xml.XmlAttribute"
                    : "global::System.Xml.Serialization." + g + "Attribute";
            },
            RegexOptions.CultureInvariant);

        source = source.Replace(
            "global::DebuggerStepThroughAttributeAttribute",
            "global::System.Diagnostics.DebuggerStepThroughAttribute",
            StringComparison.Ordinal);
        source = source.Replace(
            "DebuggerStepThroughAttributeAttribute",
            "global::System.Diagnostics.DebuggerStepThroughAttribute",
            StringComparison.Ordinal);
        source = source.Replace(
            "global::DebuggerStepThroughAttribute",
            "global::System.Diagnostics.DebuggerStepThroughAttribute",
            StringComparison.Ordinal);
        source = Regex.Replace(
            source,
            @"(?<![A-Za-z0-9_\.])DebuggerStepThroughAttributeAttribute\b",
            "global::System.Diagnostics.DebuggerStepThroughAttribute",
            RegexOptions.CultureInvariant);

        source = source.Replace(
            "global::GeneratedCodeAttributeAttribute",
            "global::System.CodeDom.Compiler.GeneratedCodeAttribute",
            StringComparison.Ordinal);
        source = source.Replace(
            "GeneratedCodeAttributeAttribute",
            "global::System.CodeDom.Compiler.GeneratedCodeAttribute",
            StringComparison.Ordinal);
        source = source.Replace(
            "global::GeneratedCodeAttribute",
            "global::System.CodeDom.Compiler.GeneratedCodeAttribute",
            StringComparison.Ordinal);
        source = Regex.Replace(
            source,
            @"(?<![A-Za-z0-9_\.])GeneratedCodeAttribute\b(?!\w)",
            "global::System.CodeDom.Compiler.GeneratedCodeAttribute",
            RegexOptions.CultureInvariant);

        source = Regex.Replace(
            source,
            @"global::System\.Diagnostics\.CodeAnalysis\.(\w+)AttributeAttribute\b",
            static m => "global::System.Diagnostics.CodeAnalysis." + m.Groups[1].Value + "Attribute",
            RegexOptions.CultureInvariant);
        source = Regex.Replace(
            source,
            @"global::System\.ComponentModel\.DataAnnotations\.(\w+)AttributeAttribute\b",
            static m => "global::System.ComponentModel.DataAnnotations." + m.Groups[1].Value + "Attribute",
            RegexOptions.CultureInvariant);

        foreach (var name in CodeAnalysisAttributeNames)
        {
            var esc = Regex.Escape(name);
            var qualified = "global::System.Diagnostics.CodeAnalysis." + name + "Attribute";
            source = Regex.Replace(
                source,
                @"global::" + esc + @"AttributeAttribute\b",
                qualified,
                RegexOptions.CultureInvariant);
            source = Regex.Replace(
                source,
                @"\b" + esc + @"AttributeAttribute\b",
                qualified,
                RegexOptions.CultureInvariant);
            source = Regex.Replace(
                source,
                @"global::" + esc + @"Attribute\b",
                qualified,
                RegexOptions.CultureInvariant);
        }

        foreach (var name in DataAnnotationsAttributeNames)
        {
            var esc = Regex.Escape(name);
            var qualified = "global::System.ComponentModel.DataAnnotations." + name + "Attribute";
            source = Regex.Replace(
                source,
                @"global::" + esc + @"AttributeAttribute\b",
                qualified,
                RegexOptions.CultureInvariant);
            source = Regex.Replace(
                source,
                @"\b" + esc + @"AttributeAttribute\b",
                qualified,
                RegexOptions.CultureInvariant);
        }

        source = source.Replace(
            "global::Collection<",
            "global::System.Collections.ObjectModel.Collection<",
            StringComparison.Ordinal);

        foreach (var t in GlobalSystemTypeAliases)
        {
            source = Regex.Replace(
                source,
                @"global::" + Regex.Escape(t) + @"\b",
                "global::System." + t,
                RegexOptions.CultureInvariant);
        }

        // CodeDom emits illegal trailing semicolon after auto-implemented properties: "{ get; set; };"
        source = Regex.Replace(
            source,
            @"\{\s*get;\s*set;\s*\}\s*;",
            "{ get; set; }",
            RegexOptions.CultureInvariant);

        // CodeDom emits "};" after full get/set property bodies (invalid C#).
        source = Regex.Replace(
            source,
            @"\}\s*;\s*(?=\r?\n(?:\s*\r?\n)*\s*(?:///|\[|public\b|private\b|protected\b|\}))",
            "}",
            RegexOptions.CultureInvariant);

        return source;
    }

    private sealed class CodeWriter : OutputWriter
    {
        private readonly Action<CodeNamespace> _emit;

        public CodeWriter(Action<CodeNamespace> emit) => _emit = emit;

        public override void Write(CodeNamespace cn) => _emit(cn);
    }
}
