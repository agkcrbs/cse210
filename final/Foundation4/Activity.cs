
public abstract class Activity
{
    protected int _lengthInMinutes = 0;
    protected string _dateString;
    protected string _activityType;

    public Activity()
    {
        _dateString = DateTime.Today.ToString("dd MMM yyyy");
    }

    public void PromptMinutes()
    {
        Console.WriteLine($"{GetActivityType()} Exercise \n------------------");
        Console.Write("How many minutes was the exercise? ");
        _lengthInMinutes = int.Parse(Console.ReadLine());
        PromptOtherInformation();
    }

    public abstract void PromptOtherInformation();
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public float GetPace()
    {
        return 60 / GetSpeed();
    }

    // public abstract string GetActivityType();

    public string GetActivityType()
    {
        return _activityType;
    }

    // public abstract void GetSummary();
    public void GetSummary()
    {
        Console.WriteLine($"{_dateString} - {_activityType} ({_lengthInMinutes} min) - Distance: {GetDistance().ToString("F1")} miles, Speed: {GetSpeed().ToString("F1")} mph, Pace: {GetPace().ToString("F1")} min per mile");
    }
}
