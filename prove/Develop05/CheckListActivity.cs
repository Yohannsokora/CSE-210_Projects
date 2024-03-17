public class ChecklistActivity : Activity
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistActivity(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override int Complete()
    {
        _currentCount++;
        if (_currentCount == _targetCount)
        {
            _completed = true;
            return _points + _bonusPoints;
        }
        return _points;
    }

    public override string Display()
    {
        return $"{_name} - {_currentCount}/{_targetCount} times - {(_completed ? "Completed" : "Not Completed")}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist:{_name}:{_points}:{_completed}:{_targetCount}:{_currentCount}:{_bonusPoints}";
    }

    public override void LoadFromString(string data)
    {
        string[] parts = data.Split(':');
        _name = parts[1];
        _points = int.Parse(parts[2]);
        _completed = bool.Parse(parts[3]);
        _targetCount = int.Parse(parts[4]);
        _currentCount = int.Parse(parts[5]);
        _bonusPoints = int.Parse(parts[6]);
    }

    public override Activity CreateActivity(string data)
    {
        ChecklistActivity activity = new ChecklistActivity("", 0, 0, 0);
        activity.LoadFromString(data);
        return activity;
    }
}