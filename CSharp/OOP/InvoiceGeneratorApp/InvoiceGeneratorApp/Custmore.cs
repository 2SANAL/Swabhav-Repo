﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGeneratorApp
{
    class Custmore
    {
        private int _custmorId;
        private string _custmorName;
        private string _location;
        private List<Order> _ordersList = new List<Order>();

        public Custmore(int id, string name, string location)
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

        public List<Order> GetOrderList
        {
            get
            {
                return _ordersList;
            }
        }
    }
}
