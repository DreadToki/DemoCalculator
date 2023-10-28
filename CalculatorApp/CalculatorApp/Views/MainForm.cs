using CalculatorApp.Interface;
using CalculatorApp.Models;
using System;
using System.Windows.Forms;

using static CalculatorApp.Commands.Commands;
using static CalculatorApp.Models.Argument;

namespace CalculatorApp.Views
{
    internal partial class MainForm : Form, ICalculatorView
    {
        private readonly MainFormState _state;

        public MainForm()
        {
            InitializeComponent();

            _state = new MainFormState();

            mainFormBindingSource.DataSource = _state;
        }

        #region MainForm component events

        private void btnDelimiter_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(_DecimalSeparator);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(_0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(_1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(_2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(_3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(_4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(_5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(_6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(_7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(_8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(_9);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(AddCommand);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(SubtractCommand);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(MultiplyCommand);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(DivideCommand);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            OnEqualsCommandInvoked();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            OnClearEverythingCommandInvoked();
        }

        private void btnClearLast_Click(object sender, EventArgs e)
        {
            OnClearLastCommandInvoked();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox txtBox)
            {
                txtBox.SelectionStart = txtBox.TextLength;
                txtBox.ScrollToCaret();
            }
        }

        #endregion

        #region ICalculatorView implementation

        public event EventHandler<CommandInvokedEventArgs> CommandInvoked;

        protected virtual void OnCommandInvoked(IBufferItem item)
        {
            CommandInvoked?.Invoke(this, new CommandInvokedEventArgs(item));
        }

        public event EventHandler EqualsCommandInvoked;

        protected virtual void OnEqualsCommandInvoked()
        {
            EqualsCommandInvoked?.Invoke(this, new EventArgs());
        }

        public event EventHandler ClearEverythingCommandInvoked;

        protected virtual void OnClearEverythingCommandInvoked()
        {
            ClearEverythingCommandInvoked?.Invoke(this, new EventArgs());
        }

        public event EventHandler ClearLastCommandInvoked;

        protected virtual void OnClearLastCommandInvoked()
        {
            ClearLastCommandInvoked?.Invoke(this, new EventArgs());
        }

        public void UpdateResults(string results)
        {
            _state.Results = results;
        }

        public void UpdateHistory(string history)
        {
            _state.History = history;
        }

        public void UpdateError(string errorMessage)
        {
            _state.Error = errorMessage;
        }

        #endregion
    }
}
