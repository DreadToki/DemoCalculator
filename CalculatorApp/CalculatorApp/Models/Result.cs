using CalculatorApp.Interface;

namespace CalculatorApp.Models
{
    internal class Result : IBufferItem
    {
        private readonly decimal _value;

        public Result(decimal value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return $"= {_value}";
        }

        public static implicit operator decimal(Result result)
        {
            return result._value;
        }

        public static implicit operator Result(decimal number)
        {
            return new Result(number);
        }

        public static implicit operator Result(Argument argument)
        {
            return new Result(argument);
        }

        public static implicit operator Argument(Result result)
        {
            return new Argument(result._value.ToString().ToCharArray());
        }
    }
}
