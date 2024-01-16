using System;

public class Resume
{
	// Attributes for class Resume
	
	public string _name;
	public List<Job> _jobs = new List<Job>();

	public Resume()
	{ // Constructor
	}

	public void Display()
	{
		// Display the resume
		
		Console.WriteLine($"Name: {_name}\nJobs:");

		foreach (Job j in _jobs)
		{
			j.Display();
		}
	}
}
