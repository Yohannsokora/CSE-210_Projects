using System;

public class Program
{
    public static void Main()
    {
        var scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        var wordsToHide = scripture.Text.Split().Length;
        var remainingWords = wordsToHide;

        Console.WriteLine($"{scripture.Reference} - {scripture.Text}");

        while (remainingWords > 0)
        {
            Console.WriteLine("Press Enter to reveal more words, or type 'quit' to exit: ");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            var numToHide = Math.Min(new Random().Next(1, 4), remainingWords);
            for (var i = 0; i < numToHide; i++)
            {
                HideWords.HideRandomWord(scripture);
                remainingWords--;
            }

            Console.Clear();
            Console.WriteLine($"{scripture.Reference} - {scripture.Text}");
        }

        Console.WriteLine("Program ended. I hope that you matered this scripture.");
    }
}
