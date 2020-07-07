using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using uwp_calculator_mvvm.Model;

namespace uwp_calculator_mvvm.ViewModel
{
    public class MainViewModel : MainViewModelBase
    {
        private Calculator calculator_ = null;
        private int result_ = 0;
        private int value1_ = 0;
        private int value2_ = 0;
        private bool isAddChecked_ = false;
        private bool isSubChecked_ = false;
        private bool isMulChecked_ = false;
        private bool isDivChecked_ = false;
        private bool isAnyRadioBtnChecked_ = false;

        public bool IsAnyRadioBtnChecked
        {
            get
            {
                return isAnyRadioBtnChecked_;
            }
            set
            {
                isAnyRadioBtnChecked_ = value;
                OnPropertyChanged("IsAnyRadioBtnChecked");
            }
        }
        public int Value1
        {
            get
            {
                return value1_;
            }
            set
            {
                value1_ = value;
                OnPropertyChanged("Value1");
            }
        }
        public int Value2
        {
            get
            {
                return value2_;
            }
            set
            {
                value2_ = value;
                OnPropertyChanged("Value2");
            }
        }
        public int Result
        {
            get
            {
                return result_;
            }
            set
            {
                if(result_ != value)
                {
                    result_ = value;
                    OnPropertyChanged("Result");
                }
            }
        }
        public bool IsAddChecked
        {
            get
            {
                return isAddChecked_;
            }
            set
            {
                if (isAddChecked_ != value)
                {
                    isAddChecked_ = value;
                    OnPropertyChanged("IsAddChecked");
                    IsAnyRadioBtnChecked = true;
                }
            }
        }
        public bool IsSubChecked
        {
            get
            {
                return isSubChecked_;
            }
            set
            {
                if (isSubChecked_ != value)
                {
                    isSubChecked_ = value;
                    OnPropertyChanged("IsSubChecked");
                    IsAnyRadioBtnChecked = true;
                }
            }
        }
        public bool IsMulChecked
        {
            get
            {
                return isMulChecked_;
            }
            set
            {
                if (isMulChecked_ != value)
                {
                    isMulChecked_ = value;
                    OnPropertyChanged("IsMulChecked");
                    IsAnyRadioBtnChecked = true;
                }
            }
        }
        public bool IsDivChecked
        {
            get
            {
                return isDivChecked_;
            }
            set
            {
                if (isDivChecked_ != value)
                {
                    isDivChecked_ = value;
                    OnPropertyChanged("IsDivChecked");
                    IsAnyRadioBtnChecked = true;
                }
            }
        }

        public ICommand OkBtnClicked
        {
            get
            {
                return new DelegateCommand(FindResult);
            }
        }

        public void FindResult()
        {
            calculator_ = new Calculator(Value1, Value2);
            if (IsAddChecked)
            {
                Result = calculator_.Add();
            }
            if (IsSubChecked)
            {
                Result = calculator_.Sub();
            }
            if (IsMulChecked)
            {
                Result = calculator_.Mul();
            }
            if (IsDivChecked)
            {
                Result = calculator_.Div();
            }
        }
    }
}
