
public class Display
{
    public void DisplayMessages(Event eventObject)
    {
        Console.Clear();
        Console.WriteLine($"[{eventObject.GetEventType()} example]\n----------------------\nStandard message (1/3)\n----------------------");
        Console.WriteLine(eventObject.GetMessageStandard() + "\n(Press enter.) ");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"[{eventObject.GetEventType()} example]\n------------------\nFull message (2/3)\n------------------");
        Console.WriteLine(eventObject.GetMessageFull() + "\n(Press enter.) ");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"[{eventObject.GetEventType()} example]\n-------------------\nShort message (3/3)\n-------------------");
        Console.WriteLine(eventObject.GetMessageShort() + "\n\n(Press enter.) ");
        Console.ReadLine();
    }
}
