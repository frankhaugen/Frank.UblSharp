internal class DirectoryVisitor
{
    public void VisitDirectory(DirectoryInfo directory)
    {
        var parallelOptions = new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount };
        Parallel.ForEach(directory.GetFiles("*.cs", SearchOption.TopDirectoryOnly), parallelOptions, file => new FileVisitor().VisitFile(file));
        Parallel.ForEach(directory.EnumerateDirectories().Where(d => d.Name != "obj" && d.Name != "bin"), parallelOptions, VisitDirectory);
    }
}