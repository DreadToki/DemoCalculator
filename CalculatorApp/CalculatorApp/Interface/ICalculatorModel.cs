using CalculatorApp.Models;
using System.ComponentModel;

namespace CalculatorApp.Interface
{
    internal interface ICalculatorModel : INotifyPropertyChanging, INotifyPropertyChanged
    {
        void AddArgument(Argument argument);
        void AddOperation(ICommand command);
        void AddResult(CalculationResult result);
        void RemoveLast();
        void Clear();
    }
}
