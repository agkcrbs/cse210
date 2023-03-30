// Additions: I made a cuter spinner.  I shuffled the prompts.
using System;

class Program
{
    static void Main(string[] arguments)
    {
        // Console.WriteLine("Hello Develop04 World!");
        bool run = true;
        Spinner spinObject = new Spinner();
        string breathingDescription = "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.";
        string reflectingDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        while(run)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    BreathingActivity breathingObject = new BreathingActivity("Breathing", breathingDescription);
                    breathingObject.DisplayOpening();
                    breathingObject.AskTime();
                    breathingObject.Breathe(); // Unique.
                    breathingObject.DisplayClosing();
                    break;
                case "2":
                    ReflectingActivity reflectingObject = new ReflectingActivity("Reflecting", reflectingDescription);
                    reflectingObject.DisplayOpening();
                    reflectingObject.AskTime();
                    reflectingObject.Reflect(); // Unique.
                    reflectingObject.DisplayClosing();
                    break;
                case "3":
                    ListingActivity listingObject = new ListingActivity("Listing", listingDescription);
                    listingObject.DisplayOpening();
                    listingObject.AskTime();
                    listingObject.List(); // Unique.
                    listingObject.DisplayClosing();
                    break;
                case "4":
                    run = false;
                    break;
                default:
                    break;
            }
        }
    }
}
