
public abstract class Goal
{
    protected string _goalNamePrompt = "\nWhat is the name of your goal? ";
    protected string _goalName = "";
    protected string _goalDescriptionPrompt = "What is a short description of the goal? ";
    protected string _goalDescription = "";
    protected string _goalPointsPrompt = "How many points is the goal worth? ";
    protected int _goalPoints = 0;

    protected bool _completedBoolean = false;
    protected string _goalString = "";
    protected string _saveString = "";
    protected string _separator;

    protected bool _isChecklist = false;

    public virtual bool GetIsChecklist()
    {
        return _isChecklist;
    }

    public virtual int GetBonusPoints()
    {
        return 0;
    }

    public virtual void PromptAddGoal(Goal goal, ListHandler lister)
    {
        Console.Write(_goalNamePrompt);
        _goalName = Console.ReadLine();
        Console.Write(_goalDescriptionPrompt);
        _goalDescription = Console.ReadLine();
        Console.Write(_goalPointsPrompt);
        _goalPoints = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGoal logged.");
        lister.AddToList(goal);
        goal.FormGoalString();
        goal.FormSaveString();
    }

    public virtual void SetCompleted()
    {
        _completedBoolean = true;
    }

    public bool GetCompleted()
    {
        return _completedBoolean;
    }

    public abstract void FormSaveString();

    public string GetSaveString()
    {
        return _saveString;
    }

    public virtual void FormGoalString()
    {
        string complete;
        if (_completedBoolean)
        {
            complete = "X";
        }
        else
        {
            complete = " ";
        }
        _goalString = ". [" + complete + "] " + _goalName + " (" + _goalDescription + ")";
    }

    public string GetGoalString()
    {
        return _goalString;
    }

    public void SetSeparator(string separator)
    {
        _separator = separator;
    }

    public string GetSeparator()
    {
        return _separator;
    }

    public virtual void LoadValues(string stringCompletedBoolean, string goalName, string goalDescription, string stringGoalPoints)
    {
        _completedBoolean = bool.Parse(stringCompletedBoolean);
        _goalName = goalName;
        _goalDescription = goalDescription;
        FormGoalString();
        _goalPoints = int.Parse(stringGoalPoints);
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public int GetPoints()
    {
        return _goalPoints;
    }
}
