

namespace CalculatorCLI.Services
{
    public class InputParserService
    {
        public (double, double, string) ParseInputs(string num1Input, string num2Input, string operatorInput)
        {
            if (double.TryParse(num1Input, out double num1) && double.TryParse(num2Input, out double num2))
            {
                return (num1, num2, operatorInput);
            }
            throw new FormatException("Invalid input for numbers.");
        }
    }
}
