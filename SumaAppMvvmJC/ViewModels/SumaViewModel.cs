using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumaAppMvvmJC.ViewModels;
using SumaAppMvvmJC.Views;

namespace SumaAppMvvmJC.ViewModels
{
    public class SumaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double _number1;
        public double Number1
        {
            get => _number1;
            set
            {
                if (_number1 != value)
                {
                    _number1 = value;
                    OnPropertyChanged(nameof(Number1));
                }
            }
        }

        private double _number2;
        public double Number2
        {
            get => _number2;
            set
            {
                if (_number2 != value)
                {
                    _number2 = value;
                    OnPropertyChanged(nameof(Number2));
                }
            }
        }

        private double _result;
        public double Result
        {
            get => _result;
            private set
            {
                if (_result != value)
                {
                    _result = value;
                    OnPropertyChanged(nameof(Result));
                }
            }
        }

        public ICommand CalculateCommand { get; }
        public ICommand ClearCommand { get; }

        public SumaViewModel()
        {
            CalculateCommand = new Command(OnCalculate);
            ClearCommand = new Command(OnClear);
        }

        private void OnCalculate()
        {
            Result = Number1 + Number2;
        }

        private void OnClear()
        {
            Number1 = 0;
            Number2 = 0;
            Result = 0;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
