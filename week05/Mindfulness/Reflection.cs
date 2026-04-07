public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectingActivity() : base("Reflecting Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience.") 
    {}

    public override void Run()
    {
        DisplayStartingMessage();
        
        Random random = new Random();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {_prompts[random.Next(_prompts.Count)]} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {_questions[random.Next(_questions.Count)]} ");
            ShowSpinner(10); // Pause for reflection
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}