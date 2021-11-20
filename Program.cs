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

        static void Main(string[] args)

        {
            //greet user (METHOD A)
            DisplayGreeting();
            //2. Prompt user to guess number between 1 and 1024
            Console.WriteLine("Please, guess a number in your head between 1 and 1024!");
            //3. Ask user "Do you have a number in your mind, enter yes or no"
            Console.WriteLine("Do you have a number in your head, enter yes or no");
            //4. If input is yes then display a RANDOMLY guessed number
            var start = Dialog("Enter yes or no:");

            //Changing the dialog to change name in case of "alice"
            if (start == "yes")
            {
                Random rand = new Random();
                int number = rand.Next(1, 1024);
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Come on, I don't have all day!");
                // until(Console.ReadLine == "yes");
            }

        }
    }
}
