using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using uwpmvvm.Model;
using uwpmvvm.ViewModels;

namespace uwpmvvm.ViewModels
{
    class MainViewModel : MainViewModelBase
    {
        private Calculator calculator_ = null;
        private int result_ = 0;
        private int value1_ = 0;
        private int value2_ = 0;
        private bool isAddChecked_ = false;
        private bool isSubChecked_ = false;
        private bool isMulChecked_ = false;
        private bool isDivChecked_ = false;
        private bool isAnyRadioBtnCheck_ = false;

        public bool IsAnyRadioBtnCheck
        {
            get
            {
                return isAnyRadioBtnCheck_;
            }
            set
            {
                if (value != isAnyRadioBtnCheck_)
                {
                    isAnyRadioBtnCheck_ = value;
                    OnPropertyChanged("IsAnyRadioBtnCheck");
                }
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
                if (value != value1_)
                {
                    value1_ = value;
                    OnPropertyChanged("Value1");
                }
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
                if (value != value2_)
                {
                    value2_ = value;
                    OnPropertyChanged("Value2");
                }
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
                if (value != result_)
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
                if (value != isAddChecked_)
                {
                    isAddChecked_ = value;
                    IsAnyRadioBtnCheck = true;
                    OnPropertyChanged("IsAddChecked");
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
                if (value != isSubChecked_)
                {
                    isSubChecked_ = value;
                    IsAnyRadioBtnCheck = true;
                    OnPropertyChanged("IsSubChecked");
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
                if (value != isMulChecked_)
                {
                    isMulChecked_ = value;
                    IsAnyRadioBtnCheck = true;
                    OnPropertyChanged("IsMulChecked");
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
                if (value != isDivChecked_)
                {
                    isDivChecked_ = value;
                    IsAnyRadioBtnCheck = true;
                    OnPropertyChanged("IsDivChecked");
                }
            }
        }

        public ICommand OkButtonClicked
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
            else if (IsSubChecked)
            {
                Result = calculator_.Sub();
            }
            else if (IsMulChecked)
            {
                Result = calculator_.Mul();
            }
            else if (IsDivChecked)
            {
                Result = calculator_.Div();
            }
        }
    }
}
