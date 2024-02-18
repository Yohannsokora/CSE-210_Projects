using System;

public static class HideWords
{
    public static void HideRandomWord(Scripture scripture)
    {
        var words = scripture.Text.Split();
        var random = new Random();
        var wordIndex = random.Next(0, words.Length);
        var wordToHide = words[wordIndex];
        words[wordIndex] = new string('_', wordToHide.Length);
        scripture.Text = string.Join(" ", words);
    }
}
