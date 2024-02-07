using System;

class Entry
{
    public DateTime Date { get; }
    public string Prompt { get; }
    public string Response { get; }

    public Entry(DateTime date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }
}
