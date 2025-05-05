using System;

class Program()
{
	static void DisplayWelcome()
	{
		Console.WriteLine("Welcome to the Program!");
	}

	static string PromptUserForName()
	{
		Console.Write("Please enter your name: ");
		string name = Console.ReadLine();
		Console.WriteLine($"Hello, {name}!");
		return name;
	}

	static int PromptUserForNumber()
	{
		Console.WriteLine("Please enter your favorite integer number: ");
		string input = Console.ReadLine();
		if (int.TryParse(input, out int number))
		{

			return number;
		}
		else
		{
			Console.WriteLine("That's not a valid number.");
			return 0;
		}
	}


	static int SquareNumber(int number)
	{
		int squared = number * number;

		return squared;
	}

	static void DisplayResult(string name, int squared)
	{
		Console.WriteLine($"{name}, the square of your number is {squared}.");
	}





	static void Main(string[] args)
	{

		DisplayWelcome();
		string name = PromptUserForName();
		int number = PromptUserForNumber();
		if (number == 0)
		{
			Console.WriteLine("Exiting the program due to invalid input.");
			return;
		}
		else
		{
			int squared = SquareNumber(number);
			DisplayResult(name, squared);
		}



	}
}