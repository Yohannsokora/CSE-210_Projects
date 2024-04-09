using System;
using System.Collections.Generic;

// Base Activity class
public abstract class Activity
{
    public DateTime Date { get; set; }
    public int Minutes { get; set; }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} ({Minutes} min): Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}

// Running class
public class Running : Activity
{
    public double Distance { get; set; }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / Minutes * 60;
    }

    public override double GetPace()
    {
        return Minutes / Distance;
    }
}

// Cycling class
public class Cycling : Activity
{
    public double Speed { get; set; }

    public override double GetDistance()
    {
        return Speed * Minutes / 60;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}

// Swimming class
public class Swimming : Activity
{
    public int Laps { get; set; }

    public override double GetDistance()
    {
        return Laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / Minutes * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
}

class Program
{
    static void Main()

    {   Console.WriteLine();
        List<Activity> activities = new List<Activity>
        {
            new Running { Date = new DateTime(2024, 11, 3), Minutes = 30, Distance = 3.0 },
            new Cycling { Date = new DateTime(2024, 11, 3), Minutes = 30, Speed = 6.0 },
            new Swimming { Date = new DateTime(2024, 11, 3), Minutes = 30, Laps = 30 }
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
