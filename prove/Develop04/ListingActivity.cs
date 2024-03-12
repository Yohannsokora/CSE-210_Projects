using System;

public class ListingActivity : Activity
{
    private string[] _prompts = new[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    protected override void PerformActivity()
    {
       
            string prompt = _prompts[new Random().Next(_prompts.Length)];
            Console.WriteLine(prompt);
            Pause(3);
            Console.WriteLine("Begin listing...");
            Console.WriteLine("Press Enter after each item, or type 'done' to finish.");
            int count = 0;
            string item;
            do
            {
                Console.Write($"{++count}. ");
                item = Console.ReadLine();
            } while (item.ToLower() != "done");
            Console.WriteLine($"Number of items listed: {count - 1}");
            _duration -= count * 3; // Assume each item takes 3 seconds
    }
}
