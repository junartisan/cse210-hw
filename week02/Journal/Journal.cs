using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter output = new StreamWriter(file))
        {
            foreach (Entry entry in entries)
            {
                output.WriteLine($"{entry.Date}|{entry.Mood}|{entry.PromptText}|{entry.EntryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry.Date = parts[0];
            entry.Mood = parts[1];
            entry.PromptText = parts[2];
            entry.EntryText = parts[3];

            entries.Add(entry);
        }
    }

    public void SearchEntries(string keyword)
    {
        foreach (Entry entry in entries)
        {
            if (entry.EntryText.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                entry.Display();
            }
        }
    }
}