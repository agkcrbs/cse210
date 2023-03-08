
class Journal
{
    public List<Entry> _entryList = new List<Entry>();

    // public Journal()
    // {
    // }

    public void DisplayJournalEntries()
    {
        DisplayEntryCount();
        foreach (Entry entryItem in _entryList)
        {
            entryItem.DisplayEntry();
        }
    }

    // This builds a journal entry object and adds it to the current journal.
    public void CreateJournalEntry(string date, string prompt, string response)
    {
        Entry myEntry = new Entry();
        myEntry._date = date;
        myEntry._prompt = prompt;
        myEntry._response = response;
        myEntry.GetEntryAsCSV();
        _entryList.Add(myEntry);
    }

    // This saves the current journal to a CSV file.
    public void SaveToCSV(string fileName, string[] data)
    {
        File.WriteAllLines(fileName, data);
    }

    // This gets the saved journal from a CSV file.
    public void LoadFromCSV(string fileName) // public string[] LoadFromCSV(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("The file doesn't exist yet.  Write to it first.");
        }
        else
        {
            string[] fileData = File.ReadAllLines(fileName);
            foreach (string line in fileData)
            {
                Console.WriteLine($"Line {line}");
            }
        }
    }

    // public void EnsureFileExists(string fileName)
    // {
    //     if (!File.Exists(fileName))
    //     {
    //         string data = "";
    //         File.AppendAllText(fileName, data);
    //     }
    // }

    public void DisplayEntryCount()
    {
        if (_entryList.Count == 1)
        {
            Console.WriteLine($"There is 1 entry.");
        }
        else
        {
            Console.WriteLine($"There are {_entryList.Count} entries.");
        }
    }
}