using Frank.UblSharp.GeneratorV2.SyntaxRewriters;
using Microsoft.CodeAnalysis.MSBuild;

namespace Frank.UblSharp.GeneratorV2;

public class WorkspaceVisitor
{
    public async Task VisitAsync(MSBuildWorkspace workspace)
    {
        var solution = workspace.CurrentSolution;
        foreach (var project in solution.Projects)
        foreach (var document in project.Documents)
        {
            var root = await document.GetSyntaxRootAsync();
            if (root is null) continue;

            var newRoot = new PropertyRewriter().Visit(root);
            if (newRoot != root) solution = solution.WithDocumentSyntaxRoot(document.Id, newRoot);
        }

        workspace.TryApplyChanges(solution);
    }
}