public class EternalActivity : Activity
{
    public EternalActivity(string name, int points) : base(name, points) { }

    public override int Complete()
    {
        return _points;
    }

    public override string Display()
    {
        return $"{_name} - {_points}";
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal:{_name}:{_points}:{_completed}";
    }

    public override void LoadFromString(string data)
    {
        string[] parts = data.Split(':');
        _name = parts[1];
        _points = int.Parse(parts[2]);
        _completed = bool.Parse(parts[3]);
    }

    public override Activity CreateActivity(string data)
    {
        EternalActivity activity = new EternalActivity("", 0);
        activity.LoadFromString(data);
        return activity;
    }
}