using System;

class Program
{
	static void Main(string[] args)
	{
		string userName;
		int squaredFavoriteNumber;

		// Welcomes the user
		DisplayWelcome();

		// Request and store the user name
		userName = PromptUserName();

		// Prompt the user for favorite number and square it (nested)
		squaredFavoriteNumber = SquareNumber(PromptUserNumber());

		// Display the result to user's screen
		DisplayResult(userName, squaredFavoriteNumber);
	}
	
	static void DisplayWelcome()
	{
		// Welcomes user to program
		Console.WriteLine("Welcome to the program!");
	}
	
	static string PromptUserName()
	{
		string userName;
		
		// Request for user name and return it
		Console.Write("Please enter your name: ");
		userName = Console.ReadLine();
		
		return (userName);
	}
	
	static int PromptUserNumber()
	{
		int favoriteNumber;
		
		// Request for user favorite number, parse it, and return it
		Console.Write("Please enter your favorite number: ");
		favoriteNumber = int.Parse(Console.ReadLine());
		
		return (favoriteNumber);
	}
	
	static int SquareNumber(int favoriteNumber)
	{
		// Return the square of user's favorite number
		return (favoriteNumber * favoriteNumber);
	}

	static void DisplayResult(string userName, int squareNumber)
	{
		// Display result to screen
		Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
	}
}
