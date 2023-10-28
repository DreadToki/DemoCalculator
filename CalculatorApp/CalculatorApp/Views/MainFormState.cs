using CalculatorApp.Models;
using System.ComponentModel;

namespace CalculatorApp.Views
{
    internal class MainFormState : NotifyPropertyChanges
    {
        private bool _buttonEnabled = true;
        private string _results;
        private string _history;

        public MainFormState()
        {
        }

        [Bindable(true)]
        public bool ButtonEnabled
        {
            get => _buttonEnabled;
            set
            {
                if (_buttonEnabled != value)
                {
                    OnPropertyChanging();
                    _buttonEnabled = value;
                    OnPropertyChanged();
                }
            }
        }

        [Bindable(true)]
        public string Results
        {
            get => _results;
            set
            {
                if (_results != value)
                {
                    OnPropertyChanging();
                    _results = value;
                    OnPropertyChanged();
                }
            }
        }

        [Bindable(true)]
        public string History
        {
            get => _history;
            set
            {
                if (_history != value)
                {
                    OnPropertyChanging();
                    _history = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
