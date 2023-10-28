using CalculatorApp.Interface;

namespace CalculatorApp.Models
{
    internal class CalculationResult : IBufferItem
    {
        private readonly string _value;

        public CalculationResult(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }
    }
}
