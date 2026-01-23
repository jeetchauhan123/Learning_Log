using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Calculator
    {
        int a, b, c;
        int ch;
        bool run = true;
        internal void Accept()
        {
            Console.WriteLine("Enter Number 1:");
            a=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Number 2:");
            b = Convert.ToInt16(Console.ReadLine());
        }
        internal void Sum()
        {
            c = a + b;
            Console.WriteLine("Sum of {0} and {1} is {2}", a, b, c);
        }
        internal void Sub()
        {
            c = a - b;
            Console.WriteLine("Sub of {0} and {1} is {2}", a, b, c);
        }
        internal void Mul()
        {
            c = a * b;
            Console.WriteLine("Mul of {0} and {1} is {2}", a, b, c);
        }
        internal void Div()
        {
            c = a / b;
            Console.WriteLine("Div of {0} and {1} is {2}", a, b, c);
        }
        internal void Menu()
        {
            Accept();
            
            while (run)
            {
                Console.WriteLine("Choose a method of Operation:");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Enter New Numbers");
                Console.WriteLine("6.Exit");
                ch = Convert.ToInt16(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Sum();
                        break;
                    case 2:
                        Sub();
                        break;
                    case 3:
                        Mul();
                        break;
                    case 4:
                        Div();
                        break;
                    case 5:
                        Accept();
                        break;
                    case 6:
                        run = false;
                        Console.WriteLine("Thanks for calculating");
                        break;
                    default:
                        Console.WriteLine("Enter Proper Value");
                        break;
                }
            }
        }
    }
}
