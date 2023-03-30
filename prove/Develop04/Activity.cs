class Activity
{
    protected string _activityType;
    protected string _activityDescription;
    protected int _desiredTime;
    protected string _chosenPrompt;
    protected Spinner _spinObject = new Spinner();
    protected Countdown _countdown = new Countdown();
    protected PromptSelector _promptObject = new PromptSelector();

    public Activity(string activity, string description)
    {
        _activityType = activity;
        _activityDescription = description;
    }

    public void DisplayOpening()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityType} Activity.\n");
        Console.WriteLine($"{_activityDescription}\n");
    }

    public void AskTime()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? (Try 60 or fewer.) ");
        try
        {
            _desiredTime = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Whoops!");
            Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine("Get ready...");
        _spinObject.ShowSpinner();
    }

    public void DisplayClosing()
    {
        Console.WriteLine("\nWell done!");
        _spinObject.ShowSpinner();
        Console.WriteLine($"\nYou have completed another {_desiredTime} seconds of the {_activityType} Activity.");
        _spinObject.ShowSpinner();
        _spinObject.ShowSpinner();
    }
}
