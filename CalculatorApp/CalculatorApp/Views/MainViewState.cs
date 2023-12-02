using CalculatorApp.Utilities;
using System.ComponentModel;

namespace CalculatorApp.Views
{
    internal class MainViewState : NotifyPropertyChanges
    {
        private bool _buttonEnabled = true;
        private bool _hasErrors;
        private string _results;
        private string _history;

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

        public bool HasErrors
        {
            get => _hasErrors;
            set
            {
                _hasErrors = value;
                UpdateState(value);
            }
        }

        private void UpdateState(bool hasErrors)
        {
            ButtonEnabled = !hasErrors;
        }
    }
}
