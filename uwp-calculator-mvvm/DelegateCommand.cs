using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace uwp_calculator_mvvm
{
    class DelegateCommand : ICommand
    {
        private SimpleEventHandler handler;

        public event EventHandler CanExecuteChanged;
        public delegate void SimpleEventHandler();
        public DelegateCommand(SimpleEventHandler handler)
        {
            this.handler = handler;
        }

        public bool IsEnabled { get; } = true;

        private void OnCanExecuteChanged()
        {
            this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            Debug.WriteLine("OnCanExecuteChanged");
        }

        public bool CanExecute(object parameter)
        {
            Debug.WriteLine("CanExecute");
            return IsEnabled;
        }

        public void Execute(object parameter)
        {
            this.handler();
            Debug.WriteLine("Execute");
        }
    }
}
