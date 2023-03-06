using System;

class Program
{
    static void Main(string[] arguments)
    {
        // This is Preparation 2
        // Console.WriteLine("Hello Prep2 World!");
        string percent = "101";
        while (int.Parse(percent) < 0 || int.Parse(percent) > 100)
            {
                Console.Write("What is the grade percentage? ");
                percent = Console.ReadLine();
            }
        int grade = int.Parse(percent);
        string letterGrade = "";
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (grade >= 60 && grade <= 93)
        {
            int percentRemainder = grade % 10;
            if (percentRemainder == 0 || percentRemainder == 1 || percentRemainder == 2)
            {
                letterGrade += "-";
            }
            else if (percentRemainder == 7 || percentRemainder == 8 || percentRemainder == 9)
            {
                letterGrade += "+";
            }
        }
        Console.WriteLine($"\nThe letter grade is: {letterGrade}");
        if (grade >= 70) {
            Console.WriteLine("You passed the course.");
        }
        else
        {
            Console.WriteLine("To get credit, you will need to take the course again.");
        }
    }
}
