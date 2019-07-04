using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    class File : IDisplayItem
    {
        private readonly string _name;
        private readonly string _extension;
        private readonly double _size;

        public File(string name, string extension, double size)
        {
            _name = name;
            _extension = extension;
            _size = size;
        }

        public void Display(int depeth)
        {
            Console.WriteLine(new String('-', depeth) + "File Name :" + _name 
                + " Extension :" + _extension + " Size :" + _size);
        }

    }
}
