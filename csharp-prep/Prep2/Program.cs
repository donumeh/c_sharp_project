using System;

class Program
{
	static void Main(string[] args)
	{
		int grade;
		string letter;
		int lastDigit;
		
		Console.Write("What's your grade? (0 - 100) ");
		grade = int.Parse(Console.ReadLine());

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

		lastDigit = grade % 10;

		if (grade >= 60)
		{
			if (lastDigit >= 7)
			{
				if (grade < 97)
				{
					letter += '+';
				}
			}
			else
				letter += '-';
		}
		Console.WriteLine(letter);

		if (grade >= 70)
			Console.WriteLine("Congratulations! You passed! Keep it up!");
		else
			Console.WriteLine("You didn't make it this time. Try harder next time.");
	}
}
