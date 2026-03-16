using System;

public class entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}