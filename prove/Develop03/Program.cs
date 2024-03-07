using System;

class Program
{
    static void Main()
    {
        var scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        Console.WriteLine(scripture.Display());

        while (!scripture.AllWordsHidden() && !scripture.UserWantsToQuit())
        {
            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit: ");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord();
            Console.Clear();
            Console.WriteLine(scripture.Display());
        }

        Console.WriteLine("Program ended. I hope that you mastered this scripture.");
    }
}

 