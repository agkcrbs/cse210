
using System;

class Program
{
    static void Main(string[] argument6s)
    {
        // Console.WriteLine("Hello Foundation4 World!");

        string input = "1";
        while(input == "1" || input == "2")
        {
            Console.Clear();
            Console.Write("1. All activities\n2. Compare progress\n(Other key to quit)\n? ");
            switch(Console.ReadLine())
            {
                case "1":
                    List<Activity> exerciseList = new List<Activity>();

                    Console.Clear();
                    Running runningObject = new Running();
                    exerciseList.Add(runningObject);

                    Console.Clear();
                    StationaryBicycle bicyclingObject = new StationaryBicycle();
                    exerciseList.Add(bicyclingObject);

                    Console.Clear();
                    SwimmingPool swimmingObject = new SwimmingPool();
                    exerciseList.Add(swimmingObject);

                    Console.Clear();
                    Console.WriteLine("Activity Summary:");
                    foreach(Activity activityObject in exerciseList)
                    {
                        activityObject.GetSummary();
                    }
                    Console.Write("(Press enter.)");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Choose an exercise to compare:\n1. Running\n2. Bicycling\n3. Swimming\n? ");
                    bool progress = false;
                    switch(Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            Console.Write("[#1] ");
                            Running runningObject1 = new Running();
                            Console.Write("[#2] ");
                            Running runningObject2 = new Running();
                            Console.WriteLine("\nActivity Summary:");
                            runningObject1.GetSummary();
                            runningObject2.GetSummary();
                            Console.WriteLine();

                            float distanceUp = runningObject2.GetDistance() - runningObject1.GetDistance();
                            if (distanceUp > 0)
                            {
                                Console.WriteLine($"You increased your distance by {distanceUp} miles.");
                                progress = true;
                            }

                            float speedUp = runningObject2.GetSpeed() - runningObject1.GetSpeed();
                            if (speedUp > 0)
                            {
                                Console.WriteLine($"You increased your speed by {speedUp} miles per hour.");
                                progress = true;
                            }

                            float paceUp = runningObject2.GetPace() - runningObject1.GetPace();
                            if (paceUp < 0)
                            {
                                Console.WriteLine($"You improved your pace by {-paceUp} minutes per mile.");
                                progress = true;
                            }

                            if (progress == false)
                            {
                                Console.WriteLine("No progress yet.  Try again.");
                            }

                            break;
                        case "2":
                            Console.Clear();
                            Console.Write("[#1] ");
                            StationaryBicycle bicyclingObject1 = new StationaryBicycle();
                            Console.Write("[#2] ");
                            StationaryBicycle bicyclingObject2 = new StationaryBicycle();
                            Console.WriteLine("\nActivity Summary:");
                            bicyclingObject1.GetSummary();
                            bicyclingObject2.GetSummary();
                            Console.WriteLine();

                            distanceUp = bicyclingObject2.GetDistance() - bicyclingObject1.GetDistance();
                            if (distanceUp > 0)
                            {
                                Console.WriteLine($"You increased your distance by {distanceUp} miles.");
                                progress = true;
                            }

                            speedUp = bicyclingObject2.GetSpeed() - bicyclingObject1.GetSpeed();
                            if (speedUp > 0)
                            {
                                Console.WriteLine($"You increased your speed by {speedUp} miles per hour.");
                                progress = true;
                            }

                            paceUp = bicyclingObject2.GetPace() - bicyclingObject1.GetPace();
                            if (paceUp < 0)
                            {
                                Console.WriteLine($"You improved your pace by {-paceUp} minutes per mile.");
                                progress = true;
                            }

                            if (progress == false)
                            {
                                Console.WriteLine("No progress yet.  Try again.");
                            }
                            break;
                        case "3":
                            Console.Clear();
                            Console.Write("[#1] ");
                            SwimmingPool swimmingObject1 = new SwimmingPool();
                            Console.Write("[#2] ");
                            SwimmingPool swimmingObject2 = new SwimmingPool();
                            Console.WriteLine("\nActivity Summary:");
                            swimmingObject1.GetSummary();
                            swimmingObject2.GetSummary();
                            Console.WriteLine();

                            distanceUp = swimmingObject2.GetDistance() - swimmingObject1.GetDistance();
                            if (distanceUp > 0)
                            {
                                Console.WriteLine($"You increased your distance by {distanceUp} miles.");
                                progress = true;
                            }

                            speedUp = swimmingObject2.GetSpeed() - swimmingObject1.GetSpeed();
                            if (speedUp > 0)
                            {
                                Console.WriteLine($"You increased your speed by {speedUp} miles per hour.");
                                progress = true;
                            }

                            paceUp = swimmingObject2.GetPace() - swimmingObject1.GetPace();
                            if (paceUp < 0)
                            {
                                Console.WriteLine($"You improved your pace by {-paceUp} minutes per mile.");
                                progress = true;
                            }

                            if (progress == false)
                            {
                                Console.WriteLine("No progress yet.  Try again.");
                            }
                            break;
                        default:
                            break;
                    }
                    Console.Write("(Press enter.)");                            
                    Console.ReadLine();
                    break;
                default:
                    input = "3";
                    break;
            }
        }
    }
}
