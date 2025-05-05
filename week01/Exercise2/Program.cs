using System;

class Program
{
	static void Main(string[] args)
	{
		bool pass = true;
		string posneg = "";

		Console.WriteLine("Welcome to the Grade Calculator!");


		Console.WriteLine("What is your grade percentage?");

		string input = Console.ReadLine();
		int grade = int.Parse(input);
		string letterGrade = "";

		if (grade >= 90)
		{

			letterGrade = "A";

		}
		else if (grade >= 80)
		{

			letterGrade = "B";

		}
		else if (grade >= 70)
		{
			letterGrade = "C";

		}
		else if (grade >= 60)
		{

			letterGrade = "D";
			pass = false;
		}
		else
		{
			letterGrade = "F";
			pass = false;
		}



		if (grade % 10 >= 7 && letterGrade != "A")
		{
			posneg = "+";
		}

		else if (grade % 10 < 3 && letterGrade != "F")
		{
			posneg = "-";
		}



		if (pass == true)
		{
			Console.WriteLine("You have passed the class.");

		}
		else
		{
			Console.WriteLine("You have failed the class. Try harder next time.");

		}

		Console.WriteLine($"Your letter grade is {letterGrade}{posneg}.");

		Console.WriteLine("Do you want to check another grade? (yes/no)");

		string response = Console.ReadLine();
		if (response.ToLower() == "yes")

		{
			Main(args); // Restart the program

		}
	}
}