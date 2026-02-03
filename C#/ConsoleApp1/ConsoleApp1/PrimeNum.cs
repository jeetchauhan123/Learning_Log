using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class PrimeNum
    {
        internal bool IsPrime(int n)
        {
            if (n <= 1) return false;
            int limit = (int)Math.Sqrt(n);
            for (int i = 2; i <= limit; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        internal void Print(int n)
        {
            Console.WriteLine(IsPrime(n)
                ? $"{n} is prime number"
                : $"{n} is not prime number");
        }
    }
}
