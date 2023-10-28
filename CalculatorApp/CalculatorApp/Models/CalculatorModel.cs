using CalculatorApp.Interface;
using System.Collections.Generic;

namespace CalculatorApp.Models
{
    internal class CalculatorModel : NotifyPropertyChanges, ICalculatorModel
    {
        private readonly LinkedList<IBufferItem> _buffer;

        public CalculatorModel()
        {
            _buffer = new LinkedList<IBufferItem>();
        }

        public LinkedListNode<IBufferItem> First => _buffer.First;

        public LinkedListNode<IBufferItem> Last => _buffer.Last;

        public void AddArgument(Argument argument)
        {
            OnPropertyChanging();
            if (_buffer.Last?.Value is Argument lastArgument)
            {
                lastArgument.Append(argument);
            }
            else
            {
                _buffer.AddLast(argument);
            }
            OnPropertyChanged();
        }

        public void AddOperation(ICommand command)
        {
            OnPropertyChanging();
            if (_buffer.Last?.Value is ICommand)
            {
                return;
            }
            _buffer.AddLast(command);
            OnPropertyChanged();
        }

        public void AddResult(CalculationResult result)
        {
            OnPropertyChanging();
            _buffer.AddLast(result);
            OnPropertyChanged();
        }

        public void Clear()
        {
            OnPropertyChanging();
            _buffer.Clear();
            HasError = false;
            OnPropertyChanged();
        }

        public void RemoveLast()
        {
            OnPropertyChanging();
            if (_buffer.Last?.Value is Argument argument)
            {
                argument.RemoveLast();
                if (argument.IsEmpty)
                {
                    RemoveLastItem();
                }
            }
            else
            {
                RemoveLastItem();
            }
            OnPropertyChanged();
        }

        private void RemoveLastItem()
        {
            if (_buffer.Count > 0)
            {
                _buffer.RemoveLast();
            }
        }
    }
}
