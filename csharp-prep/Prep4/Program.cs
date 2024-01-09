using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		// Declaration of all data needed to be stored
		int numberEntered;
		int sumOfNumberEntered = 0;
		double average;
		int largestNumber;
		int lowestPositiveNumber;
		List<int> numberSeries = new List<int>();

		// Request they enter a list of numbers and 0 to end the list
		Console.WriteLine("Enter a list of numbers, type 0 when finished");

		// Create a infinite loop to receive the numbers to add to list
		while (true)
		{
			Console.Write("Enter number: ");

			// Receive and parse number to integer datatype
			numberEntered = int.Parse(Console.ReadLine());

			// store number into list and if 0 discontinue
			if (numberEntered != 0)
			{
				numberSeries.Add(numberEntered);
			}
			else
				break;

		}

		// Store the first element of the lists for comparision
		largestNumber = numberSeries[0];
		lowestPositiveNumber = numberSeries[0];

		// Loop over the list
		foreach (int number in numberSeries)
		{
			// Sum the numbers in the list
			sumOfNumberEntered += number;
			
			// Store an higher number if found
			if (number > largestNumber)
			{
				largestNumber = number;
			}

			// Store a lowest positive number if found
			if ((number < lowestPositiveNumber) && (number >= 0))
			{
				lowestPositiveNumber = number;
			}
		}
		// Calculate the average of the number
		average = (double)sumOfNumberEntered / numberSeries.Count;
		// Sort the numbers
		numberSeries.Sort();

		// Print the sum, average, largest number, and smallest number
		Console.WriteLine($"The sum is {sumOfNumberEntered}");
		Console.WriteLine($"The average is: {average}");
		Console.WriteLine($"The largest number is: {largestNumber}");
		Console.WriteLine($"The smallest positive number is {lowestPositiveNumber}");


		// Print the sorted Number Series or List
		Console.WriteLine($"The sorted list is:");

		foreach (int number in numberSeries)
		{
			Console.WriteLine(number);
		}
	}
}
