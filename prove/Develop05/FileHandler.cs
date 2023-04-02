using System.IO;

public class FileHandler
{
    private string _fileName;
    private bool _mayOverwrite;

    public void SaveToFile(int points, List<string> saveList)
    {
        Console.Write("\nWhat is the file name for the goal file? ");
        _fileName = Console.ReadLine();
        if (File.Exists(_fileName))
        {
            Console.Write("Overwrite previous file (y/n)? ");
            if (Console.ReadLine().ToLower() == "y")
            {
                _mayOverwrite = true;
            }
        }
        else
        {
            _mayOverwrite = false;
        }
        if (_mayOverwrite)
        {
            using (StreamWriter savingObject = new StreamWriter(_fileName))
            {
                savingObject.WriteLine(points);
                foreach (string listString in saveList)
                {
                    savingObject.WriteLine(listString);
                }
            }
            Console.WriteLine("\nYour goals have been saved.");
        }
    }

    public string[] ReadFromFile(string separator)
    {
        Console.Write("What is the file name for the goal file? ");
        _fileName = Console.ReadLine();
        if (File.Exists(_fileName))
        {
            return File.ReadAllLines(_fileName);
        }
        else
        {
            return new string[] {};
        }
    }
}
