
using System;

class Program
{
    static void Main(string[] argument6s)
    {
        // Console.WriteLine("Hello Foundation4 World!");

        Console.Clear();
        Console.WriteLine($"Exercise #1\n-----------");
        Running runningObject = new Running();
        runningObject.GetSummary();
        Console.Write("(Press enter.)");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"Exercise #2\n-----------");
        StationaryBicycle bicyclingObject = new StationaryBicycle();
        bicyclingObject.GetSummary();
        Console.Write("(Press enter.)");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"Exercise #3\n-----------");
        SwimmingPool swimmingObject = new SwimmingPool();
        swimmingObject.GetSummary();
        Console.Write("(Press enter.)");
        Console.ReadLine();
    }
}
