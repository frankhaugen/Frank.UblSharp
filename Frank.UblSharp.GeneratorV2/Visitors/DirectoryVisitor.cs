namespace Frank.UblSharp.GeneratorV2.Visitors;

public class DirectoryVisitor
{
    public void VisitDirectory(DirectoryInfo directory)
    {
        var files = directory.GetFiles("*.cs", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            new FileVisitor().VisitFile(file);
        }
    }
}