using System;

namespace Lab03._3
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 * A single selection completes a single scenario and a while repitition statment specifies that a program should complete
			an action while a statment is true. Both of these statements work if the true conditions have been met.
			*/

			int speedlimit = 35;
			int speed = 42;

			if (speed > speedlimit)
			{
				Console.WriteLine("SLOW NOW ");
			}

			bool isTrue = true;

			if (isTrue)
			{
				Console.WriteLine("It is True!");
			}
			else
			{
				Console.WriteLine("It is False!");
			}
			Console.WriteLine("Please enter a temperature in Fahrenheit");

			double fahrenheit = Convert.ToDouble(Console.ReadLine());
			double celsius = (fahrenheit - 32d) * 5d / 9d;
			Console.WriteLine(celsius);
			if (fahrenheit < 40)
			{
				Console.WriteLine("It is cold");
			}
			if (fahrenheit > 90)
			{
				Console.WriteLine("It is hot");


			}
			int a = 1;

			while (a <= 10)
			{
				Console.WriteLine(a);
				a++;
			}


			int b = 60;

			while (b >= 20)
			{
				Console.WriteLine(b);
				b = b - 5;
			}


			int c = 10;

			while (c <= 20)
			{
				Console.WriteLine(c);
				c = c + 2;
			}
			
		}
	}
}

