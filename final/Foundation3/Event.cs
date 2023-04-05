
public class Event
{
    protected string _eventTitle = "";
    protected string _eventDescription = "";
    protected string _eventDate = "";
    protected string _eventTime = "";
    protected string _eventAddress = "";
    protected Address _eventAddressObject;
    protected string _eventType = "";

    public Event(string type, string title, string description, string date, string time, string address)
    {
        _eventType = type;
        _eventTitle = title;
        _eventDescription = description;
        _eventDate = date;
        _eventTime = time;
        _eventAddressObject = new Address(address);
        _eventAddress = _eventAddressObject.GetAddress();
    }

    public string GetMessageStandard()
    {
        return $"Title:       {_eventTitle}\nDescription:\n             {_eventDescription}\n\nDate:        {_eventDate}\nTime:        {_eventTime}\nAddress: {_eventAddress}";
    }

    public virtual string GetMessageFull()
    {
        return $"Title:       {_eventTitle}\nType:        {_eventType}\nDescription:\n             {_eventDescription}\n\nDate:        {_eventDate}\nTime:        {_eventTime}\nAddress: {_eventAddress}";
    }

    public string GetMessageShort()
    {
        return $"Type:  {_eventType}\nTitle: {_eventTitle}\nDate:  {_eventDate}";
    }

    public string GetEventType()
    {
        return _eventType;
    }
}
