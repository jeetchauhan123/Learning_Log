using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Patterns
    {
        //central pyramid
        internal void Pt1()
        {
            for (int i = 0; i < 5; i++)
            {
                for (global::System.Int32 j = 0; j < 5-i; j++)
                {
                    Console.Write(" ");
                }
                for (global::System.Int32 k = 0; k < i+1; k++)
                {
                    Console.Write("*");
                }
                for (global::System.Int32 l = 0; l < i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        //central pyramid with even odd place
        internal void Pt2()
        {
            for (int i = 1; i < 6; i++)
            {
                for (global::System.Int32 j = 1; j < 6 - i; j++)
                {
                    Console.Write(" ");
                }
                for (global::System.Int32 k = 1; k < i+i+1; k++)
                {
                    if (k % 2 != 0)
                    {
                        Console.Write("*");
                    }
                    if (k % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                }
                //for (global::System.Int32 l = 0; l < i; l++)
                //{
                //    Console.Write("*");
                //}
                Console.WriteLine("");
            }
        }

        //left side pyramid
        internal void Pt3()
        {
            for (int i = 0; i < 5; i++)
            {
                for (global::System.Int32 j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        //right side pyramid
        internal void Pt4()
        {
            for (int i = 0; i < 5; i++)
            {
                for (global::System.Int32 j = 0; j < 5-i; j++)
                {
                    Console.Write(" ");
                }
                for (global::System.Int32 k = 0; k < i+1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        //inverted left pyramid
        internal void Pt5()
        {
            for (int i = 0; i < 5; i++)
            {
                for (global::System.Int32 j = 0; j < 5-i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        //inverted right pyramid
        internal void Pt6()
        {
            for (int i = 0; i < 5; i++)
            {
                for (global::System.Int32 j = 0; j < i+1; j++)
                {
                    Console.Write(" ");
                }
                for (global::System.Int32 k = 0; k < 5-i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        //inverted central pyramid
        internal void Pt7()
        {
            for (int i = 0; i < 5; i++)
            {
                for (global::System.Int32 j = 0; j < i+1; j++)
                {
                    Console.Write(" ");
                }
                for (global::System.Int32 k = 0; k < 5-i; k++)
                {
                    Console.Write("*");
                }
                for (global::System.Int32 l = 0; l < 5-i-1; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        //inverted central even odd pyramid
        internal void Pt8()
        {
            for (int i = 0; i < 5; i++)
            {
                for (global::System.Int32 j = 0; j < i+1; j++)
                {
                    Console.Write(" ");
                }
                for (global::System.Int32 k = 0; k < 11-i-i; k++)
                {
                    if (k % 2 != 0)
                    {
                        Console.Write("*");
                    }
                    if (k % 2 != 0)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }

        //numeric 1-10 left pyramid
        internal void Pt9()
        {
            int num = 1;
            for (int i = 1; i < 5; i++)
            {
                for (global::System.Int32 j = 1; j < i+1; j++)
                {
                    Console.Write(num);
                    num += 1;
                }
                Console.WriteLine("");
            }
        }
    }
}
