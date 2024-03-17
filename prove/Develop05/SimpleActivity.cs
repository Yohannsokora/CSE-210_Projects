public class SimpleActivity : Activity
{
    public SimpleActivity(string name, int points) : base(name, points) { }

    public override int Complete()
    {
        _completed = true;
        return _points;
    }

    public override string Display()
    {
        return $"{_name} - {(_completed ? "Completed" : "Not Completed")}";
    }

    public override string GetStringRepresentation()
    {
        return $"Simple:{_name}:{_points}:{_completed}";
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
        SimpleActivity activity = new SimpleActivity("", 0);
        activity.LoadFromString(data);
        return activity;
    }
}
