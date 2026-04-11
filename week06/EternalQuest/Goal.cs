public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points; // Stored as string to match standard patterns, or int for math

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points.ToString();
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}