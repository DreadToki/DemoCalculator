using CalculatorApp.Interface;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

using static CalculatorApp.Commands.Commands;
using static CalculatorApp.Models.Argument;

namespace CalculatorApp.Views
{
    internal partial class MainForm : Form, IMainView
    {
        private readonly PrivateFontCollection _privateFontCollection;
        private readonly MainViewState _state;

        public MainForm()
        {
            InitializeComponent();

            _privateFontCollection = new PrivateFontCollection();
            _state = new MainViewState();

            mainFormStateBindingSource.DataSource = _state;
        }

        #region MainForm component events

        private void MainForm_Load(object sender, EventArgs e)
        {
            KeyPreview = true;

            LoadPrivateFonts();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //TODO: KeyCode defines only one key press, not the combination
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btnCE.Select();
                    btnCE.PerformClick();
                    break;
                case Keys.D0:
                case Keys.NumPad0:
                    btn0.Select();
                    btn0.PerformClick();
                    break;
                case Keys.D1:
                    btn1.Select();
                    btn1.PerformClick();
                    break;
                default:
                    break;
            }
            e.Handled = true;
        }

        private void btnDelimiter_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(DecimalSeparator);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(A0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(A1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(A2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(A3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(A4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(A5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(A6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(A7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(A8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(A9);
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

        private void btnPower_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(PowerCommand);
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            OnCommandInvoked(RootCommand);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            OnClearEverythingCommandInvoked();
        }

        private void btnClearLast_Click(object sender, EventArgs e)
        {
            OnClearLastCommandInvoked();
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            //TODO: Implement MemoryUp case
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            //TODO: Implement group case
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox txtBox)
            {
                txtBox.SelectionStart = txtBox.TextLength;
                txtBox.ScrollToCaret();
            }
        }

        private void msiFile_Exit_Click(object sender, EventArgs e)
        {
            Close();
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

        public MainViewState ViewState => _state;

        #endregion

        private void LoadPrivateFonts()
        {
            _privateFontCollection.AddFontFile(Path.Combine(Application.StartupPath, "Resources", @"RobotoMono-VariableFont_wght.ttf"));

            Font = new Font(_privateFontCollection.Families[0], 12F, FontStyle.Regular);
            txtHistory.Font = new Font(_privateFontCollection.Families[0], 10F, FontStyle.Regular);
        }
    }
}
