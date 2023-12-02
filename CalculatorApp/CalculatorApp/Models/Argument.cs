using CalculatorApp.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CalculatorApp.Models
{
    internal class Argument : IBufferItem
    {
        private readonly List<char> _buffer;

        public Argument(params char[] digits)
        {
            _buffer = new List<char>();

            if (digits != null)
            {
                foreach (char d in digits)
                {
                    _buffer.Add(d);
                }
            }
        }

        public override string ToString()
        {
            return string.Join(string.Empty, _buffer);
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
            foreach (var d in argument._buffer)
            {
                _buffer.Add(d);
            }
        }

        public void RemoveLast()
        {
            if (_buffer.Count > 0)
            {
                _buffer.RemoveAt(_buffer.Count - 1);
            }
        }

        public bool IsEmpty => _buffer.Count == 0;

        public static implicit operator Argument(char value)
        {
            return new Argument(value);
        }

        public static implicit operator Argument(char[] value)
        {
            return new Argument(value);
        }

        public static implicit operator Argument(string value)
        {
            return new Argument(value.ToCharArray());
        }

        public static implicit operator Argument(decimal value)
        {
            return new Argument(value.ToString().ToCharArray());
        }

        public static implicit operator char(Argument argument)
        {
            if (argument._buffer.Count == 1)
            {
                return argument._buffer.Last();
            }
            throw new ArgumentException("Only single-digit arguments can be converted to char.");
        }

        public static implicit operator char[](Argument argument)
        {
            return argument._buffer.ToArray();
        }

        public static implicit operator string(Argument argument)
        {
            return argument.ToString();
        }

        public static implicit operator decimal(Argument argument)
        {
            return argument.ToDecimal();
        }

        public static Argument A0 => '0';
        public static Argument A1 => '1';
        public static Argument A2 => '2';
        public static Argument A3 => '3';
        public static Argument A4 => '4';
        public static Argument A5 => '5';
        public static Argument A6 => '6';
        public static Argument A7 => '7';
        public static Argument A8 => '8';
        public static Argument A9 => '9';
        public static Argument DecimalSeparator => NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
    }
}
