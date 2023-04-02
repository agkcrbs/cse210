
public class GoalChoiceMenu
{
    private string _menuDisplay = "\nThe types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create? ";

    public string UserInterface()
    {
        Console.Write(_menuDisplay);
        return Console.ReadLine();
    }
}
