using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts = new List<string>()
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "Who helped you today?",
        "What made you smile today?",
        "What challenge did you overcome today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}