
public class Reception : Event
{
    private string _electronicMail = "";

    public Reception(string type, string title, string description, string date, string time, string address, string eMail) : base(type, title, description, date, time, address)
    {
        _electronicMail = eMail;
    }

    public override string GetMessageFull()
    {
        return $"Title:       {_eventTitle}\nType:        {_eventType}\nDescription:\n             {_eventDescription}\n\nDate:        {_eventDate}\nTime:        {_eventTime}\nAddress: {_eventAddress}\nRepondez, s'il vous plait (RSVP) to:\n             {_electronicMail}\n";
    }
}
