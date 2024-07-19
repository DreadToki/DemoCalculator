using CalculatorApp.Interface;
using System;

namespace CalculatorApp.Commands
{
    internal class RootCommand : ICommand
    {
        public sbyte Weight => 3;

        public decimal Execute(decimal exponent, decimal baseValue)
        {
            if (baseValue == 0) return 0;

            if (baseValue == 1) return 1;

            decimal x0 = baseValue / exponent;
            decimal x = x0;
            decimal epsilon = 0.001M;

            do
            {
                x0 = x;
                x = ((exponent - 1) * x0 + baseValue / Power(x0, exponent - 1)) / exponent;
            } while (Math.Abs(x - x0) > epsilon);

            return (int)x;
        }

        private decimal Power(decimal x0, decimal v)
        {
            decimal result = 1;

            if (v == 0) return 1;

            if (v == 1) return x0;

            for (int i = 0; i < v; i++)
            {
                result *= v;
            }

            return result;
        }


        public override string ToString()
        {
            return "ⁿ√x";
        }
    }
}
