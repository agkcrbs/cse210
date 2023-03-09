/* Exceeding requirements:
What I have added to the core requirements are a method that counts the 
number of entries and several situational troubleshooting messages.*/

using System;

class Program
{
    static void Main(string[] arguments)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Journal myJournal = new Journal();
        PromptGenerator myPrompt = new PromptGenerator();
        string fileName = "journals.CSV";
        string menuUserInput = "0";
        List<string> menuList = new List<string>
        {
            "\nPlease select one of the following choices:\n", 
            "1. Write an entry\n", 
            "2. Display entries\n", 
            "3. Load entries from file (overwrite current entries)\n", 
            "4. Save entries to file (overwrite file)\n", 
            "5. Quit\n", 
            "What would you like to do? ", 
        };

        Console.WriteLine("\nWelcome to the journal prompter.");

        while (menuUserInput != "5")
        {
            foreach (string menuItem in menuList)
            {
                Console.Write(menuItem);
            }
            menuUserInput = Console.ReadLine();
            switch (menuUserInput)
            {
                case "1":
                    string prompt = myPrompt.GetRandomPrompt();
                    Console.WriteLine("\n" + prompt);
                    string response = Console.ReadLine();
                    myJournal.CreateJournalEntry(GetDate(), prompt, response);
                    break;
                case "2":
                    myJournal.DisplayJournalEntries();
                    break;
                case "3":
                    myJournal._entryList.Clear();
                    myJournal.LoadFromCSV(fileName);
                    break;
                case "4":
                    myJournal.SaveToCSV(fileName);
                    break;
                case "5":
                    break;
                default:
                    break;
            }
        }

    }

    static string GetDate()
    {
        DateTime currentTime = DateTime.Now;
        return currentTime.ToShortDateString();
    }
}