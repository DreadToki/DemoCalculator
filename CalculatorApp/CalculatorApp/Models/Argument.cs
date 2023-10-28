using CalculatorApp.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CalculatorApp.Models
{
    internal class Argument : LinkedList<char>, IBufferItem
    {
        public Argument(params char[] value)
        {
            if (value != null)
            {
                foreach (char c in value)
                {
                    base.AddLast(c);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder buffer = new StringBuilder();
            ConcatNodes(buffer, base.First);
            return buffer.ToString();
        }

        private void ConcatNodes(StringBuilder buffer, LinkedListNode<char> node)
        {
            if (node == null)
            {
                return;
            }
            buffer.Append(node.Value);
            ConcatNodes(buffer, node.Next);
        }

        public decimal ToDecimal()
        {
            var number = ToString();
            if (decimal.TryParse(number, out var value))
            {
                return value;
            }
            throw new ArgumentException($"Unable to convert {number} to decimal.");
        }

        public void AddLastDigit(char value)
        {
            base.AddLast(value);
        }

        public void RemoveLastDigit()
        {
            if (base.Count > 0)
            {
                base.RemoveLast();
            }
        }

        public static implicit operator Argument(char value)
        {
            return new Argument(value);
        }

        public static implicit operator Argument(string value)
        {
            return new Argument(value.ToCharArray());
        }

        public static implicit operator Argument(decimal value)
        {
            Argument arg = value.ToString();
            return arg;
        }

        public static implicit operator char(Argument value)
        {
            if (value.Last == null)
            {
                throw new ArgumentNullException("value");
            }
            return value.Last.Value;
        }

        public static implicit operator string(Argument value)
        {
            return value.ToString();
        }

        public static implicit operator decimal(Argument value)
        {
            return value.ToDecimal();
        }

        public static Argument _0 => '0';
        public static Argument _1 => '1';
        public static Argument _2 => '2';
        public static Argument _3 => '3';
        public static Argument _4 => '4';
        public static Argument _5 => '5';
        public static Argument _6 => '6';
        public static Argument _7 => '7';
        public static Argument _8 => '8';
        public static Argument _9 => '9';
        public static Argument _DecimalSeparator => NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
    }
}
