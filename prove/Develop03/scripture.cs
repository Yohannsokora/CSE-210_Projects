public class Scripture
{
    public string Reference { get; set; }
    public string Text { get; set; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
    }
}
