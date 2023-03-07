using System;

class Program
{
    static void Main(string[] arguments)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Apple Stacker";
        job1._company = "Fresh Market [Assc. Food Stores]";
        job1._startYear = 2021;
        job1._endYear = 2022;
        // job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Person Carrier";
        job2._company = "UTA [Utah Transit Authority]";
        job2._startYear = 2023;
        job2._endYear = 2023;
        // job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Steven";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        // Console.WriteLine(resume1); // This outputs "Resume".
        // Console.WriteLine(resume1._jobs[0]); // This outputs "Job".
        resume1.Display();
    }
}