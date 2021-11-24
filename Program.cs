using System;
namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            var min = 1;
            var max = 1024;
            ShowGreeting();
            GuessNumber(min, max);
        }
        static void ShowGreeting()
        {
            Console.WriteLine("Welcome to Number Guesser! Think of a number between 1 and 1024. Hit <Enter> when you're ready!");
            Console.ReadLine();
        }
        static void GuessNumber(int low, int high)
        {

            var mid = (low + high) / 2;
            Console.WriteLine($"Is your number {(mid / 2) * 2 }? Type 'y' for yes, 'l' for lower, or 'h' for higher.");
            var result = Console.ReadLine();
            if (result == "y")
            {
                Console.WriteLine("GREAT");
            }
            else if (result == "l")
            {
                var newMax = mid;
                GuessNumber(newMax, low);

            }
            else if (result == "h")
            {
                var newMin = mid;
                GuessNumber(newMin, high);
            }
            else
            {
                Console.WriteLine("Please type 'y', 'l', or 'h'");
            }
        }
    }
}

