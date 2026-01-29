// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Diagnostics;

Console.WriteLine("Hello, World!");
static void Calc()
{
    Calculator obj1 = new();
    obj1.Menu();
}
//Calc();

static void Pattern()
{
    Patterns obj2 = new();
    //central pyramid
    //obj2.Pt1();

    //central pyramid with even odd place
    //obj2.Pt2();

    //left side pyramid
    obj2.Pt3();

    //right side pyramid
    obj2.Pt4();

    //inverted left pyramid
    obj2.Pt5();

    //inverted right pyramid
    obj2.Pt6();

    //inverted central pyramid
    obj2.Pt7();

    //inverted central even odd pyramid
    obj2.Pt8();

    //numeric 1-10 left pyramid
    obj2.Pt9();
}
//Pattern();

static void Expression()
{
    Bodmas obj3 = new();
    obj3.Accept();
}
//Expression();

//even odd - parity check
static void ParityCheck()
{
    OddEven obj4 = new();
    obj4.Check();
}
//ParityCheck();

//Largest of three numbers
static void Large()
{
    int a, b, c;
    Console.WriteLine("Enter Number 1:");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Number 2:");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Number 3:");
    c = Convert.ToInt32(Console.ReadLine());
    Largest obj5 = new(a, b, c);
    obj5.Find();
}
Large();