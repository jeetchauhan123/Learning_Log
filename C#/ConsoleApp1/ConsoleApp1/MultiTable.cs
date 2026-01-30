using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class MultiTable
    {
        internal void Table(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
