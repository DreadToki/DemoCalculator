using CalculatorApp.Interface;

namespace CalculatorApp.Models
{
    internal class CalculationResult : IBufferItem
    {
        private readonly decimal _value;

        public CalculationResult(decimal value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return $"= {_value}";
        }

        public static implicit operator decimal(CalculationResult result)
        {
            return result._value;
        }

        public static implicit operator CalculationResult(decimal number)
        {
            return new CalculationResult(number);
        }

        public static implicit operator CalculationResult(Argument argument)
        {
            return new CalculationResult(argument);
        }

        public static implicit operator Argument(CalculationResult result)
        {
            Argument argument = (decimal)result;
            return argument;
        }
    }
}
