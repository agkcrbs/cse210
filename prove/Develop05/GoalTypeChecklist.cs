
public class GoalTypeChecklist : Goal
{
    private string _goalToAccomplishPrompt = "How many times must this goal be accomplished for a bonus? ";
    private int _goalToAccomplish = 0;
    private int _goalAccomplished = 0;
    private string _goalBonusPrompt = "What is the point bonus for completing the goal? ";
    private int _goalBonus = 0;
    private new bool _isChecklist = true;

    public override int GetBonusPoints()
    {
        return _goalBonus;
    }

    public override bool GetIsChecklist()
    {
        return _isChecklist;
    }

    public override void SetCompleted()
    {
        if (_goalAccomplished < _goalToAccomplish - 1)
        {
            _completedBoolean = false;
        }
        else if (_goalAccomplished < _goalToAccomplish)
        {
            _completedBoolean = true;
        }
        _goalAccomplished ++;
    }

    public override void PromptAddGoal(Goal goal, ListHandler lister)
    {
        Console.Write(_goalNamePrompt);
        _goalName = Console.ReadLine();
        Console.Write(_goalDescriptionPrompt);
        _goalDescription = Console.ReadLine();
        Console.Write(_goalPointsPrompt);
        _goalPoints = int.Parse(Console.ReadLine());

        Console.Write(_goalToAccomplishPrompt);
        _goalToAccomplish = int.Parse(Console.ReadLine());
        Console.Write(_goalBonusPrompt);
        _goalBonus = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGoal logged.");
        lister.AddToList(goal);
        goal.FormGoalString();
    }

    public override void FormSaveString()
    {
        _saveString = "ChecklistGoal" + _separator + _completedBoolean + _separator + _goalName + _separator + _goalDescription + _separator + _goalPoints + _separator + _goalBonus + _separator + _goalToAccomplish + _separator + _goalAccomplished;
    }

    public override void FormGoalString()
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
        _goalString = ". [" + complete + "] " + _goalName + " (" + _goalDescription + ") -- Currently completed: " + _goalAccomplished + "/" + _goalToAccomplish;
    }

    public void LoadValues(string stringCompletedBoolean, string goalName, string goalDescription, string stringGoalPoints, string stringGoalBonus, string stringGoalToAccomplish, string stringGoalAccomplished)
    {
        _completedBoolean = bool.Parse(stringCompletedBoolean);
        _goalName = goalName;
        _goalDescription = goalDescription;
        FormGoalString();
        _goalPoints = int.Parse(stringGoalPoints);
        _goalBonus = int.Parse(stringGoalBonus);
        _goalToAccomplish = int.Parse(stringGoalToAccomplish);
        _goalAccomplished = int.Parse(stringGoalAccomplished);
    }
}
