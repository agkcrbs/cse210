using System; // Why is this here...?

class Program
{
    static void Main(string[] arguments)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Assignment assign1 = new Assignment("Bill", "history");
        Console.WriteLine();
        Console.WriteLine(assign1.GetSummary());

        MathAssignment assign2 = new MathAssignment("Stewart", "math", "7.3", "8-19");
        Console.WriteLine();
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());

        WritingAssignment assign3 = new WritingAssignment("Herb", "political science", "Russian Dominion Over Crimea in the 18th-21st Centuries");
        Console.WriteLine();
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInformation());
        Console.WriteLine();
    }
}