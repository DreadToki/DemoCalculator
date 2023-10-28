using CalculatorApp.Interface;
using System;

namespace CalculatorApp.Commands
{
    internal class DivideCommand : ICommand
    {
        public decimal Execute(decimal arg1, decimal arg2)
        {
            if (arg2 == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return arg1 / arg2;
        }

        public override string ToString()
        {
            return "÷";
        }
    }
}
