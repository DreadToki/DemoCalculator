using CalculatorApp.Interface;
using CalculatorApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp.Presenter
{
    internal class CalculatorPresenter
    {
        private readonly ICalculatorModel _view;
        private readonly CalculatorModel _model;

        public CalculatorPresenter(ICalculatorModel view, CalculatorModel model)
        {
            _view = view;
            _model = model;

            _view.CommandInvoked += _view_CommandInvoked;
            _view.EqualsCommandInvoked += _view_EqualsCommandInvoked;
            _view.ClearEverythingCommandInvoked += _view_ClearEverythingCommandInvoked;
            _view.ClearLastCommandInvoked += _view_ClearLastCommandInvoked;

            _model.PropertyChanged += _model_PropertyChanged;
        }

        ~CalculatorPresenter()
        {
            _view.CommandInvoked -= _view_CommandInvoked;
            _view.EqualsCommandInvoked -= _view_EqualsCommandInvoked;
            _view.ClearEverythingCommandInvoked -= _view_ClearEverythingCommandInvoked;
            _view.ClearLastCommandInvoked -= _view_ClearLastCommandInvoked;

            _model.PropertyChanged -= _model_PropertyChanged;
        }

        private void _view_ClearLastCommandInvoked(object sender, EventArgs e)
        {
            if (_model.Last?.Value is Argument)
            {
                _model.RemoveFromArgument();
                return;
            }
            _model.RemoveLast();
        }

        private void _view_ClearEverythingCommandInvoked(object sender, EventArgs e)
        {
            _model.Clear();
        }

        private void _view_EqualsCommandInvoked(object sender, EventArgs e)
        {
            Calculate();
        }

        private void _view_CommandInvoked(object sender, CommandInvokedEventArgs e)
        {
            if (e.Item is ICommand command && _model.Last?.Value is Argument)
            {
                Calculate();
                _model.AddLast(command);
                return;
            }
            if (e.Item is Argument arg)
            {
                if (_model.Last?.Value == null || _model.Last?.Value is ICommand)
                {
                    _model.AddLast(arg);
                    return;
                }
                if (_model.Last?.Value is Argument)
                {
                    _model.AddToArgument(arg);
                    return;
                }
                if (_model.Last?.Value is CalculationResult)
                {
                    _model.AddLast(arg);
                }
            }
        }

        private void _model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            StringBuilder buffer = new StringBuilder();
            ConcatNodes(buffer, _model.First);
            _view.Update(buffer.ToString());
        }

        private void ConcatNodes(StringBuilder buffer, LinkedListNode<IBufferItem> node)
        {
            if (node == null)
            {
                return;
            }

            var nextExists = node.Next != null;

            var newline = nextExists
                ? "\r\n"
                : string.Empty;

            var space = nextExists
                ? " "
                : string.Empty;

            if (node.Value is CalculationResult)
            {
                buffer.Append($"{node.Value.ToString()}{newline}");
            }
            else
            {
                buffer.Append($"{node.Value.ToString()}{space}");
            }
            ConcatNodes(buffer, node.Next);
        }

        private void Calculate()
        {
            try
            {
                if (_model.Last?.Value is Argument arg2 &&
                    _model.Last?.Previous?.Value is ICommand command &&
                    _model.Last?.Previous?.Previous?.Value is Argument arg1)
                {
                    var result = command.Execute(arg1, arg2);
                    var calculationResult = new CalculationResult($"= {result}");
                    _model.AddLast(calculationResult);
                    Argument arg = result;
                    _model.AddLast(arg);
                }
            }
            catch (Exception ex)
            {
                _view.DisplayError(ex.Message);
            }
        }
    }
}
