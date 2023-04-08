
public class SwimmingPool : Activity
{
    private float _lapNumber = 0;

    public SwimmingPool()
    {
        _activityType = "Swimming";
        PromptMinutes();
    }

    public override void PromptOtherInformation()
    {
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
}
