using Frank.UblSharp.GeneratorV2.SyntaxRewriters;
using Microsoft.CodeAnalysis.MSBuild;

namespace Frank.UblSharp.GeneratorV2.Visitors;

public class WorkspaceVisitor
{
    private readonly SyntaxTreeRewriter _syntaxTreeRewriter = new();
    
    public async Task VisitAsync(MSBuildWorkspace workspace)
    {
        var solution = workspace.CurrentSolution;
        foreach (var project in solution.Projects)
        foreach (var document in project.Documents)
        {
            var root = await document.GetSyntaxRootAsync();
            if (root is null) continue;
            var newRoot = _syntaxTreeRewriter.Rewrite(root.SyntaxTree);
            if (newRoot != root) solution = solution.WithDocumentSyntaxRoot(document.Id, newRoot);
        }

        workspace.TryApplyChanges(solution);
    }
}