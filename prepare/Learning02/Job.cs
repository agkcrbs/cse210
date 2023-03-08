// The sample solution includes "using System;" and has no constructor.

public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // A special method, called a constructor that is invoked using the
    // new keyword followed by the class name and parentheses.
    public Job()
    {
    }

    // A method that displays the information about the Job in the
    // format: Job Title (Company) StartYear-EndYear; for example,
    // "Software Engineer (Microsoft) 2019-2022"
    public void Display()
    {
        Console.WriteLine($"      {_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
