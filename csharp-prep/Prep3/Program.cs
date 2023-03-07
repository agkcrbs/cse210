using System;

class Program
{
    static void Main(string[] arguments)
    {
        // Console.WriteLine("Hello Prep3 World!");
        string keepGuessing = "yes";
        int count = 0;
        while (keepGuessing.ToLower() == "y" || keepGuessing.ToLower() == "yes")
        {
            int guessNumber = 0;
            Console.Write("Choose a lower limit: ");
            int lower = int.Parse(Console.ReadLine());
            Console.Write("Choose an upper limit: ");
            int upper = int.Parse(Console.ReadLine());
            Random randomObject = new Random();
            int number = randomObject.Next(lower, upper + 1);
            int guess = -12345;
            Console.Write("Try to guess the number: ");
            while (guess != number)
            {
                guessNumber++;
                guess = int.Parse(Console.ReadLine());
                if (guess < number) {
                    Console.Write("Guess higher: ");
                }
                else if (guess > number)
                {
                    Console.Write("Guess lower: ");
                }
                else {
                    if (guessNumber == 1) {
                        Console.WriteLine($"You guessed it in {guessNumber} try!");
                    } else {
                        Console.WriteLine($"You guessed it in {guessNumber} tries.");
                    }
                }
            }
            count++;
            if (count == 1) {
                Console.Write($"You've had {count} round.  Try again (Y/N)? ");
            } else {
                Console.Write($"You've had {count} rounds.  Try again (Y/N)? ");
            }
            keepGuessing = Console.ReadLine();
        }
    }
}
