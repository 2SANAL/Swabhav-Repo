using System;

namespace NewDogDoorApp
{
    class BarkRecognizer
    {
            private DogDoor _dogDoor;

            public BarkRecognizer(DogDoor dogDoor)
            {
                _dogDoor = dogDoor;
            }
            public void Recognizer(string bark)
            {
                Console.WriteLine("BarkRecognizer: Heard a '" + bark + "'");
                _dogDoor.Open();

            }
        }
}
