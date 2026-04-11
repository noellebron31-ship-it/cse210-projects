public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points) : base(name, desc, points) { }

    public override int RecordEvent()
    {
        return int.Parse(_points);
    }

    public override bool IsComplete() => false;

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}