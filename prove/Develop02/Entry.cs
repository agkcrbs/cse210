
class Entry
{
    public string _date, _prompt, _response, _CSVString;

    // public Entry(string date, string prompt, string response)
    // {
    // }

    public void DisplayEntry()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_response);
    }

    public void GetEntryAsCSV()
    {
        _CSVString = string.Format("{0}|{1}|{2}", _date, _prompt, _response);
    }

}

