using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class SimpleIntrest
    {
        internal void Si(float p, float r, float t)
        {
            float si = (p * r * t) / 100;
            Console.WriteLine($"Simple Intrest is {si}");
        }
    }
}
