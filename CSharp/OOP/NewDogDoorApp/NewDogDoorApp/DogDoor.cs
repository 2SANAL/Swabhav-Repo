using System;
using System.Collections;
using System.Threading;

namespace NewDogDoorApp
{
    class DogDoor
    {
        private bool _open;
        private Thread thread;
        private ArrayList _allowedBark;
        private static int count;

        public DogDoor()
        {
            this._open = false;
            _allowedBark = new ArrayList();
        }
        public void AddAlloweBark(Bark bark)
        {
            _allowedBark.Add(bark);
            count++;
        }
        public ArrayList GetAllowedBark()
        {
            return _allowedBark;
        }
        public void Open()
        {
            Console.WriteLine("The dod door open");
            _open = true;
            Thread.Sleep(1000);
            thread = new Thread(Close);
            thread.Start();
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
