using System;

// Breathing Activity Class

class BreathingActivity : Activity
{

	public BreathingActivity()
	{
		// Constructor
		_description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
		_name = "Breathing Activity";
	}

	public void Run()
	{
		DisplayStartingMessage();
		Spinner(5);
		DateTime futureTime = DateTime.Now.AddSeconds(_duration);

		while (DateTime.Now <= futureTime)
		{
			Console.Write("\nBreathe in...");
			ShowCountDown(5);
			Console.Write("\nNow breathe out...");
			ShowCountDown(5);
			Console.WriteLine();
		}
		DisplayEndingMessage();
		Spinner(5);
	}
}
