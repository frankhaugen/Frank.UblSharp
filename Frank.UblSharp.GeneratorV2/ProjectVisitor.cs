using Microsoft.CodeAnalysis;

namespace Frank.UblSharp.GeneratorV2;

public class ProjectVisitor
{
    public async Task VisitAsync(Project project)
    {
        var documentVisitor = new DocumentVisitor();
        foreach (var document in project.Documents) await documentVisitor.VisitAsync(document);
    }
}