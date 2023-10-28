using CalculatorApp.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace CalculatorApp.Interface
{
    internal interface ICalculatorModel : INotifyPropertyChanging, INotifyPropertyChanged
    {
        LinkedListNode<IBufferItem> First { get; }
        LinkedListNode<IBufferItem> Last { get; }
        void AddArgument(Argument argument);
        void AddOperation(ICommand command);
        void AddResult(CalculationResult result);
        void RemoveLast();
        void Clear();
    }
}
