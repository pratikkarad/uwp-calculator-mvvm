using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uwp_calculator_mvvm.Model
{
    public class Calculator
    {
        private int value1 = 0;
        private int value2 = 0;
        public Calculator(int value1, int value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public int Add()
        {
            return value1 + value2;
        }

        public int Sub()
        {
            return value1 - value2;
        }

        public int Mul()
        {
            return value1 * value2;
        }

        public int Div()
        {
            return value1 / value2;
        }
    }
}
