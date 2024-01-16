using System;

public class Job
{
	// Attributes of Class Job
	public string _company;
	public string _jobTitle;
	public int _startYear;
	public int _endYear;

	public Job()
	{ // Constructor
	}

	public void Display()
	{
		// Displays job information
		// Format:
		// 	Job Tile (Company) StartYear-EndYear

		Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
	}

}

