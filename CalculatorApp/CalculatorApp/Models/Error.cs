using CalculatorApp.Interface;

namespace CalculatorApp.Models
{
    internal class Error : IBufferItem
    {
        private readonly string _message;

        public Error(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }

        public static implicit operator Error(string message)
        {
            return new Error(message);
        }

        public static implicit operator string(Error error)
        {
            return error.ToString();
        }
    }
}
