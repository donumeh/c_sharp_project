using System;

class Program
{
	static void Main(string[] args)
	{
		int grade;
		string letter;
		int lastDigit;

		// Request for grade
		Console.Write("What's your grade? (0 - 100) ");
		// Convert grade to integer
		grade = int.Parse(Console.ReadLine());

		// Check grade point
		if (grade >= 90)
			letter = "A";
		else if (grade >= 80)
			letter = "B";
		else if (grade >= 70)
			letter = "C";
		else if (grade >= 60)
			letter = "D";
		else
			letter = "F";

		// collect the last digit of grade
		lastDigit = grade % 10;

		// Don't apply '+' '-' to grade 'F'
		if (grade >= 60)
		{
			if (lastDigit >= 7)
			{
				// Don't apply '+' to grade > 97 (A)
				if (grade < 97)
				{
					letter += '+';
				}
			}
			else
				letter += '-';
		}
		// Print grade letter
		Console.WriteLine(letter);

		// Print remark for grade
		if (grade >= 70)
			Console.WriteLine("Congratulations! You passed! Keep it up!");
		else
			Console.WriteLine("You didn't make it this time. Try harder next time.");
	}
}
