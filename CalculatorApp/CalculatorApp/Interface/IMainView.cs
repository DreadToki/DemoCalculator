using CalculatorApp.Views;
using System;

namespace CalculatorApp.Interface
{
    internal interface IMainView
    {
        event EventHandler<CommandInvokedEventArgs> CommandInvoked;
        event EventHandler EqualsCommandInvoked;
        event EventHandler ClearEverythingCommandInvoked;
        event EventHandler ClearLastCommandInvoked;

        MainViewState ViewState { get; }
    }
}
