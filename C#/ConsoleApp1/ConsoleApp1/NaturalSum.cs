using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class NaturalSum
    {
        internal void Sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of first {n} natural numbers is {sum}");
        }
    }
}
