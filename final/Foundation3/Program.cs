using System;

// Address class
public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    public override string ToString()
    {
        return $"{Street}, {City}, {State} {ZipCode}";
    }
}

// Base Event class
public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public Address Address { get; set; }

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{GetType().Name}: {Title}\nDate: {Date.ToShortDateString()}";
    }
}

// Lecture class
public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}

// Reception class
public class Reception : Event
{
    public string RsvpEmail { get; set; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {RsvpEmail}";
    }
}

// OutdoorGathering class
public class OutdoorGathering : Event
{
    public string WeatherForecast { get; set; }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
    }
}

class Program
{
    static void Main()
    {
        // Create instances of each event type
        Lecture lecture = new Lecture("Python Programming Lecture", "Learn about Python programming", new DateTime(2024, 4, 10), new TimeSpan(10, 0, 0), new Address { Street = "123 Main St", City = "Rexburg", State = "Idaho", ZipCode = "83440" }, "Franck Sokora", 50);
        Reception reception = new Reception("Networking Reception", "Network with industry professionals", new DateTime(2024, 4, 15), new TimeSpan(18, 0, 0), new Address { Street = "456 Elm St", City = "Townville", State = "Countyville", ZipCode = "67890" }, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Picnic", "Enjoy a day outdoors with friends", new DateTime(2024, 4, 20), new TimeSpan(12, 0, 0), new Address { Street = "789 Oak St", City = "Salt lake city", State = "Utah", ZipCode = "60879" }, "Sunny skies");

        Console.WriteLine();
        // Print marketing messages for each event
        Console.WriteLine("Event Marketing Messages:");
        Console.WriteLine("=========================");
        Console.WriteLine("Lecture:");
        // Console.WriteLine(lecture.GetStandardDetails());
        // Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\nReception:");
        // Console.WriteLine(reception.GetStandardDetails());
        // Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\nOutdoor Gathering:");
        // Console.WriteLine(outdoorGathering.GetStandardDetails());
        // Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine(outdoorGathering.GetFullDetails());
    }
}
