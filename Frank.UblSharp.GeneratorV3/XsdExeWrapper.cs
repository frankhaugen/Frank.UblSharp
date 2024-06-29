using System.Text;
using CliWrap;
using CliWrap.Buffered;

namespace Frank.UblSharp.GeneratorV3;

public static class XsdExeWrapper
{
    public static async Task GeneratePocoFromXsd(XsdExeOptions options)
    {
        var arguments = BuildArguments(options);
        var xsdExePath = @"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8.1 Tools\xsd.exe";
        var xsdExe = new FileInfo(xsdExePath);
        
        Console.WriteLine($"Running xsd.exe at {xsdExe.FullName} with arguments:\n<args>{arguments}</args>");

        var result = await Cli.Wrap(xsdExe.FullName)
            .WithArguments(arguments)
            .WithValidation(CommandResultValidation.None)
            .ExecuteBufferedAsync();

        if (result.ExitCode != 0)
        {
            await Console.Error.WriteLineAsync(result.StandardError);
        }
        else
        {
            Console.WriteLine(result.StandardOutput);
        }
    }

    private static string BuildArguments(XsdExeOptions options)
    {
        var args = new StringBuilder();

        args.Append(string.Join(" ", options.XsdFilePaths.Select(x => $"\"{x.FullName}\"")));

        if (options.GenerateClasses)
            args.Append(" /classes");

        if (options.GenerateDataset)
            args.Append(" /dataset");

        if (options.GenerateDataContract)
            args.Append(" /dataContract");

        args.Append($" /namespace:{options.Namespace}");
        args.Append($" /language:{options.Language}");
        args.Append($" /out:{options.OutputDirectory}");

        return args.ToString();
    }
}