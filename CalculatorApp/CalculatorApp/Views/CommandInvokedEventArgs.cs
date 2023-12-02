using CalculatorApp.Interface;
using System;

namespace CalculatorApp.Views
{
    internal class CommandInvokedEventArgs : EventArgs
    {
        public IBufferItem BufferItem { get; private set; }

        public CommandInvokedEventArgs(IBufferItem item)
        {
            BufferItem = item;
        }
    }
}
