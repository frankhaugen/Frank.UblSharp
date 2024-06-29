namespace Frank.UblSharp.GeneratorV4;

public class UblGeneratorOptions
{
    public DirectoryInfo OutputDirectory { get; set; }
    public bool GenerateCommonFiles { get; set; }
    public bool CleanOutputDirectoryBeforeGeneration { get; set; }
    public string Namespace { get; set; } = "Frank.UblSharp";
}