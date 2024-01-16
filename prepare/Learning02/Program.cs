using System;

class Program
{
	static void Main(string[] args)
	{
		// Create a Resume class
		Resume allison = new Resume();

		allison._name = "Allison Rose";

		// Create two Job classes
		Job firstJob = new Job();
		Job secondJob = new Job();

		firstJob._company = "Microsoft";
		firstJob._jobTitle = "Software Engineer";
		firstJob._startYear = 2019;
		firstJob._endYear = 2022;

		secondJob._company = "Apple";
		secondJob._jobTitle = "Manager";
		secondJob._startYear = 2022;
		secondJob._endYear = 2023;

		// Add the Job classes to the list of _jobs in Resume
		allison._jobs.Add(firstJob);
		allison._jobs.Add(secondJob);

		// Display user Resume
		allison.Display();
	}
}
