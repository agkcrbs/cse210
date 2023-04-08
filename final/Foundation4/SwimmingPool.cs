
public class SwimmingPool : Activity
{
    private float _lapNumber = 0;

    public SwimmingPool()
    {
        _activityType = "Swimming";
        Console.Write("How many laps were swum? ");
        _lapNumber = float.Parse(Console.ReadLine());
    }

    public override float GetDistance()
    {
        return (float)(_lapNumber * 50 / 1000 * 0.62);
    }
    public override float GetSpeed()
    {
        return GetDistance() / _lengthInMinutes * 60;
    }

    // public override void GetSummary()
    // {
    //     Console.WriteLine(_dateString + " " + "Running" + " " + $"({_lengthInMinutes} min)- Distance: 0 miles, Speed: 0 mph, Pace: 0 min per mile");
    // }
}
