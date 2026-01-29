using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class GradeSystem(int marks)
    {
        public int marks = marks;

        internal void Grade()
        {
            //if(marks >= 90)
            //{
            //    Console.WriteLine("Grade: A");
            //}
            //else if(marks >= 75 && marks < 90)
            //{
            //    Console.WriteLine("Grade: B");
            //}
            //else if (marks >=60 && marks <75)
            //{
            //    Console.WriteLine("Grade: C");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}
            Console.WriteLine(
                marks >= 90 ? "Grade: A" :
                marks >= 75 ? "Grade: B" :
                marks >= 60 ? "Grade: C" :
                "Fail"
            );
        }
    }
}
