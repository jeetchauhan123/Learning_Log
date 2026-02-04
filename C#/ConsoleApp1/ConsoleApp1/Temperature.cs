using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Temperature
    {
        private int Temp;
        public virtual int Calculate() { return Temp; }
        public void Settemp(int t)
        {
            Temp = t;
        }
        public int Gettemp()
        {
            return Temp;
        }
    }
    internal class Celsius : Temperature
    {
        public void SetCelsius(int value)
        {
            Settemp(value);   // ✅ THIS sets Temp
        }
        public override int Calculate()
        {
            int temp = Gettemp();
            int cel = ((temp - 32) * 5 / 9);
            return cel;
        }
    }
    internal class Fahrenheit : Temperature
    {
        public void SetFahrenheit(int value)
        {
            Settemp(value);   // ✅ THIS sets Temp
        }
        public override int Calculate()
        {
            int temp = Gettemp();
            int fer = ((temp * 9 / 5) + 32);
            return fer;
        }
    }
    internal class Menu
    {
        Temperature Calc;
        public void ShowMenu() // Changed from static to instance method
        {
            Console.WriteLine("Choose 1 option:");
            Console.WriteLine("1. Convert to Celsius");
            Console.WriteLine("2. Convert to Fahrenheit");
            int ch = Convert.ToInt16(Console.ReadLine());
            int temp;
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter temperature in Fahrenheit:");
                    temp = Convert.ToInt16(Console.ReadLine());
                    Calc = new Celsius();
                    Calc.Settemp(temp);
                    int cel = Calc.Calculate();
                    Console.WriteLine($"{temp} in Celsius is {cel}");
                    break;
                case 2:
                    Console.WriteLine("Enter temperature in Celsius:");
                    temp = Convert.ToInt16(Console.ReadLine());
                    Calc = new Fahrenheit();
                    Calc.Settemp(temp);
                    int fer = Calc.Calculate();
                    Console.WriteLine($"{temp} in Fahrenheit is {fer}");
                    break;
                default:
                    Console.WriteLine("Choose Appropriate option");
                    break;
            }
        }
    }
}
