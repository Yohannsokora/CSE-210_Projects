public class ReflectionActivity : Activity
{
    private string[] _prompts = new[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = new[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    protected override void PerformActivity()
    {
        while (_duration > 0)
        {
            string prompt = _prompts[new Random().Next(_prompts.Length)];
            Console.WriteLine(prompt);
            Pause(3);
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            foreach (string question in _questions)
            {
                Console.WriteLine(question);
                //ShowSpinner(3);
                Console.WriteLine();
                Pause(6);
            }
            _duration -= 60; // Assume each question takes 6 seconds
        }
    }

    
    }