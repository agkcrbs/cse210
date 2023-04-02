/* Additions:
I checked for existing files and warned for overwriting.
I added various confirmation messages.
I made a goal-removal option.*/

using System;

class Program
{
    static void Main(string[] arguments)
    {
        // Console.WriteLine("Hello Develop05 World!");
        Console.Clear();
        string input = "";
        int points = 0;
        string separator = "|||";
        // bool alreadyLoaded = false;
        var goalMenuObject = new GoalChoiceMenu();
        var listingObject = new ListHandler();
        var readWriteObject = new FileHandler();
        var eventObject = new EventMaker();
        while (input != "6")
        {
            Console.WriteLine($"\nYou have {points} points.\n");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List/Remove Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    switch (goalMenuObject.UserInterface())
                    {
                        case "1":
                            var newSimpleGoal = new GoalTypeSimple();
                            newSimpleGoal.PromptAddGoal(newSimpleGoal, listingObject);
                            newSimpleGoal.SetSeparator(separator);
                            break;
                        case "2":
                            var newEternalGoal = new GoalTypeEternal();
                            newEternalGoal.PromptAddGoal(newEternalGoal, listingObject);
                            newEternalGoal.SetSeparator(separator);
                            break;
                        case "3":
                            var newChecklistGoal = new GoalTypeChecklist();
                            newChecklistGoal.PromptAddGoal(newChecklistGoal, listingObject);
                            newChecklistGoal.SetSeparator(separator);
                            break;
                        default:
                            break;
                    }
                    break;
                case "2":
                    listingObject.DisplayList("long");
                    listingObject.RemoveGoals();
                    break;
                case "3":
                    listingObject.FormStringList();
                    if (listingObject.GetStringList().Count > 0)
                    {
                        readWriteObject.SaveToFile(points, listingObject.GetStringList());
                    }
                    else
                    {
                        Console.WriteLine("\nThere are no goals ready to save.");
                    }
                    break;
                case "4":
                    Console.Write("\nWarning: loading erases current unsaved goals and points.  Continue loading (y/n)? ");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        listingObject.ClearList();
                        string[] allLinesArray = readWriteObject.ReadFromFile(separator);
                        if (allLinesArray.Length > 0)
                        {
                            points = int.Parse(allLinesArray[0]);
                            for (int i = 1; i < allLinesArray.Length; i ++)
                            {
                                string[] goalStringArray = allLinesArray[i].Split(separator); // Add .ToList() to make arrays lists.
                                // listingObject.ReconstituteSavedGoal(goalStringArray, separator);

                                switch (goalStringArray[0])
                                {
                                    case "SimpleGoal":
                                        GoalTypeSimple loadedSimpleGoal = new GoalTypeSimple();
                                        loadedSimpleGoal.LoadValues(goalStringArray[1], goalStringArray[2], goalStringArray[3], goalStringArray[4]);
                                        loadedSimpleGoal.SetSeparator(separator);
                                        listingObject.AddToList(loadedSimpleGoal);
                                        break;
                                    case "EternalGoal":
                                        GoalTypeEternal loadedEternalGoal = new GoalTypeEternal();
                                        loadedEternalGoal.LoadValues(goalStringArray[1], goalStringArray[2], goalStringArray[3], goalStringArray[4]);
                                        loadedEternalGoal.SetSeparator(separator);
                                        listingObject.AddToList(loadedEternalGoal);
                                        break;
                                    case "ChecklistGoal":
                                        GoalTypeChecklist loadedChecklistGoal = new GoalTypeChecklist();
                                        loadedChecklistGoal.LoadValues(goalStringArray[1], goalStringArray[2], goalStringArray[3], goalStringArray[4], goalStringArray[5], goalStringArray[6], goalStringArray[7]);
                                        loadedChecklistGoal.SetSeparator(separator);
                                        listingObject.AddToList(loadedChecklistGoal);
                                        break;
                                    default:
                                        break;
                                }
                            }
                            // alreadyLoaded = true;
                            Console.WriteLine("\nThe goals have been loaded.");
                        }
                        else
                        {
                            Console.WriteLine("\nThat file is not found, or is empty.");
                        }
                    }
                    break;
                case "5":
                    listingObject.DisplayList("short");
                    points = eventObject.CreateEvent(listingObject.GetGoalList(), points);
                    break;
                default:
                    break;
            }
        }
    }
}
