using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class CompoundInterest
    {
        internal void Ci(float p, float r, float t, int n)
        {
            double amount = p * Math.Pow((1 + r / (n * 100)), n * t);
            double ci = amount - p;
            Console.WriteLine($"Compound Intrest is {ci}");
        }
    }
}
