using System;


namespace NewDogDoorApp
{
    class Remote
    {
        private DogDoor _dogDoor;

        public Remote(DogDoor door)
        {
            _dogDoor = door;
        }
        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control Button ");
            if (_dogDoor.isOpen())
            {
                _dogDoor.Close();
            }
            _dogDoor.Open();
        }
    }
}
