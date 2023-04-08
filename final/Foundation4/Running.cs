
public class Running : Activity
{
    private float _distance = 0;

    public Running()
    {
        _activityType = "Running";
        PromptMinutes();
    }

    public override void PromptOtherInformation()
    {
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
}
