using System;

class ChecklistGoal : Goal
{
	private int _amountCompleted;
	private int _target;
	private int _bonus;

	public ChecklistGoal(name, description, points) : base(name, description, points)
	{
		// Construction
	}

	public override void RecordEvent()
	{}

	public override bool IsComplete()
	{}

	public override string GetDetailsString()
	{}

	public override string GetStringRepresentation()
	{
		string output = "";

		if (IsComplete() == true)
		{
			output = "[X] ";
		}
		else
		{
			output = "[ ] ";
		}

		output += $"{_name} ({_description})";

		return output;
	}

}
