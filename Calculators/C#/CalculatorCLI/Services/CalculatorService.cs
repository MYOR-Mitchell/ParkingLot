using CalculatorCLI.Interfaces;

namespace CalculatorCLI.Services
{
    public class CalculatorService : ICalculator
    {
        public double Calculate(double num1, double num2, string op)
        {
            if (!IsValidOperator(op))
            {
                throw new InvalidOperationException("Invalid operator.");
            }

            return op switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" => num2 != 0 ? num1 / num2 : throw new DivideByZeroException(),
                _ => throw new InvalidOperationException("Invalid operator")
            };
        }

        private bool IsValidOperator(string input)
        {
            return input == "+" || input == "-" || input == "*" || input == "/";
        }
    }
}
