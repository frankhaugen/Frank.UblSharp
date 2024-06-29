// See https://aka.ms/new-console-template for more information

var xsdExeOptions = new XsdExeOptions
{
    OutputDirectory = new DirectoryInfo("D:\\frankrepos\\Frank.UblSharp\\Frank.UblSharp"),
    Namespace = "Frank.UblSharp",
    XsdFilePath = new FileInfo("D:\\frankrepos\\Frank.UblSharp\\UBL-2.1\\exp\\UBL-Invoice-2.1.xsd")
    // XsdFilePath = new FileInfo("D:\\frankrepos\\Frank.UblSharp\\UBL-2.1\\xsdrt\\maindoc\\UBL-Invoice-2.1.xsd")
};

await XsdExeWrapper.GeneratePocoFromXsd(xsdExeOptions);
