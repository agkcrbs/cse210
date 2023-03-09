
class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _response = "";
    public string _CSVString;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"({_date}) - {_prompt}");
        Console.WriteLine("             " + _response);
    }

    public void FormatEntryAsCSV()
    {
        _CSVString = string.Format("{0}|{1}|{2}\n", _date, _prompt, _response);
    }

    public void BuildEntryFromCSV(string CSVString)
    {
        string[] splitStringList = CSVString.Split("|");
        if (splitStringList.Count() == 3)
        {
            _date = splitStringList[0];
            _prompt = splitStringList[1];
            _response = splitStringList[2];
        }
        else
        {
            Console.WriteLine("\nSomething is wrong with the CSV data.  Please check it and try again.");
        }
    }

}

