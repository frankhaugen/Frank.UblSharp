/// <summary>
/// Represents the options for running the xsd.exe tool.
/// </summary>
public class XsdExeOptions
{
    /// <summary>
    /// Gets the paths to the XSD files to process.
    /// </summary>
    public List<FileInfo> XsdFilePaths { get; } = new();

    /// <summary>
    /// Gets or sets the output directory for the generated files.
    /// </summary>
    public required DirectoryInfo OutputDirectory { get; init; }

    /// <summary>
    /// Gets or sets a value indicating whether to generate C# classes from the XSD file.
    /// </summary>
    public bool GenerateClasses { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether to generate a DataSet from the XSD file.
    /// </summary>
    public bool GenerateDataset { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether to generate a DataContract from the XSD file.
    /// </summary>
    public bool GenerateDataContract { get; set; } = false;

    /// <summary>
    /// Gets or sets the namespace for the generated classes.
    /// </summary>
    public string Namespace { get; set; } = "Generated";

    /// <summary>
    /// Gets or sets the programming language for the generated code. Defaults to "CS" (C#).
    /// </summary>
    public string Language { get; set; } = "CS";
}