
public class GoalTypeSimple : Goal
{
    public override void FormSaveString()
    {
        _saveString = "SimpleGoal" + _separator + _completedBoolean + _separator + _goalName + _separator + _goalDescription + _separator + _goalPoints;
    }
}
