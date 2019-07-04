using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartLib
{
    public class Custmoer
    {

        private int _custmorId;
        private string _custmorName;
        private string _location;
        private List<Order> _ordersList = new List<Order>();

        public Custmoer(int id, string name, string location)
        {
            _custmorId = id;
            _custmorName = name;
            _location = location;
        }
        public int CustmorId
        {
            get
            {
                return _custmorId;
            }
        }
        public string CustmorName
        {
            get
            {
                return _custmorName;
            }
        }
        public string CustmorLocation
        {
            get
            {
                return _location;
            }
        }

        public void AddOrder(Order order)
        {
            _ordersList.Add(order);
        }

        public List<Order> OrderList

        {
            get
            {
                return _ordersList;
            }
        }
    }
}
