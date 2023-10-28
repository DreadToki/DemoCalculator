using CalculatorApp.Models;
using System.ComponentModel;

namespace CalculatorApp.Views
{
    internal class MainFormState : NotifyPropertyChanges
    {
        private bool _buttonEnabled = true;
        private string _results;
        private string _history;
        private string _error;

        public MainFormState()
        {
        }

        public MainFormState(bool buttonEnabled)
        {
            _buttonEnabled = buttonEnabled;
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

        [Bindable(true)]
        public string Error
        {
            get => _error;
            set
            {
                if (_error != value)
                {
                    OnPropertyChanging();
                    _error = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
