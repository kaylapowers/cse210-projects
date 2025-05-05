using System.Collections;
using System.Globalization;
using System.Net;

class Program
{
	// This is the main entry point for the application.

	static void Main(string[] args)
	{
		List<int> numbers = new List<int>();
		Console.WriteLine("Enter a number to add to the list (or '0' to quit):");
		string response = Console.ReadLine();
		while (response != "0")
		{
			if (int.TryParse(response, out int number))
			{
				numbers.Add(number);
				Console.WriteLine($"Number added to the list is {number}. Enter another number (or '0' to quit):");
			}
			else
			{
				Console.WriteLine("Invalid input. Please enter a valid number (or '0' to quit):");
			}
			response = Console.ReadLine();
		}

		Console.WriteLine("You have exited the listing of program.");


		int sum = 0;
		int count = 0;
		int largest = 0;
		int smallest = int.MaxValue;
		foreach (int number in numbers)
		{
			sum += number;
			count++;

			if (largest < number)
			{
				largest = number;
			}
			else if (smallest > number)
			{
				smallest = number;
			}

		}

		if (count > 0)
		{

			double average = (double)sum / count;
			Console.WriteLine($"The sum is {sum}.");
			Console.WriteLine($"The average is {average}.");
			Console.WriteLine($"The largest number is {largest}.");
			Console.WriteLine($"The smallest number is {smallest}.");


			Console.WriteLine("The sorted list is:");
			numbers.Sort();
			foreach (int number in numbers)
			{
				Console.WriteLine(number);
			}
		}
		else
		{
			Console.WriteLine("No numbers were entered.");
		}
	}
}