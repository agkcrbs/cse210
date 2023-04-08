
public class StationaryBicycle : Activity
{
    private float _speed = 0;

    public StationaryBicycle()
    {
        _activityType = "Cycling";
        Console.Write("What was the average speed (mph)? ");
        _speed = float.Parse(Console.ReadLine());
    }

    public override float GetDistance()
    {
        return (_speed / 60) * _lengthInMinutes;
    }
    public override float GetSpeed()
    {
        return _speed;
    }

    // public override void GetSummary()
    // {
    //     Console.WriteLine(_dateString + " " + "Running" + " " + $"({_lengthInMinutes} min)- Distance: 0 miles, Speed: 0 mph, Pace: 0 min per mile");
    // }
}
