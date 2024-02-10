using System;

class EternalGoal : Goal
{
	public EternalGoal(name, description, points) : base(name, description, points)
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

		output += $"{_name} ({_description})";
		return output;
	}
}
