using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What is one thing you learned today?",
        "What made you smile today?",
        "What challenge did you face today?",
        "Who helped you today, and how?",
        "What is one thing you hope to do tomorrow?"
    };
    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int i = _random.Next(0, _prompts.Count);
        return _prompts[i];
    }

}