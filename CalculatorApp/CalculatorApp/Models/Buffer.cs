using CalculatorApp.Interface;
using CalculatorApp.Utilities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorApp.Models
{
    internal class Buffer : NotifyPropertyChanges, IBuffer
    {
        private readonly List<IBufferItem> _buffer;

        public Buffer()
        {
            _buffer = new List<IBufferItem>();
        }

        public bool HasErrors => _buffer.Any(i => i is Error);

        public int Count => _buffer.Count;

        public void AddArgument(Argument argument)
        {
            OnPropertyChanging();
            if (_buffer.Count > 0 && _buffer.Last() is Argument arg)
            {
                arg.Append(argument);
            }
            else
            {
                _buffer.Add(argument);
            }
            OnPropertyChanged();
        }

        public void AddError(Error error)
        {
            OnPropertyChanging();
            _buffer.Add(error);
            OnPropertyChanged();
        }

        public void AddOperation(ICommand command)
        {
            OnPropertyChanging();
            if (_buffer.Count > 0 && _buffer.Last() is Argument)
            {
                _buffer.Add(command);
            }
            OnPropertyChanged();
        }

        public void AddResult(Result result)
        {
            OnPropertyChanging();
            _buffer.Add(result);
            OnPropertyChanged();
        }

        public void Clear()
        {
            OnPropertyChanging();
            if (_buffer.Count > 0)
            {
                _buffer.Clear();
            }
            OnPropertyChanged();
        }

        public void RemoveError()
        {
            OnPropertyChanging();
            if (_buffer.Count > 0 && _buffer.Last() is Error)
            {
                _buffer.RemoveAt(_buffer.Count - 1);
                RemoveLastArgument();
            }
            OnPropertyChanged();
        }

        public void RemoveLast()
        {
            OnPropertyChanging();
            if (_buffer.Count > 0 && _buffer.Last() is Argument arg)
            {
                arg.RemoveLast();
                if (arg.IsEmpty)
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

        public void RemoveLastArgument()
        {
            OnPropertyChanging();
            if (_buffer.Count > 0 && _buffer.Last() is Argument)
            {
                _buffer.RemoveAt(_buffer.Count - 1);
            }
            OnPropertyChanged();
        }

        IEnumerator<IBufferItem> IEnumerable<IBufferItem>.GetEnumerator()
        {
            foreach (var item in _buffer)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in _buffer)
            {
                yield return item;
            }
        }

        private void RemoveLastItem()
        {
            if (_buffer.Count > 0)
            {
                _buffer.RemoveAt(_buffer.Count - 1);
            }
        }
    }
}
