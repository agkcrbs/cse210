
public class ListHandler
{
    private List<Goal> _currentList = new List<Goal>();
    private List<string> _saveStringList = new List<string>();

    public void ClearList()
    {
        _currentList.Clear();
    }

    public void AddToList(Goal goal)
    {
        _currentList.Add(goal);
    }

    public List<Goal> GetGoalList()
    {
        return _currentList;
    }

    public void FormStringList()
    {
        _saveStringList.Clear();
        foreach (Goal goal in _currentList)
        {
            goal.FormSaveString();
            _saveStringList.Add(goal.GetSaveString());
        }
    }

    public List<string> GetStringList()
    {
        return _saveStringList;
    }

    public void DisplayList(string longShort)
    {
        if (_currentList.Count > 0)
        {
            Console.WriteLine("\nThe goals are:");
            if (longShort == "long")
            {
                foreach (Goal goal in _currentList)
                {
                    string indexString = (_currentList.IndexOf(goal) + 1).ToString();
                    Console.WriteLine(indexString + goal.GetGoalString());
                }
            }
            else
            {
                foreach (Goal goal in _currentList)
                {
                    string indexString = (_currentList.IndexOf(goal) + 1).ToString();
                    Console.WriteLine(indexString + ". " + goal.GetGoalName());
                }
            }
        }
        else
        {
            Console.WriteLine("\nThere are no goals available to list or remove.");
        }
    }

    public void RemoveGoals()
    {
        if (_currentList.Count > 0)
        {
            Console.Write("\nWill you remove any goals (y/n)? ");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.Write("Choose a goal number to remove: ");
                int removeChoice = int.Parse(Console.ReadLine());
                if (removeChoice > 0 && removeChoice <= _currentList.Count)
                {
                    _currentList.RemoveAt(removeChoice - 1);
                    Console.WriteLine("The goal was removed.");
                }
            }
        }
    }
}
