using System;

class SimpleGoal : Goal
{
	private bool _isComplete;

	
	public SimpleGoal(name, description, points) : base(name, description, points)
	{
		// Constructor
	}

	public override void RecordEvent()
	{}

	public override bool IsComplete()
	{}

	public override string GetStringRepresentation()
	{
		string output = "";

		if (IsComplete() == true)
		{
			output += "[X] ";
		}
		else
		{
			output += "[ ] ";
		}

		output += $"{_name} ({_description})";
		return output;
	}
}
