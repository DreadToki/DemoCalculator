using CalculatorApp.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace CalculatorApp.Interface
{
    internal interface IBuffer : INotifyPropertyChanging, INotifyPropertyChanged, IEnumerable<IBufferItem>
    {
        bool HasErrors { get; }
        int Count { get; }
        void AddArgument(Argument argument);
        void AddError(Error error);
        void AddOperation(ICommand command);
        void AddResult(Result result);
        void Clear();
        void RemoveError();
        void RemoveLast();
        void RemoveLastArgument();
    }
}
