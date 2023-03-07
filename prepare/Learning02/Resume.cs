// The sample solution includes "using System;" and has no constructor.

public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // Constructor of the class.
    public Resume()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        foreach (Job jobItem in _jobs)
        {
            jobItem.Display();
        }
    }
}
