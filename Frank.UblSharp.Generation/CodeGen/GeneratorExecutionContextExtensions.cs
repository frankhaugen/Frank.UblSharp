using Microsoft.CodeAnalysis;

namespace Frank.UblSharp.Generation.CodeGen;

internal static class GeneratorExecutionContextExtensions
{
    public static bool TryGetRootNamespace(this GeneratorExecutionContext context, out string? rootNamespace)
    {
        if (context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.rootnamespace", out rootNamespace))
            return true;

        context.ReportDiagnostic(Diagnostic.Create(
            new DiagnosticDescriptor("FRANK0002", "Failed to generate resource helper class, no root namespace",
                "Failed to generate resource helper class, no root namespace", "Frank", DiagnosticSeverity.Error, true),
            Location.None));
        return false;
    }

    public static bool TryGetProjectDir(this GeneratorExecutionContext context, out string? projectDir)
    {
        if (context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.projectdir", out projectDir))
            return true;

        context.ReportDiagnostic(Diagnostic.Create(
            new DiagnosticDescriptor("FRANK0001", "Failed to generate resource helper class, no project directory",
                "Failed to generate resource helper class, no project directory", "Frank", DiagnosticSeverity.Error, true),
            Location.None));
        return false;
    }
}