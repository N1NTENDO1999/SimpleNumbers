using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using SimpleNumbers;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
    }
    class PrimeNumbers
    {
        public static List<int> GetPrimeNumbers(int n)
        {
            List<int> list = new List<int>();
            int max = n + 1;
            bool[] is_prime = MakeSieve(max);
            for (int i = 2; i < max; i++)
                if (is_prime[i])
                    list.Add(i);
            return list;
        }
        private static bool[] MakeSieve(int max)
        {
            bool[] is_prime = new bool[max + 1];
            for (int i = 2; i <= max; i++) is_prime[i] = true;

            for (int i = 2; i <= max; i++)
            {
                if (is_prime[i])
                {
                    for (int j = i * 2; j <= max; j += i)
                        is_prime[j] = false;
                }
            }
            return is_prime;
        }
    }
}