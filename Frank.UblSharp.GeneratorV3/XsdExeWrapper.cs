using System.Text;
using CliWrap;
using CliWrap.Buffered;

public class XsdExeWrapper
{
    public static async Task GeneratePocoFromXsd(XsdExeOptions options)
    {
        var arguments = BuildArguments(options);
        var xsdExePath = @"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8.1 Tools\xsd.exe";
        var xsdExe = new FileInfo(xsdExePath);

        var result = await Cli.Wrap(xsdExe.FullName)
            .WithArguments(arguments)
            .ExecuteBufferedAsync();

        if (result.ExitCode != 0)
        {
            throw new Exception(result.StandardError);
        }

        Console.WriteLine(result.StandardOutput);
    }

    private static string BuildArguments(XsdExeOptions options)
    {
        var args = new StringBuilder();

        args.Append(options.XsdFilePath);

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