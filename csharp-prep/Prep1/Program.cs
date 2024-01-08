using System;

class Program
{
    static void Main(string[] args)
    {
	    string firstName;
	    string lastName;

	    // Request for user's firstName
	    Console.Write("What is your first name? ");
	    firstName = Console.ReadLine();

	    // Request for user's lastName
	    Console.Write("What is your last name? ");
	    lastName = Console.ReadLine();

	    Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
