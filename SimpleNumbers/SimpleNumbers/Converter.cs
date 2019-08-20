﻿using System;
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
            while (Math.Abs(number) != 1)
            {
                if (Equals(number % 2, 0))
                {
                    remainder = 0;
                }
                else
                {
                    remainder = 1;
                }
                boolNumber += remainder.ToString();
                number /= 2;
            }
            return boolNumber;
        }
    }
}
