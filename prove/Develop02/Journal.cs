using System.IO;

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
        Entry myEntry = new Entry(date, prompt, response);
        // myEntry._date = date;
        // myEntry._prompt = prompt;
        // myEntry._response = response;
        // myEntry.FormatEntryAsCSV();
        _entryList.Add(myEntry);
    }

    // This saves the current journal to a CSV file.
    public void SaveToCSV(string fileName)
    {
        if (_entryList.Count == 0)
        {
            Console.WriteLine("\nThere is nothing to save yet.  Please write an entry.");
        }
        else
        {
            string saveString = "";
            foreach (Entry entryItem in _entryList)
            {
                entryItem.FormatEntryAsCSV();
                saveString += entryItem._CSVString;
                // using (StreamWriter outputFile = new StreamWriter(fileName))
                // {
                //     // The "StreamWriter" object can write single lines.  There is no "File.WriteLine" method.
                //     outputFile.WriteLine(entryItem._CSVString);
                // }
            }
            File.WriteAllText(fileName, saveString);
            Console.WriteLine("\nEntries saved.");
        }
    }

    // This gets the saved journal from a CSV file.
    public void LoadFromCSV(string fileName) // public string[] LoadFromCSV(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("\nThe file doesn't exist yet.  Please save it first.");
        }
        else
        {
            string[] savedEntries = File.ReadAllLines(fileName);
            foreach (string line in savedEntries)
            {
                Entry loadingEntry = new Entry(null, null, null);
                loadingEntry.BuildEntryFromCSV(line);
                _entryList.Add(loadingEntry);
            }
            Console.WriteLine("\nEntries loaded.");
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
            Console.WriteLine($"\nThere is 1 entry.");
        }
        else
        {
            Console.WriteLine($"\nThere are {_entryList.Count} entries.");
        }
    }
}