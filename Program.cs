using System;

namespace NumberGuesser
{
    class Program
    {

        static void DisplayGreeting()
        {

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("      Welcome to The Number Guesser     ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }
        private static string Dialog(string message)
        {
            //write the nessage
            Console.Write(message);
            //return what the user entered 
            return Console.ReadLine();
        }

        static void GuessNumber(int low, int high)
        {

            var mid = (low + high) / 2;
            Console.WriteLine($"is you number {mid}? Type 'y' for yes, 'l' for lower, or 'h' for higher. ");
            var result = Console.ReadLine();

            if (result == "y")
            {
                Console.WriteLine("Wut Wut!"); //this should be another method
            }
            else if (result == "l")
            {
                var newMax = mid;
                Console.WriteLine("mid " + mid);
                GuessNumber(low, newMax);
                //last guess + min / 2
                //var lastGuess = 
            }
            else if (result == "h")
            {
                var newMin = mid;
                GuessNumber(newMin, high);
            }
            else
            {
                Console.WriteLine(" come on! Don't be difficult!");
            }
        }
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^METHODS^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        static void Main(string[] args)

        {

            var min = 1;
            var max = 1024;
            //greet user (METHOD A)
            DisplayGreeting();
            //2. Prompt user to guess number between 1 and 1024
            Console.WriteLine("Please, guess a number in your head between 1 and 1024!");
            //Have user hit enter when ready
            var start = Dialog("Hit enter when ready");

            GuessNumber(min, max);

        }

    }
}
//  Console.WriteLine(mid);
//Changing the dialog to change name in case of "alice"
// while (start.ToLower() == "no")
// {
//     Console.WriteLine("Come on, I don't have all day!");
//     //var restart = Dialog("Enter yes or no:");

//     if (start.ToLower() == "yes")
//     {
//         Random rand = new Random();
//         int number = rand.Next(min, max);
//         Console.WriteLine(number);
//     }
//     break;