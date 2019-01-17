using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocusBonus3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool program = true;
            while (program)
            {
                Random numberToGuess = new Random();
                int RandNumber = numberToGuess.Next(1, 100);
                int userGuess = 0;
                int numberGuesses = 0;
                while (userGuess != RandNumber)
                {
                    numberGuesses++;
                    Console.Write("Enter your guess: ");
                    int.TryParse(Console.ReadLine(), out userGuess);

                    if (userGuess > RandNumber)
                    {
                        Console.WriteLine("{0} is too high!", userGuess);
                    }
                    else if (userGuess < RandNumber)
                    {
                        Console.WriteLine("{0} is too low!", userGuess);
                    }
                    else
                    {
                        Console.WriteLine("{0} is right! Congratulations.", userGuess);
                    }

                }
                Console.WriteLine("Your number of guesses is {0}", numberGuesses);
                bool Response = true;
                while (Response)
                {
                    Console.WriteLine("Would you like to continue (y/n)");
                    string UserAnswer = Console.ReadLine().ToLower();
                    if (UserAnswer == "y")
                    {
                        Response = false;
                        program = true;

                    }
                    else if (UserAnswer == "n")
                    {

                        Response = false;
                        program = false;
                    }
                    else
                    {
                        Console.WriteLine("Sorry I didnt catch that, please try agian");
                    }

                }
            }

        }
    }
}
