using System;

class Program
{
    static void Main(string[] args)
    {
        reference ref1 = new reference("John", 3, 16);
        scripture scripture1 = new scripture(ref1, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (!scripture1.iscompletelyhidden())
        {
            Console.Clear();
            Console.WriteLine(scripture1.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words...");
            Console.ReadLine();
            scripture1.hiderandmwords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture1.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Press Enter to exit.");
        Console.ReadLine();
    }
}
