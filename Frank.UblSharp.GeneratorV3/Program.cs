// See https://aka.ms/new-console-template for more information

var XsdExeOptions = new XsdExeOptions
{
    OutputDirectory = new DirectoryInfo("D:\\frankrepos\\Frank.UblSharp\\Frank.UblSharp"),
    Namespace = "Frank.UblSharp",
    Language = "CS",
    GenerateClasses = true,
    XsdFilePath = new FileInfo("D:\\frankrepos\\Frank.UblSharp\\Frank.UblSharp\\Resources\\UBL-Invoice-2.1.xsd")
};

await XsdExeWrapper.GeneratePocoFromXsd(XsdExeOptions);
