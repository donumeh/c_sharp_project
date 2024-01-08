using System;

class Program
{
	static void Main(string[] args)
	{
		int magicNumber, numOfGuesses = 0;

		// Generate random number
		Random randomNumber = new Random();

		// Store randome number
		magicNumber = randomNumber.Next(1, 101);

		while (true)
		{
			int numberEntered;

			// Request for guess
			Console.Write("What is your guess? ");
			// Read input and convert to integer
			numberEntered = int.Parse(Console.ReadLine());
			// increment number of guesses
			numOfGuesses++;

			// Condition to check for the guess
			if (magicNumber > numberEntered)
			{
				Console.WriteLine("Higher");
			}
			else if (magicNumber < numberEntered)
			{
				Console.WriteLine("Lower");
			}
			else
			{
				string response;

				Console.WriteLine($"You guessed it!\nYou made {numOfGuesses} guesses.");

				// Ask if player would like to play again
				Console.Write("Would you like to play again? (yes/no) ");
				// Collect input
				response = Console.ReadLine();

				if (response == "yes")
				{
					// Generate another random number
					magicNumber = randomNumber.Next(1, 101);
					// Initialize numOf Guesses back to Zero
					numOfGuesses = 0;
					continue;
				}
				break;
			}
		}
	}
}
