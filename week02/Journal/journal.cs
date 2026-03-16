using System;
using System.Collections.Generic;
using System.IO;

public class journal
{
    private List<entry> _entries = new List<entry>();

    public void addEntry(entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void displayEntries()
    {
        foreach (var entry in _entries)
        {
            entry.display();
        }
    }

    public void saveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"Date: {entry._date}");
                writer.WriteLine($"Prompt: {entry._promptText}");
                writer.WriteLine($"Entry: {entry._entryText}");
                writer.WriteLine();
            }
        }
    }

    public void loadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Date: "))
                    {
                        entry newEntry = new entry();
                        newEntry._date = line.Substring(6);
                        newEntry._promptText = reader.ReadLine().Substring(8);
                        newEntry._entryText = reader.ReadLine().Substring(7);
                        _entries.Add(newEntry);
                        reader.ReadLine(); // Skip empty line
                    }
                }
            }
        }
    }
}