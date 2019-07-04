using System;
using System.Collections;
using System.Collections.Generic;

namespace ObserverPatternApp
{
    abstract class Stock
    {
        private readonly string _symbol;
        private double _price;
        private List<IInvestor> _investors = new List<IInvestor>();

        ArrayList list = new ArrayList();
        LinkedList<string> a = new LinkedList<string>();
         

            public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
           list
        }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (IInvestor investor in _investors)
            {
                investor.Update(this);
            }
            Console.WriteLine("");
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get { return _symbol; }
        }
    }
}