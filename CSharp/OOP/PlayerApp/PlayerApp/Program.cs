using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(1, "Dhruv", GenderOptions.MALE);
            Player p2 = new Player(2, "Akash");
            DisplayInfo(p1);
            DisplayInfo(p2);

        }
        static void DisplayInfo(Player obj)
        {
            Console.WriteLine("Player Name " + obj.GetName() + "\nId " + obj.GetId() + " \nGender " + obj.GetGender());
        }
    }
}
