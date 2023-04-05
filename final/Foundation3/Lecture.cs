
public class Lecture : Event
{
    private string _speakerName = "";
    private int _capacity = 0;

    public Lecture(string type, string title, string description, string date, string time, string address, string name, int capacity) : base(type, title, description, date, time, address)
    {
        _speakerName = name;
        _capacity = capacity;
    }

    public override string GetMessageFull()
    {
        return $"Title:       {_eventTitle}\nType:        {_eventType}\nSpeaker:     {_speakerName}\nDescription:\n             {_eventDescription}\nSeat limit:  {_capacity}\nDate:        {_eventDate}\nTime:        {_eventTime}\nAddress: {_eventAddress}";
    }
}
