using CalculatorApp.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CalculatorApp.Models
{
    internal class Argument : IBufferItem
    {
        private readonly LinkedList<char> _value;

        public Argument(params char[] value)
        {
            _value = new LinkedList<char>();

            if (value != null)
            {
                foreach (char c in value)
                {
                    _value.AddLast(c);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder buffer = new StringBuilder();
            ConcatNodes(buffer, _value.First);
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

        public void Append(Argument argument)
        {
            if (argument._value.Count == 0)
            {
                throw new ArgumentException("Argument is empty.");
            }
            if (argument._value.Count == 1)
            {
                _value.AddLast(argument);
            }
            else
            {
                var chars = argument._value.ToArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    _value.AddLast(chars[i]);
                }
            }
        }

        public void RemoveLast()
        {
            if (_value.Count > 0)
            {
                _value.RemoveLast();
            }
        }

        public bool IsEmpty => _value.Count == 0;

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

        public static implicit operator char(Argument argument)
        {
            if (argument._value.Last == null)
            {
                throw new ArgumentNullException("value");
            }
            return argument._value.Last.Value;
        }

        public static implicit operator string(Argument argument)
        {
            return argument.ToString();
        }

        public static implicit operator decimal(Argument argument)
        {
            return argument.ToDecimal();
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
