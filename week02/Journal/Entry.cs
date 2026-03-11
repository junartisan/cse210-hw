using System;

public class Entry
{
    public string Date;
    public string PromptText;
    public string EntryText;
    public string Mood;
    // Display the info:
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Mood: {Mood}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}");
        Console.WriteLine("----------------------------");
    }
}