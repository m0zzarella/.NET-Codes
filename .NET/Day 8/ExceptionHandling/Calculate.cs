using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Calculate
    {
        public int DivideNumbers(int num1, int num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Divide by zero not allowed");
            if (num1 == 0)
                throw new Exception("Zero results are not processed");
            if (num1 < 0 || num2 < 0)
                throw new Exception("Negative numbers are not processed");
            return num1 / num2;
        }
    }
}
