
public abstract class Activity
{
    protected int _lengthInMinutes = 0;
    protected string _dateString;
    protected string _activityType;

    public Activity()
    {
        _dateString = DateTime.Today.ToString("dd MMM yyyy");
        Console.Write("How many minutes was the exercise? ");
        _lengthInMinutes = int.Parse(Console.ReadLine());
    }

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
        Console.WriteLine(_dateString + $" {_activityType} " + $"({_lengthInMinutes} min)- Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
}
