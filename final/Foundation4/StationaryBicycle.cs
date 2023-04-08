
public class StationaryBicycle : Activity
{
    private float _speed = 0;

    public StationaryBicycle()
    {
        _activityType = "Cycling";
        PromptMinutes();
    }

    public override void PromptOtherInformation()
    {
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
}
