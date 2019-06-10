using System;
using System.Threading;

namespace NewDogDoorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DogDoor dogdoor = new DogDoor();

            dogdoor.AddAlloweBark(new Bark("rowlf"));
            dogdoor.AddAlloweBark(new Bark("rooowlf"));
            dogdoor.AddAlloweBark(new Bark("rawlf"));
            dogdoor.AddAlloweBark(new Bark("woof"));

            BarkRecognizer recognizer = new BarkRecognizer(dogdoor);
            Remote remote = new Remote(dogdoor);

            Console.WriteLine("Bruce Start barking ");
            new Bark("rowlf");
            recognizer.Recognizer("rowlf");

            Console.WriteLine("Bruce has gone outside ");
            Thread.Sleep(1000);
            Console.WriteLine("Bruce is all done ");


            Console.WriteLine("But he's stuck outside");

            Bark smallDogBark = new Bark("yip");
            Console.WriteLine("samall dog  starts barking..");
            recognizer.Recognizer("yip");
            Thread.Sleep(1000);

            Console.WriteLine("Bruce start barking");
            new Bark("rooowlf");
            recognizer.Recognizer("rooowlf");
            Console.WriteLine("Bruce's back inside..");

        }
    }
}
