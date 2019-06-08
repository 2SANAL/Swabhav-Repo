using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DogDoorApp
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
            Thread thread;
            Console.WriteLine("Pressing the remote control Button ");
            if (_dogDoor.isOpen())
            {
                _dogDoor.Close();
            }
            
                _dogDoor.Open();

            thread = new Thread(AutoDoorCloser);
        }
        public void AutoDoorCloser()
        {
            _dogDoor.Close();
        }
    }
}
