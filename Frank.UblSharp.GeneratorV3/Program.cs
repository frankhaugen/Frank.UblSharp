// See https://aka.ms/new-console-template for more information

using Frank.UblSharp.GeneratorV3;
using Humanizer;

var commonFiles = new DirectoryInfo("D:\\frankrepos\\Frank.UblSharp\\Frank.UblSharp.Resources\\xsd\\common").GetFiles();
var mainDocFiles = new DirectoryInfo("D:\\frankrepos\\Frank.UblSharp\\Frank.UblSharp.Resources\\xsd\\maindoc").GetFiles();
var rootOutputDirectory = new DirectoryInfo("D:\\frankrepos\\Frank.UblSharp\\Frank.UblSharp");

foreach (var mainDocFile in mainDocFiles)
{
    var ublDocumentName = mainDocFile.Name.Split('-')[1];
    var outputSubDirectoryName = ublDocumentName.Pluralize();
    var outputDirectory = new DirectoryInfo(Path.Combine(rootOutputDirectory.FullName, outputSubDirectoryName));
    
    if (!outputDirectory.Exists)
    {
        outputDirectory.Create();
    }
    else
    {
        foreach (var file in outputDirectory.GetFiles())
        {
            file.Delete();
        }
    }
    
    var xsdExeOptions = new XsdExeOptions
    {
        OutputDirectory = outputDirectory,
        Namespace = "Frank.UblSharp." + outputSubDirectoryName,
        Language = "CS",
    };
    xsdExeOptions.XsdFilePaths.AddRange(commonFiles);
    xsdExeOptions.XsdFilePaths.Add(mainDocFile);
    
    await XsdExeWrapper.GeneratePocoFromXsd(xsdExeOptions);
}