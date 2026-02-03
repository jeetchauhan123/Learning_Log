using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class PrimeNum
    {
        internal void IsPrime(double n)
        {
            if (n <= 1)
            {
                Console.WriteLine($"{n} is not prime number");
            }
            else
            {
                for(int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine($"{n} is not prime number");
                        return;
                    }
                }
                Console.WriteLine($"{n} is prime number");
            }
        }
    }
}
