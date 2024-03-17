using System;

public abstract class Activity
{
    protected string _name;
    
    protected int _points;
    protected bool _completed;

    public string Name { get { return _name; } }
    public bool Completed { get { return _completed; } }

    public Activity(string name, int points)
    {
        _name = name;
        _points = points;
        _completed = false;
    }

    public abstract int Complete();
    public abstract string Display();

    public abstract string GetStringRepresentation();
    public abstract void LoadFromString(string data);
    public abstract Activity CreateActivity(string data);
}