
public class OutdoorGathering : Event
{
    private string _weatherForecast = "";

    public OutdoorGathering(string type, string title, string description, string date, string time, string address, string weather) : base(type, title, description, date, time, address)
    {
        _weatherForecast = weather;
    }

    public override string GetMessageFull()
    {
        return $"Title:       {_eventTitle}\nType:        {_eventType}\nDescription:\n             {_eventDescription}\n\nDate:        {_eventDate}\nTime:        {_eventTime}\nForecast:    {_weatherForecast}\nAddress: {_eventAddress}";
    }
}
