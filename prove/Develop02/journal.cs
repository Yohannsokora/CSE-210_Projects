using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> entries = new List<Entry>();
    public List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void WriteNewEntry()

    {   string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("Your Response: ");
        string response = Console.ReadLine();
        Entry entry = new(DateTime.Now, prompt, response);
        entries.Add(entry);
        Console.WriteLine("Entry saved!");
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"{entry.Date}: {entry.Prompt}\n\t{entry.Response}\n");
            }
        }
    }

    public void SaveJournalToFile()
    {
        Console.Write("Enter a filename to save the journal: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                }
            }
            Console.WriteLine("Journal saved to file successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to file: {ex.Message}");
        }
    }

    public void LoadJournalFromFile()
    {
        Console.Write("Enter a filename to load the journal from: ");
        string filename = Console.ReadLine();

        try
        {
            List<Entry> loadedJournal = new List<Entry>();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime date))
                    {
                        loadedJournal.Add(new Entry(date, parts[1], parts[2]));
                    }
                }
            }
            entries = loadedJournal;
            Console.WriteLine("Journal loaded from file successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from file: {ex.Message}");
        }
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}
