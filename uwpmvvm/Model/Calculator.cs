using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uwpmvvm.Model
{
  
    public class Calculator
    {
        private int value1;
        private int value2;

        public Calculator(int val1, int val2)
        {
            this.value1 = val1;
            this.value2 = val2;
        }

        internal int Add()
        {
            return value1 + value2;
        }

        internal int Sub()
        {
            return value1 - value2;
        }

        internal int Mul()
        {
            return value1 * value2;
        }

        internal int Div()
        {
            return value1 / value2;
        }
    }
}
