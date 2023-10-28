using CalculatorApp.Interface;
using System.Collections.Generic;

namespace CalculatorApp.Models
{
    internal class CalculatorModel : NotifyPropertyChanges, ICalculatorModel
    {
        private readonly LinkedList<IBufferItem> buffer;

        public CalculatorModel()
        {
            buffer = new LinkedList<IBufferItem>();
        }

        public void AddArgument(Argument argument)
        {
            OnPropertyChanging();
            if (buffer.Last?.Value is Argument lastArgument)
            {
                lastArgument.Append(argument);
            }
            else
            {
                buffer.AddLast(argument);
            }
            OnPropertyChanged();
        }

        public void AddOperation(ICommand command)
        {
            OnPropertyChanging();
            if (buffer.Last?.Value is ICommand)
            {
                return;
            }
            buffer.AddLast(command);
            OnPropertyChanged();
        }

        public void AddResult(CalculationResult result)
        {
            OnPropertyChanging();
            buffer.AddLast(result);
            OnPropertyChanged();
        }

        public void Clear()
        {
            OnPropertyChanging();
            buffer.Clear();
            OnPropertyChanged();
        }

        public void RemoveLast()
        {
            OnPropertyChanging();
            if (buffer.Last?.Value is Argument argument)
            {
                argument.RemoveLast();
                if (argument.Count == 0)
                {
                    buffer.RemoveLast();
                }
            }
            else
            {
                buffer.RemoveLast();
            }
            OnPropertyChanged();
        }
    }
}