using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What are you grateful for today?",
            "Describe a memorable moment from your day.",
            "What is something you learned recently?",
            "Write about a challenge you faced and how you overcame it.",
            "What are your goals for the next week?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}