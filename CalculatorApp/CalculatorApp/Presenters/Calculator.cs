using CalculatorApp.Interface;
using CalculatorApp.Models;
using CalculatorApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorApp.Presenter
{
    internal class Calculator
    {
        private readonly IMainView _view;
        private readonly IBuffer _model;

        public Calculator(IMainView view, IBuffer model)
        {
            _view = view;
            _model = model;

            _view.CommandInvoked += _view_CommandInvoked;
            _view.EqualsCommandInvoked += _view_EqualsCommandInvoked;
            _view.ClearEverythingCommandInvoked += _view_ClearEverythingCommandInvoked;
            _view.ClearLastCommandInvoked += _view_ClearLastCommandInvoked;

            _model.PropertyChanged += _model_PropertyChanged;
        }

        ~Calculator()
        {
            _view.CommandInvoked -= _view_CommandInvoked;
            _view.EqualsCommandInvoked -= _view_EqualsCommandInvoked;
            _view.ClearEverythingCommandInvoked -= _view_ClearEverythingCommandInvoked;
            _view.ClearLastCommandInvoked -= _view_ClearLastCommandInvoked;

            _model.PropertyChanged -= _model_PropertyChanged;
        }

        private void _view_ClearLastCommandInvoked(object sender, EventArgs e)
        {
            if (_model.HasErrors)
            {
                _model.RemoveError();
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
                _model.AddOperation(command);
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
                var buffer = _model.ToList();
                var lastResultIndex = buffer.IndexOf(buffer.Last(e => e is Result));
                var calculationSeq = buffer.Skip(lastResultIndex + 1).ToList();
                var finalResult = RecurseCalculate(calculationSeq);
                _model.AddResult(finalResult);
                _model.AddArgument(finalResult);

                //if (_model.ElementAt(_model.Count - 1) is Argument arg2 &&
                //    _model.ElementAt(_model.Count - 2) is ICommand command &&
                //    _model.ElementAt(_model.Count - 3) is Argument arg1)
                //{
                //    Result result = command.Execute(arg1, arg2);
                //    _model.AddResult(result);
                //    _model.AddArgument(result);
                //}
            }
            catch (Exception ex)
            {
                _model.AddError(ex.Message);
            }
        }

        private Result RecurseCalculate(List<IBufferItem> calculationSeq)
        {
            var weightedCommands = calculationSeq.Where(i => i is ICommand).Cast<ICommand>().GroupBy(i => i.Weight).OrderByDescending(g => g.Key);

            var weightedCommand = weightedCommands.First();
            var command = weightedCommand.First();

            var commandIndex = calculationSeq.IndexOf(command);
            var arg1Index = commandIndex - 1;
            var arg2Index = commandIndex + 1;

            Argument result = command.Execute(calculationSeq[arg1Index] as Argument, calculationSeq[arg2Index] as Argument);

            calculationSeq.Insert(arg2Index + 1, result);
            calculationSeq.RemoveRange(arg1Index, 3);
            if (calculationSeq.Count == 1 && calculationSeq[0] is Argument finalResult)
            {
                return finalResult;
            }
            return RecurseCalculate(calculationSeq);
        }

        private void UpdateView()
        {
            List<string> buffer = new List<string>();

            foreach (var node in _model)
            {
                if (buffer.Count == 0)
                {
                    buffer.Add(node.ToString());
                }
                else if (buffer.Count > 0 && node is Result)
                {
                    var last = buffer.Last() + $" {node.ToString()}";
                    buffer[buffer.Count - 1] = last;
                    buffer.Add(string.Empty);
                }
                else if (node is Error)
                {
                    buffer[buffer.Count - 1] = node.ToString();
                    break;
                }
                else
                {
                    var last = buffer.Last();
                    last = last.Length == 0 ? node.ToString() : last + $" {node.ToString()}";
                    buffer[buffer.Count - 1] = last;
                }
            }

            if (buffer.Count > 0)
            {
                _view.ViewState.History = string.Join(Environment.NewLine, buffer.Take(buffer.Count - 1));
                _view.ViewState.Results = buffer.Last();
            }
            else
            {
                _view.ViewState.History = string.Empty;
                _view.ViewState.Results = string.Empty;
            }
            _view.ViewState.HasErrors = _model.HasErrors;
        }
    }
}
