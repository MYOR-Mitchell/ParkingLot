using CalculatorCLI.Interfaces;
using CalculatorCLI.Services;

namespace CalculatorCLI.Runner
{
    public class CalculatorRunner
    {
        private readonly InputParserService _inputParser;
        private readonly ICalculator _calculator;
        private readonly DisplayService _display;

        public CalculatorRunner(InputParserService inputParser, ICalculator calculator, DisplayService display)
        {
            _inputParser = inputParser;
            _calculator = calculator;
            _display = display;
        }

        public void Run()
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                _display.ShowOptions();

                Console.Write("Enter the first number: ");
                string num1Input = Console.ReadLine();

                Console.Write("Enter an operator (+, -, *, /): ");
                string operatorInput = Console.ReadLine();

                Console.Write("Enter the second number: ");
                string num2Input = Console.ReadLine();

                try
                {
                    var (num1, num2, op) = _inputParser.ParseInputs(num1Input, num2Input, operatorInput);
                    double result = _calculator.Calculate(num1, num2, op);
                    _display.ShowResult(result);
                }
                catch (Exception ex)
                {
                    _display.ShowError(ex.Message);
                }

                Console.WriteLine();
                Console.WriteLine("Press 'e' to exit or any other key to continue.");
                var key = Console.ReadKey(true); // 'true' to not display the pressed key

                if (key.KeyChar == 'e' || key.KeyChar == 'E')
                {
                    break;
                }

                Console.Clear();
            }
        }
    }
}