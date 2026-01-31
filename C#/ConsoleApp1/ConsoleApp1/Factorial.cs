using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Factorial
    {
        internal void Fact(int n)
        {
            int t= 1;
            for(int i = n; i > 1; i--)
            {
                t *= i;
            }
            Console.WriteLine($"factorial of {n} is {t}");
        }
    }
}
