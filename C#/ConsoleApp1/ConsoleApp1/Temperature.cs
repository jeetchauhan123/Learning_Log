using System;

class Temperature
{
    public void Convert()
    {
        int choice;
        int temp;
        int result;

        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");

        choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Enter Fahrenheit:");
            temp = int.Parse(Console.ReadLine());

            result = (temp - 32) * 5 / 9;
            Console.WriteLine("Celsius = " + result);
        }
        else
        {
            Console.WriteLine("Enter Celsius:");
            temp = int.Parse(Console.ReadLine());

            result = (temp * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit = " + result);
        }
    }
}


