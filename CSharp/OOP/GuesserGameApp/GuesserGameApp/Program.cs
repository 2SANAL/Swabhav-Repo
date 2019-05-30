using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuesserGameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int rnum;
            Random rand = new Random();
            rnum = rand.Next(0, 100);

            Console.WriteLine(rnum);
            int userinput;
            String userYN;
           
            while (true) 
            {
                Console.WriteLine("Guess the number");
                userinput = Convert.ToInt32(Console.ReadLine());

                if(userinput <rnum)
                {
                    Console.WriteLine("Number is small than guess no.");
                }
                else if(userinput > rnum)
                {
                    Console.WriteLine(" NUmber is large than guess no.");
                }
                else if (userinput == rnum)
                {
                    Console.WriteLine("You win");
                    rnum = rand.Next(0, 100);
                    Console.WriteLine(rnum);

                }

                Console.WriteLine("Do you Want to continuoe the game (y/n) ");
                userYN = Console.ReadLine();
                if (userYN.Equals("n"))
                { 
                    break;
                }

            }
        }
    }
}
