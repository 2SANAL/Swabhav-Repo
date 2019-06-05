using System;

namespace GuesserGameApp
{
    class Program
    {
        static int userinputes;
        static int result;
        static string userchoice;
        static void Main(string[] args)
        {
            GuessNumberGame guessergame = new GuessNumberGame();
            guessergame.RandomNumberGenreator();
            Console.WriteLine(" Random number " + guessergame.SystemRandomNumber);
            Console.WriteLine("\n");

            while (true)
            {
                Console.WriteLine("Enter the guess Number : and stop the game press -1");
                userinputes = Convert.ToInt32(Console.ReadLine());

                if (userinputes == -1)
                {
                    break;
                }

                Console.WriteLine(" Random number " + guessergame.SystemRandomNumber);
                Console.WriteLine("\n");
                result = guessergame.GuessMatch(userinputes);

                if (result == 0)
                {
                    Console.WriteLine("Number is small than Guess number ");
                }
                if (result == 1)
                {
                    Console.WriteLine("Number is lager than Guess number ");
                }
                if (result == guessergame.SystemRandomNumber)
                {
                    Console.WriteLine("win");

                    Console.WriteLine("You want to continue game press 'y' or not 'n'  ");
                    userchoice = Console.ReadLine();
                    if (userchoice.Equals("n"))
                    {
                        break;
                    }
                    if (userchoice.Equals("y"))
                    {
                        guessergame.RandomNumberGenreator();
                        Console.WriteLine("RAndom Number " + guessergame.SystemRandomNumber);

                    }

                }

            }
        }
    }
}
