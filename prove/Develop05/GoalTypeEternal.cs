
public class GoalTypeEternal : Goal
{
    public override void SetCompleted()
    {
        _completedBoolean = false;
    }

    public override void FormSaveString()
    {
        _saveString = "EternalGoal" + _separator + _completedBoolean + _separator + _goalName + _separator + _goalDescription + _separator + _goalPoints;
    }
}
