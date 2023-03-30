    class Spinner
    {
        List<string> animationStrings = new List<string> {"\\(^o^)/", "_(^-^)_", };
        // {".", "o", "O", "O", "O", "O", "o", ".", ".", }; // {"", "-", "--", "---", "----", "-----", "----", "---", "--", "-", }; // {"|", "/", "-", "\\", };
        public void ShowSpinner()
        {
            // To wait for a key-press:
            // Console.WriteLine("Press ESC to stop");
            // do {
            //     while (! Console.KeyAvailable)
            //     {
            //         // Do something
            //     }       
            // } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            for (int i = 0; i < 3; i ++)
            {
                foreach (string thing in animationStrings)
                {
                    Console.Write(thing);
                    Thread.Sleep(300); // (75)
                    // Console.Write("\b \b");
                    Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
                }
            }
        }
    }
    