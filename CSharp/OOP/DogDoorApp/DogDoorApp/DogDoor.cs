using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoorApp
{
    class DogDoor
    {
        private bool _open;
        public DogDoor()
        {
            this._open = false;
        }
        public void Open()
        {
            Console.WriteLine("The dod door open");
            _open = true;
        }
        public void Close()
        {
            Console.WriteLine("The dod door Close");
            _open = false;
        }
        public bool isOpen()
        {
            return _open;
        }
        
    }
}
