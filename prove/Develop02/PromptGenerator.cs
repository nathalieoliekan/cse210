public class PromptGenerator
{
    // public List<string> _prompts:
    public List<string> _prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?  ", 
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",  
        "Who should I have helped that I did not? ",
        "What lesson did I learn today? ",
        "What is a mistake I made today and why? ",
        "What progress did I make with my personal goals? "
        };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int length = _prompts.Count;
        int index = randomGenerator.Next(1, length);
        string prompt = _prompts[index];

        return prompt;  
    }

}