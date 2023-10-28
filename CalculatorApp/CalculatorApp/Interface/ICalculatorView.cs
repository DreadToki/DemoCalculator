using CalculatorApp.Models;
using System;

namespace CalculatorApp.Interface
{
    internal interface ICalculatorView
    {
        event EventHandler<CommandInvokedEventArgs> CommandInvoked;
        event EventHandler EqualsCommandInvoked;
        event EventHandler ClearEverythingCommandInvoked;
        event EventHandler ClearLastCommandInvoked;

        void UpdateResults(string results);
        void UpdateHistory(string history);
        void UpdateError(string errorMessage);
    }
}
