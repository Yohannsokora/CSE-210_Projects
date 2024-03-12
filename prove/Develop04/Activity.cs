using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected int _originalDuration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name} activity:");
        Console.WriteLine(_description);
        SetDuration();
        Console.WriteLine("Prepare to begin...");
        Pause(5);
        Console.WriteLine("Begin!");
        PerformActivity();
        End();
    }

    protected virtual void SetDuration()
    {
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        _originalDuration = _duration;
    }

    protected abstract void PerformActivity();

    protected void Pause(int seconds)
{
    string[] spinner = { "|", "/", "-", "\\" };
    int spinnerIndex = 0;
    for (int i = 0; i < seconds; i++)
    {
        Console.Write($"{spinner[spinnerIndex % spinner.Length]} ");
        Thread.Sleep(1000);
        Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        spinnerIndex++;
    }
}


    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job!");
        Console.WriteLine($"You have completed the {_name} activity for {_originalDuration} seconds.");
        Pause(3);
    }

    protected virtual void End()
    {
        DisplayEndingMessage();
    }
}
