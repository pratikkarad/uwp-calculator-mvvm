using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uwp_calculator_mvvm.ViewModel
{
    public abstract class MainViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string PropertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            Debug.WriteLine("OnPropertyChanged");
        }
    }
}
