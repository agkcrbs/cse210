class ReflectingActivity : Activity
{
    private List<string> _promptList;
    private List<string> _questionList;
    private List<string> _randomizedQuestionList;

    public ReflectingActivity(string activity, string description) : base(activity, description)
    {
        _promptList = new List<string>
        {
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.", 
            "Think of a time when you helped someone in need.", 
            "Think of a time when you did something truly selfless.", 
        };

        _promptObject.FillPromptList(_promptList);
        _chosenPrompt = _promptObject.GetRandomPrompt();

        _questionList = new List<string>
        {
            "Why was this experience meaningful to you?", 
            "Have you ever done anything like this before?", 
            "How did the event happen?", 
            "How did you feel when it was over?", 
            "What made this time different than other times when you were not as successful?", 
            "What did you enjoy about this experience?", 
            "What could you learn from this experience that applies to other situations?", 
            "What did you learn about yourself through this experience?", 
            "How can you keep this experience in mind in the future?", 
        };

        _promptObject.FillPromptList(_questionList);
        _randomizedQuestionList = _promptObject.GetRandomizedPromptList();
    }

    public void Reflect()
    {
        Console.WriteLine("\nConsider the following prompt:\n");
        // Select from a random set of prompts.
        Console.WriteLine($" --- {_chosenPrompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        _countdown.ShowTimer(5);
        Console.Clear();
        _countdown.StartHiddenTimer(_desiredTime);
        int index = 0;
        while (!_countdown.CheckHiddenTimerExpired())
        {
            Console.Write($"> {_randomizedQuestionList[index]} ");
            for (int j = 0; j < 4; j ++)
            {
                _spinObject.ShowSpinner();
            }
            Console.WriteLine();
            if (index == _randomizedQuestionList.Count)
            {
                index = 0;
            }
            else
            {
                index ++;
            }
        }
    }
}
