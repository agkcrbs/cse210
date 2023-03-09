
class PromptGenerator
{
    public List<string> _promptList = new List<string>
    {
        "Where did I go today?", 
        "Whom do I remember talking with today?", 
        "What memorable things happened today?", 
        "Did anything especially fortunate happen today?", 
        "What was difficult about this day?", 
        "What choices might have been improved upon this day?", 
    };
    public Random randomInstance = new Random();

    // public PromptGenerator()
    // {
    // }

    public string GetRandomPrompt()
    {
        int randomPromptNumber = randomInstance.Next(0, _promptList.Count);
        return _promptList[randomPromptNumber];
    }
}
