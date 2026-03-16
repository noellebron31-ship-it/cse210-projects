using System;

class Program
{
    static void Main(string[] args)
    {
        journal journal = new journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to file");
            Console.WriteLine("4. Load entries from file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your entry: ");
                    string entryText = Console.ReadLine();

                    entry newEntry = new entry
                    {
                        _date = DateTime.Now.ToString("yyyy-MM-dd"),
                        _promptText = prompt,
                        _entryText = entryText
                    };
                    journal.addEntry(newEntry);
                    break;
                case 2:
                    journal.displayEntries();
                    break;
                case 3:
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.saveToFile(saveFilename);
                    break;
                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.loadFromFile(loadFilename);
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}