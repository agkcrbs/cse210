
public class EventMaker
{
    private int _goalChoice = 0;
    public int CreateEvent(List<Goal> goalList, int totalPoints)
    {
        if (goalList.Count > 0)
        {
            Console.Write("Which goal did you accomplish? ");
            _goalChoice = int.Parse(Console.ReadLine()) - 1;
            if (!(_goalChoice >= 0 && _goalChoice < goalList.Count))
            {
                Console.WriteLine("\nThat choice is invalid.");
                return totalPoints;
            }
            else if (goalList[_goalChoice].GetCompleted())
            {
                Console.WriteLine("\nThat goal has already been completed.");
                return totalPoints;
            }
            else
            {
                int points = goalList[_goalChoice].GetPoints();
                goalList[_goalChoice].SetCompleted();
                Console.WriteLine($"\nCongratulations!  You have earned {points} points!");
                totalPoints += points;
                if (goalList[_goalChoice].GetIsChecklist())
                {
                    int bonusPoints = goalList[_goalChoice].GetBonusPoints();
                    if (goalList[_goalChoice].GetCompleted())
                    {
                        Console.WriteLine($"You get a completion bonus of {bonusPoints} points!");
                        totalPoints += bonusPoints;
                    }
                }
                Console.WriteLine($"You now have {totalPoints} points.");
                goalList[_goalChoice].FormGoalString();
                return totalPoints;
            }
        }
        else
        {
            return totalPoints;
        }
    }
}

