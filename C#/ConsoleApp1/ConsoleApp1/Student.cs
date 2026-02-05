//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1
//{
//    internal class Student
//    {

//        Display display = new();
//        internal void StudentDetails(string name, int Rollno, int Marks)
//        {
//            display.DisplayDetails(name, Rollno, Marks);
//        }
//    }
//    internal class Display
//    {
//        internal void DisplayDetails(string name, int Rollno, int Marks)
//        {
//            Console.WriteLine($"Student Name: {name}");
//            Console.WriteLine($"Roll Number: {Rollno}");
//            Console.WriteLine($"Student Marks: {Marks}");
//        }
//    }
//    internal class StudentMenu
//    {
//        Student student = new();
//        public void Accept()
//        {
//            Console.WriteLine("Enter Student Name:");
//            string name = Console.ReadLine();
//            Console.WriteLine("Enter Student Roll Number:");
//            int rollno = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Student Marks:");
//            int marks = Convert.ToInt32(Console.ReadLine());
//            student.StudentDetails(name, rollno, marks);
//        }
//    }
//}


using System;

namespace ConsoleApp1
{
    internal class Student
    {
        public string Name { get; private set; }
        public int RollNo { get; private set; }
        public int Marks { get; private set; }

        public Student(string name, int rollNo, int marks)
        {
            Name = name;
            RollNo = rollNo;
            Marks = marks;
        }
    }

    internal class Display
    {
        internal void DisplayDetails(Student student)
        {
            Console.WriteLine($"Student Name  : {student.Name}");
            Console.WriteLine($"Roll Number   : {student.RollNo}");
            Console.WriteLine($"Student Marks : {student.Marks}");
        }
    }

    internal class StudentMenu
    {
        public void Accept()
        {
            Console.WriteLine("Enter Student Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Student Roll Number:");
            int rollNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Marks:");
            int marks = Convert.ToInt32(Console.ReadLine());

            Student student = new Student(name, rollNo, marks);
            Display display = new Display();

            display.DisplayDetails(student);
        }
    }
}
