﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGeneratorApp
{
    class Product
    {
        private readonly int _productId;
        private readonly string _name;
        private readonly double _discount;
        private  readonly double _cost;

        public Product(int productId, string name, double cost)
        {
            _productId = productId;
            _name = name;
            _discount = 0.45* cost;
            _cost = cost;
        }
        public int ProductId
        {
            get
            {
                return _productId;
            }
        }
        public string ProductName
        {
            get
            {
                return _name;
            }
        }
        public double ProductDiscount
        {
            get
            {
                return _discount;
            }
        }
        public double ProductTotalCost
        {
            get
            {
                return _cost;
            }
        }

        public double TotalCost()
        {
            return _cost - _discount;

        }
    }
}
