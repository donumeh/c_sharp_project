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

	    // Print out the name like James Bond would say it
	    Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
