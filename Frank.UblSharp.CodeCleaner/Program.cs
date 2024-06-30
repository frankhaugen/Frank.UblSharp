// See https://aka.ms/new-console-template for more information

var outputDirectory = new DirectoryInfo(@"D:\frankrepos\Frank.UblSharp\Frank.UblSharp");

// var fileTypesExtractor = new FileTypesExtractor();
//
// var files = outputDirectory.GetFiles("*.cs", SearchOption.TopDirectoryOnly).ToList();
// foreach (var file in files)
// {
//     await fileTypesExtractor.ExtractTypesAsync(file);
// }
// Console.WriteLine("Types extracted.");

var directoryVisitor = new DirectoryVisitor();

for (var i = 0; i < 15; i++)
{
    directoryVisitor.VisitDirectory(outputDirectory);
}