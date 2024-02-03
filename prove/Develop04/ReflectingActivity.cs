using System;

// Reflecting Class
class ReflectingActivity
{
	// Reflecting Attributes
	private List<string> _prompts;
	private List<string> _questions;

	// Reflecting Methods
	public ReflectingActivity()
	{
		// Constructor
		_name = "Reflecting Activity";
		_description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
	}

	// Run program
	public void Run()
	{
		DisplayStartingMessage();
	}

	public string GetRandomPrompt()
	{}

	public string GetRandomQuestion()
	{}

	public void DisplayPrompt()
	{}

	public void DisplayQuestions()
	{}
}
