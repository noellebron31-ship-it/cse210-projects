public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus) : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    // Constructor for loading
    public ChecklistGoal(string name, string desc, int points, int target, int bonus, int current) : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = current;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            return int.Parse(_points) + _bonus;
        }
        return int.Parse(_points);
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}