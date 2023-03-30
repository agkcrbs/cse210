class Countdown
{
    private DateTime _endTime;
    // The Thread.Sleep() method takes an integer as the 
    // number of milliseconds for the current "thread of 
    // execution" to sleep or pause.

    public void ShowTimer(int desiredTime)
    {
        for (int i = 0; i < desiredTime; desiredTime --)
        {
            Console.Write(desiredTime);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Watch for double digits.
        }
    }

    public void StartHiddenTimer(int desiredTime)
    {
        DateTime startTime = DateTime.Now;
        _endTime = startTime.AddSeconds(desiredTime);
    }

    public bool CheckHiddenTimerExpired()
    {
        if (DateTime.Now > _endTime)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
