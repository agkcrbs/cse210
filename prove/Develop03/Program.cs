using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] arguments)
    {
        // Console.WriteLine("Hello Develop03 World!");
        // To check the list:
        // List<string> textList = exampleDictionary["first"].Split(new[] { ' ' }).ToList(); // List<string> textList = exampleDictionary["first"].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        // Console.WriteLine(string.Join(", ", textList));

        string hintString = "on/OFF";
        bool hintBool = false;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Input your own scripture");
            Console.WriteLine("2. Use a random pre-loaded scripture");
            Console.WriteLine("3. Change hint mode: " + hintString);
            Console.WriteLine("(Type \"quit\" to exit)");
            string input = Console.ReadLine();
            // Make a scripture-selecting object in case of random selection.
            ScriptureFetcher scriptureFetchingObject = new ScriptureFetcher();

            if (input == "quit")
            {
                break;
            }

            if (input == "3")
            {
                if (hintString == "on/OFF")
                {
                    hintString = "ON/off";
                    hintBool = true;
                }
                else
                {
                    hintString = "on/OFF";
                    hintBool = false;
                }
            }

            if (input == "1")
            {
                Console.Clear();
                Console.WriteLine("Enter the reference: ");
                string userReference = Console.ReadLine();
                Console.WriteLine("Enter the scripture text: ");
                string userText = Console.ReadLine();
                // Make a scripture-holding object.
                Scripture scriptureObjectToDisplay = new Scripture(userReference, userText, hintBool);
                Console.Clear();
                Console.WriteLine(scriptureObjectToDisplay.ReturnReference());
                Console.WriteLine(scriptureObjectToDisplay.ReturnTextString());
                Console.WriteLine("\n(Type \"quit\" for the main menu.)");
                input = Console.ReadLine();

                while (true)
                {
                    if (input == "quit")
                    {
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine(scriptureObjectToDisplay.ReturnReference());
                    (string, bool) blankedTextNoBlanks = scriptureObjectToDisplay.ReturnBlankedText();
                    Console.WriteLine(blankedTextNoBlanks.Item1);
                    if (!blankedTextNoBlanks.Item2)
                    {
                        Console.WriteLine("\n(Type \"quit\" for the main menu.)");
                       input = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("\n(Press enter again to quit.)");
                        Console.ReadLine();
                        input = "quit";
                    }
                }
            }

            if (input == "2")
            {
                // Get a random scripture.
                var scriptureTuple = scriptureFetchingObject.ReturnRandomScriptureTuple();
                // Make a scripture-holding object.
                Scripture scriptureObjectToDisplay = new Scripture(scriptureTuple.Item1, scriptureTuple.Item2, hintBool);
                Console.Clear();
                Console.WriteLine(scriptureObjectToDisplay.ReturnReference());
                Console.WriteLine(scriptureObjectToDisplay.ReturnTextString());
                Console.WriteLine("\n(Type \"quit\" for the main menu.)");
                input = Console.ReadLine();

                while (true)
                {
                    if (input == "quit")
                    {
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine(scriptureObjectToDisplay.ReturnReference());
                    // (string, bool) blankedTextBoolean = scriptureObjectToDisplay.ReturnBlankedText();
                    // string blankedText = blankedTextBoolean.Item1;
                    // bool noBlanksLeft = blankedTextBoolean.Item2;
                    // Console.WriteLine(blankedText);
                    // if (!noBlanksLeft)
                    (string, bool) blankedTextNoBlanks = scriptureObjectToDisplay.ReturnBlankedText();
                    Console.WriteLine(blankedTextNoBlanks.Item1);
                    if (!blankedTextNoBlanks.Item2)
                    {
                        Console.WriteLine("\n(Type \"quit\" for the main menu.)");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("\n(Press enter again to quit.)");
                        Console.ReadLine();
                        input = "quit";
                    }


                    // Change all this to "hint mode" menu choice.
                    // if (input == "hint")
                    // {
                    //     // scriptureObjectToDisplay
                    // }
                }
            }
        }
    }
}