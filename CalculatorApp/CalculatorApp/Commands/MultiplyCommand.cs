using CalculatorApp.Interface;

namespace CalculatorApp.Commands
{
    internal class MultiplyCommand : ICommand
    {
        public sbyte Weight => 2;

        public decimal Execute(decimal arg1, decimal arg2)
        {
            return arg1 * arg2;
        }

        public override string ToString()
        {
            return "×";
        }
    }
}
