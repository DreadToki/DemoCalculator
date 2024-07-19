using CalculatorApp.Interface;

namespace CalculatorApp.Commands
{
    internal class PowerCommand : ICommand
    {
        public sbyte Weight => 3;

        public decimal Execute(decimal baseValue, decimal exponent)
        {
            decimal result = 1;

            if (exponent == 0) return 1;

            if (exponent == 1) return baseValue;

            for (int i = 0; i < exponent; i++)
            {
                result *= baseValue;
            }

            return result;
        }

        public override string ToString()
        {
            return "xⁿ";
        }
    }
}
