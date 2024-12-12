

namespace CalculatorCLI.Services
{
    public class DisplayService
    {
        public void ShowOptions()
        {
            Console.WriteLine("Simple CLI Calculator");
            Console.WriteLine("Supported operations: +, -, *, /");
            Console.WriteLine();
        }

        public void ShowResult(double result)
        {
            Console.WriteLine($"Result: {result}");
        }

        public void ShowError(string message)
        {
            Console.WriteLine($"Error: {message}");
        }
    }
}
