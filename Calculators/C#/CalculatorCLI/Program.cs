using Microsoft.Extensions.DependencyInjection;
using CalculatorCLI.Services;
using CalculatorCLI.Runner;
using CalculatorCLI.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<ICalculator, CalculatorService>()
            .AddSingleton<InputParserService>()
            .AddSingleton<DisplayService>()
            .AddSingleton<CalculatorRunner>()
            .BuildServiceProvider();

        var runner = serviceProvider.GetService<CalculatorRunner>();
        runner.Run();
    }
}