using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		int numberEntered;
		int sumOfNumberEntered = 0;
		double average;
		int largestNumber;
		int lowestPositiveNumber;

		List<int> numberSeries = new List<int>();

		Console.WriteLine("Enter a list of numbers, type 0 when finished");

		while (true)
		{
			Console.Write("Enter number: ");

			numberEntered = int.Parse(Console.ReadLine());

			if (numberEntered != 0)
			{
				numberSeries.Add(numberEntered);
			}
			else
				break;

		}

		largestNumber = numberSeries[0];
		lowestPositiveNumber = numberSeries[0];

		foreach (int number in numberSeries)
		{
			sumOfNumberEntered += number;
			if (number > largestNumber)
			{
				largestNumber = number;
			}
			if (number < lowestPositiveNumber)
			{
				lowestPositiveNumber = number;
			}
		}
		average = (double)sumOfNumberEntered / numberSeries.Count;
		numberSeries.Sort();

		Console.WriteLine($"The sum is {sumOfNumberEntered}");
		Console.WriteLine($"The average is: {average}");
		Console.WriteLine($"The largest number is: {largestNumber}");
		Console.WriteLine($"The smallest positive number is {lowestPositiveNumber}");

		Console.WriteLine($"The sorted list is:");

		foreach (int number in numberSeries)
		{
			Console.WriteLine(number);
		}
	}
}
