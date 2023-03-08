using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        DateTime currentTime = DateTime.Now;
        Console.WriteLine(currentTime.ToShortDateString());
        Console.WriteLine(currentTime);
    }
}