using CalculatorApp.Interface;
using CalculatorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorApp.Presenter
{
    internal class CalculatorPresenter
    {
        private const string NewLine = "\r\n";
        private const string Whitespace = " ";

        private readonly ICalculatorView _view;
        private readonly ICalculatorModel _model;

        public CalculatorPresenter(ICalculatorView view, ICalculatorModel model)
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
            if (_model.HasError)
            {
                _model.RemoveLastArgument();
                _model.HasError = false;
            }
            else
            {
                _model.RemoveLast();
            }
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
            if (e.BufferItem is Argument argument)
            {
                _model.AddArgument(argument);
            }
            else if (e.BufferItem is ICommand command)
            {
                if (_model.Last?.Value is Argument)
                {
                    _model.AddOperation(command);
                }
            }
        }

        private void _model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            UpdateView();
        }

        private void Calculate()
        {
            try
            {
                if (_model.Last?.Value is Argument arg2 &&
                    _model.Last?.Previous?.Value is ICommand command &&
                    _model.Last?.Previous?.Previous?.Value is Argument arg1)
                {
                    CalculationResult result = command.Execute(arg1, arg2);
                    _model.AddResult(result);
                    _model.AddArgument(result);
                }
            }
            catch (Exception ex)
            {
                _model.HasError = true;
                _view.UpdateError(ex.Message);
            }
        }

        private void UpdateView()
        {
            List<string> buffer = new List<string>();
            ForwardConcatNodes(buffer, _model.First);
            if (buffer.Count > 0)
            {
                var history = string.Join(NewLine, buffer.Take(buffer.Count - 1));
                var results = buffer.Last();
                _view.UpdateHistory(history);
                _view.UpdateResults(results);
            }
            else
            {
                _view.UpdateHistory(string.Empty);
                _view.UpdateResults(string.Empty);
            }
        }

        private void ForwardConcatNodes(List<string> buffer, LinkedListNode<IBufferItem> node)
        {
            if (node == null)
            {
                return;
            }

            var space = node.Next != null
                ? Whitespace
                : string.Empty;

            if (buffer.Count > 0 && node.Value is CalculationResult)
            {
                var last = buffer.Last() + $"{node.Value.ToString()}";
                buffer[buffer.Count - 1] = last;
                buffer.Add(string.Empty);
            }
            else if (buffer.Count == 0)
            {
                buffer.Add($"{node.Value.ToString()}{space}");
            }
            else
            {
                var last = buffer.Last() + $"{node.Value.ToString()}{space}";
                buffer[buffer.Count - 1] = last;
            }
            ForwardConcatNodes(buffer, node.Next);
        }
    }
}
