class BreathingActivity : Activity
{
    private int _firstCountIn = 2;
    private int _firstCountOut = 3;
    private int _laterCountIn = 3;
    private int _laterCountOut = 4;

    public BreathingActivity(string activity, string description) : base(activity, description)
    {
    }

    public void Breathe()
    {
        int runs = 0;
        int countIn;
        int countOut;
        _countdown.StartHiddenTimer(_desiredTime);
        while (!_countdown.CheckHiddenTimerExpired())
        {
            if (runs == 0)
            {
                countIn = _firstCountIn;
                countOut = _firstCountOut;
            }
            else
            {
                countIn = _laterCountIn;
                countOut = _laterCountOut;
            }

            Console.Write("\nBreathe in...");
            _countdown.ShowTimer(countIn);
            Console.Write("\nNow breathe out...");
            _countdown.ShowTimer(countOut);
            Console.WriteLine();
            runs ++;
        }
    }
}
