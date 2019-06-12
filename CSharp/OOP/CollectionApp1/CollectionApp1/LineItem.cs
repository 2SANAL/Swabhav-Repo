using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionApp1
{
    class LineItem
    {
        private readonly string _name;
        private readonly int _quantity;
        private readonly double _price;

        public LineItem(string name, int quantity, double price)
        {
            _name = name;
            _quantity = quantity;
            _price = price;
        }

        public double CalaculateTotal()
        {
            return _quantity * _price;
        }
        public string ProductName
        {
            get
            {
                return _name;
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
        }
        public override bool Equals(object obj)
        {
            LineItem lineitem;
            lineitem = (LineItem)obj;
            if((lineitem._name == this._name) &&(lineitem._price==this._price)&&( lineitem._quantity==this._quantity))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override int GetHashCode()
        {
            return 1;
        }
    }
}
