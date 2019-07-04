using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartLib
{
    public class Order
    {
        private int _orderId;
        private DateTime _date;
        private List<LineItem> _lineItemlist = new List<LineItem>();
        private LineItem item;

        public Order(int orderId, DateTime date)
        {
            _orderId = orderId;
            _date = date;
        }

        public int OrderId
        {
            get
            {
                return _orderId;
            }
        }


        public DateTime Date
        {
            get
            {
                return _date;
            }
        }

        public void AddItem(LineItem item)
        {
            int qunatityCount = 0;

            foreach (LineItem item1 in _lineItemlist)
            {
                if (item1.LineItemId == item.LineItemId && item1.Peoductlist.ProductName.Equals(item.Peoductlist.ProductName)
                    && item1.Peoductlist.ProductDiscount == item1.Peoductlist.ProductDiscount)
                {
                    qunatityCount = item.Quantity + item1.Quantity;
                    item1.Quantity = qunatityCount;
                    break;
                }

            }
            if (qunatityCount == 0)
                _lineItemlist.Add(item);

            if (_lineItemlist.Count == 0) { _lineItemlist.Add(item); }


        }
        public double GetCheckOutPrice()
        {
            double total = 0;

            foreach (LineItem item in _lineItemlist)
            {
                total = total + item.TotalItemCost;
            }
            return total;
        }

        public List<LineItem> OrderLineItemList
        {
            get
            {
                return _lineItemlist;
            }
        }
    }
}
