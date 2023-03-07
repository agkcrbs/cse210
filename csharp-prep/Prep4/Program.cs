// using System; // Why is this not needed?
// using System.Collections.Generic; // Why is this not needed?

class Program
{
    static void Main(string[] arguments)
    {
        // Console.WriteLine("Hello Prep4 World!");

        // Build the list.
        List<int> numberList = new List<int>();
        Console.WriteLine("Enter a list of numbers, typing 0 when finished.");
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        numberList.Add(number);
        int largestNumber = number;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numberList.Add(number);
                if (number > largestNumber)
                {
                    largestNumber = number;
                }
            }
        }

        // Figure the sum.  Find the smallest positive number.
        int sum = 0;
        bool hasPositive = false;
        int smallestPositive = 0;
        foreach (int member in numberList)
        {
            sum += member;
            if (member > 0 && hasPositive == false)
            {
                hasPositive = true;
                smallestPositive = member;
            }
            if (member > 0 && member < smallestPositive)
            {
                smallestPositive = member;
            }
        }

        // Figure the average.
        decimal average; // This must start as a decimal, float, or double.
        if (numberList.Count == 0)
        {
            average = 0;
        }
        else
        {
            average = (decimal)sum / numberList.Count; // Otherwise, int / int returns int.
        }

        // Output results.
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        if (hasPositive == true)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Order the list.
        List<int> orderedNumberList = new List<int>();

        /* Also, to duplicate the list:
        using System.Linq;
        List<int> orderedNumberList = numberList.Select(x => x).ToList();
        */

        foreach (int member in numberList)
        {
            orderedNumberList.Add(member);
        }
        orderedNumberList.Sort();
        // Descending: orderedNumberList.Sort((x, y) => y.CompareTo(x));

        /* Also, to sort the list deeply (with duplication):
        using System.Linq;
        List<int> orderedNumberList = numberList.OrderBy
        */

        // Output the list.
        Console.WriteLine("The sorted list is:");
        foreach (int member in orderedNumberList)
        {
            Console.WriteLine(member);
        }
    }
}