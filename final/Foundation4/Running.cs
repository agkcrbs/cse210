
public class Running : Activity
{
    private float _distance = 0;

    public Running()
    {
        _activityType = "Running";
        Console.Write("How many miles were run? ");
        _distance = float.Parse(Console.ReadLine());
    }

    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        return GetDistance() / _lengthInMinutes * 60;
    }

    // public override string GetActivityType()
    // {
    //     return _activityType;
    // }

    // public override void GetSummary()
    // {
    //     Console.WriteLine(_dateString + " " + "Running" + " " + $"({_lengthInMinutes} min)- Distance: 0 miles, Speed: 0 mph, Pace: 0 min per mile");
    // }
}
