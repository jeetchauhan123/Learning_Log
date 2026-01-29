using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Largest
    {
        int A, B, C;
        public Largest(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        internal void Find()
        {
            int max = (A > B) ? (A > C ? A : C) : (B > C ? B : C);
            Console.WriteLine($"{max} is the largest number");
        }
    }
}
