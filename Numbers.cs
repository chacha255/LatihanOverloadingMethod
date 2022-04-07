using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;

namespace LatihanOverloadingMethod
{
    2 reference
    public class number
    {
        1 reference
        public int FindingMinimum(int number1, int number2)
        {
            if (number1 < number2)
                return number1;
            else
                return number2;
        }

        1 reference
        public int FindingMinimum(int number1, int number2, float number3)
        {
            return (int)Math.Min(number1, Math.Min(number2, number3));
        }

        1 reference
        public int FindingMaximum(int number1, number2)
        {
            int max = Math.Max(number1, number2);
            return max;
        }

        1 reference
        public int FindingMaximun(int number1, int number2, float number3)
        {
            int max = (int)Math.Max(number1, Math.Max(number2, number3));
            return max;
        }
    }
    
}