using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessthenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Welcome to the guess the number game");
            Console.WriteLine("by Gregor");
            Console.WriteLine("");
            Console.WriteLine("guess a random number generate by the computer");

            int numberguess = 1;
            Random rand = new Random();
            int secretNumber = rand.Next(1,10);
            Console.WriteLine("Our secret number is " + secretNumber);
            Console.WriteLine("Enter a number guess between 1 and 9:");

            int guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You guessed " + guess);

            while(guess != secretNumber)
            {
                //keep guessing

                //tell player they were wrong
                Console.WriteLine("That is wrong. Guess again");
                if (secretNumber < guess)
                {
                    Console.WriteLine("the secret number is less than your guess " + guess);
                    numberguess = numberguess + 1;
                }
                else
                {
                    Console.WriteLine("the secret number is more than your guess " + guess);
                    numberguess = numberguess + 1;
                }

                //read a new guess from the player
                Console.WriteLine("guess another number between 1 and 9 ");
                guess = Convert.ToInt32(Console.ReadLine());


            }
            //now we have guessed the correct number 
            Console.WriteLine("You have correct number");
            Console.WriteLine("It took you " + numberguess + " attempts to get the correct number");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
