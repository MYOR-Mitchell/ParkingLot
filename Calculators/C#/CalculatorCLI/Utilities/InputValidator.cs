

namespace CalculatorCLI.Utilities
{
    public class InputValidator
    {
        public bool IsValidOperator(string input)
        {
            return input == "+" || input == "-" || input == "*" || input == "/";
        }

        public bool IsExitCommand(string input)
        {
            return input.Equals("exit", StringComparison.OrdinalIgnoreCase);
        }
    }
}
