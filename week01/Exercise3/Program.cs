using System;

class Program
{
	static void Main(string[] args)
	{
		int guessNumber = 0;
		Random randomVal = new Random();
		int randomNumber = randomVal.Next(1, 101); // Generates a random number between 1 and 100
		int numGuesses = 0;
		Console.WriteLine("Enter a guess number between 1 and 100 (-1 to quit:");
		guessNumber = Convert.ToInt32(Console.ReadLine());
		while (guessNumber != -1 && guessNumber != randomNumber)
		{
			if (guessNumber == randomNumber)
			{
				numGuesses++;
				Console.WriteLine("Congratulations! You guessed the correct number.");
				break;
			}
			else if (guessNumber < randomNumber)
			{
				Console.WriteLine("Your guess is too low. Try again:");
			}
			else if (guessNumber > randomNumber)
			{
				Console.WriteLine("Your guess is too high. Try again:");
			}

			guessNumber = Convert.ToInt32(Console.ReadLine());
		}
		// If the user quits the game or guesses the number, we exit the loop
		// and print the correct number if they didn't guess it.
		if (guessNumber == -1)
		{
			Console.WriteLine("You quit the game. The correct number was " + randomNumber);
		}
		else
		{
			Console.WriteLine("Game Over! The correct number was " + randomNumber);
			Console.WriteLine("You guessed the number in " + numGuesses + " attempts.");
		}
	}
}