using System;

class Program
{
    static void Main(string[] arguments)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Journal myJournal = new Journal();
        PromptGenerator myPrompt = new PromptGenerator();

        DateTime currentTime = DateTime.Now;
        string date = currentTime.ToShortDateString();

        string menuUserInput = "0";
        List<string> menuList = new List<string>
        {
            "Please select one of the following choices:\n", 
            "1. Write\n", 
            "2. Display\n", 
            "3. Load\n", 
            "4. Save\n", 
            "5. Quit\n", 
            "What would you like to do? "
        };


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
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    myJournal.CreateJournalEntry(date, prompt, response);
                    break;
                case "2":
                    myJournal.DisplayJournalEntries();
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    break;
            }
        }

    }
}