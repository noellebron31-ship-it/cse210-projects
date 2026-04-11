public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string desc, int points) : base(name, desc, points)
    {
        _isComplete = false;
    }

    // Constructor for loading from file
    public SimpleGoal(string name, string desc, int points, bool isComplete) : base(name, desc, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return int.Parse(_points);
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}