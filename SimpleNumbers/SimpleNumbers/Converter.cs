using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNumbers
{
    static class NumberConverter
    {
        static public string Convert(int number)
        {
            string boolNumber = "";
            int remainder;
            while (Math.Abs(number) != 0)
            {
                remainder = number % 2;
                boolNumber += remainder.ToString();
                number /= 2;
            }
            char[] charArray = boolNumber.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
