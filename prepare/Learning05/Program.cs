public class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");

            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal(activities);
                    break;
                case "2":
                    ListGoals(activities);
                    break;
                case "3":
                    SaveGoals(activities);
                    break;
                case "4":
                    LoadGoals(ref activities);
                    break;
                case "5":
                    RecordEvent(activities);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateGoal(List<Activity> activities)
    {   
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Type: ");
        string typeInput = Console.ReadLine();
        Console.WriteLine("Enter goal details:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());
  

        switch (typeInput)
        {
            case "1":
                activities.Add(new SimpleActivity(name, points));
                break;
            case "2":
                activities.Add(new EternalActivity(name, points));
                break;
            case "3":
                Console.Write("Target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                activities.Add(new ChecklistActivity(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void ListGoals(List<Activity> activities)
    {
        if (activities.Count == 0)
        {
            Console.WriteLine("No goals.");
        }
        else
        {
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.Display());
            }
        }
    }

    static void SaveGoals(List<Activity> activities)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter("goals.txt"))
            {
                foreach (Activity activity in activities)
                {
                    sw.WriteLine(activity.GetStringRepresentation());
                }
                Console.WriteLine("Goals saved successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving goals: " + ex.Message);
        }
    }

    static void LoadGoals(ref List<Activity> activities)
{
    try
    {
        using (StreamReader sr = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(':');
                string type = parts[0];

                switch (type)
                {
                    case "Simple":
                        activities.Add(new SimpleActivity("", 0).CreateActivity(line));
                        break;
                    case "Eternal":
                        activities.Add(new EternalActivity("", 0).CreateActivity(line));
                        break;
                    case "Checklist":
                        activities.Add(new ChecklistActivity("", 0, 0, 0).CreateActivity(line));
                        break;
                    default:
                        Console.WriteLine($"Unknown activity type '{type}'.");
                        break;
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("No saved goals found.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error loading goals: " + ex.Message);
    }
}


    static void RecordEvent(List<Activity> activities)
    {
        Console.WriteLine("Enter the name of the goal you completed:");
        string goalName = Console.ReadLine();
        Activity goal = activities.Find(a => a.Name == goalName);
        if (goal != null)
        {
            Console.WriteLine("Points gained: " + goal.Complete());
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }
}