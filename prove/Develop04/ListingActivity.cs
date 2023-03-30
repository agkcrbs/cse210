class ListingActivity : Activity
{
    private List<string> _promptList;

    public ListingActivity(string activity, string description) : base(activity, description)
    {
        _promptList = new List<string>
        {
            "Who are people that you appreciate?", 
            "What are personal strengths of yours?", 
            "Who are some people that you have helped this week?", 
            "When have you felt at peace this month?", 
            "Who are some of your personal role models?", 
        };

        _promptObject.FillPromptList(_promptList);
        _chosenPrompt = _promptObject.GetRandomPrompt();
    }

    public void List()
    {
        int number = 0;
        Console.WriteLine("\nList as many responses as you can to the following prompt:\n");
        // Select from a random set of prompts.
        Console.WriteLine($" --- {_chosenPrompt} ---");
        Console.WriteLine();
        Console.WriteLine("You may begin in: ");
        _countdown.ShowTimer(5);
        _countdown.StartHiddenTimer(_desiredTime);
        while (!_countdown.CheckHiddenTimerExpired())
        {
            Console.Write("> ");
            Console.ReadLine();
            number ++;
        }
        Console.WriteLine($"You listed {number} items!");
    }
}
