using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private readonly Reference _reference;
    private string _text;
    private readonly List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = _text.Split().Select(word => new Word(word)).ToList();
    }

    public void HideRandomWord()
    {
        var visibleWords = _words.Where(word => !word.IsHidden).ToList();
        if (visibleWords.Count == 0) return;

        var random = new Random();
        var wordIndex = random.Next(0, visibleWords.Count);
        visibleWords[wordIndex].Hide();
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }

    public bool UserWantsToQuit()
    {
        return false; // Placeholder for actual user input handling
    }

    public string Display()
    {
        return $"{_reference.Display()} - {_words.Select(word => word.Display()).Aggregate((current, next) => $"{current} {next}")}";
    }
} 
