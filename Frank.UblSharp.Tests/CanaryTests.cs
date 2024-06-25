using Frank.UblSharp.Generator;
using Xunit.Abstractions;

namespace Frank.UblSharp.Tests;

public class CanaryTests
{
    private readonly ITestOutputHelper _outputHelper;

    public CanaryTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void Run()
    {
        var result = Canary.Run();
        Assert.NotNull(result);
        
        _outputHelper.WriteLine(result);
    }
}