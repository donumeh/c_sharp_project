using System;

class Goal
{
	protected string _shortName;
	protected string _description;
	protected string _points;


	public Goal(name, description, points)
	{
		_shortName = name;
		_description = description;
		_points = points;
	}

	public virtual void RecordEvent();
	public virtual bool IsComplete();
	public virtual string GetDetailsString();
	public virtual string GetStringRepresentation();

}
