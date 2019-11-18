using System;

namespace Lab02
{
	class Program
	{
		static void Main(string[] args);

			int number1;
			int number2;
			int product;
        //testing

			Console.Write("Enter first int: ");
			number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter second int: ");
			number2 = Convert.ToInt32(Console.ReadLine());

			product = number1 * number2;
			Console.WriteLine("product is {0}", product);

			Console.WriteLine("(0)\n(1)", "Hello World!", "From Jessie Bobby");
			Console.WriteLine("(0)\t(1)",	"Hello World!", "From Jessie Bobby");

			/*
			 * Our C# program executes on line 11, the main function. It starts with the declaring variables and then getting user input
			 * and doing our product calculation and outputting the hello world function.
			 * 
			 * An integer type variable stores numbers in a limited range of real numbers precisely, while floating point variables store 
			 * approximations of real numbers across a wide range.
			 * 
			 * public void DisplayMessage(string CourseName)
			 * (
			 * Console.WriteLine("Welcome to the grade book for \n(0)!", courseName);
			 * )
			 * 
			 * Get accessor, set accessor
			 * 
			 * A class houses a message and an object is an instance of the class. You can create as many instances of a class as each one has a different object.
			 * */



		{
			Console.WriteLine("Hello World!");
		}
	}
}
