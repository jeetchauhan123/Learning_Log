using System;

namespace ConsoleApp1
{
	public class OddEven
	{
		public void Check()
		{
			Console.WriteLine("Enter a number:");
			int number = Convert.ToInt32(Console.ReadLine());
			//if (number % 2 == 0)
			//{
			//	Console.WriteLine(number + " is even number");
			//}
			//else
			//{
			//	Console.WriteLine(number + " is odd number");
			//}
			Console.WriteLine(number % 2 == 0 ? $"{number} is even number" : $"{number} is odd number");
		}
	}
}