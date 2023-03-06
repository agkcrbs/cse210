using System;

class Program
{
    static void Main(string[] arguments)
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        // string name = PromptUserName();
        // int squaredNumber = SquareNumber(PromptUserNumber());
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
    }

    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        // string userName = Console.ReadLine();
        return Console.ReadLine();
    }

    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber (int numberToSquare)
    {
        return numberToSquare * numberToSquare;
    }

    // DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult (string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }

}

