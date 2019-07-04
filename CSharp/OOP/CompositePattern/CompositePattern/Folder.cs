using System;
using System.Collections.Generic;

namespace CompositePattern
{
    class Folder : IDisplayItem
    {
        private readonly string _name;
        private List<IDisplayItem> _itemInFolder = new List<IDisplayItem>();

        public Folder(string name)
        {
            _name = name;
        }

        public void AddItem(IDisplayItem item)
        {
            _itemInFolder.Add(item);
        }

        public void Display(int depeth)
        {
            Console.WriteLine(new String('-', depeth) + "+" + _name);

            foreach (IDisplayItem item in _itemInFolder)
            {
                item.Display(depeth +2);
            }
        }
    }
}
