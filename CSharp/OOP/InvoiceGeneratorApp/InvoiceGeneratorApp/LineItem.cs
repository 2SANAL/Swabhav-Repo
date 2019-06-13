﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceGeneratorApp
{
    class LineItem
    {
        private int _lineItemId;
        private int _quantity;
        private Product _product;
        private double _totalItemCost;

        public LineItem(int listItemId, int quantity, Product product)
        {
            _lineItemId = listItemId;
            _quantity = quantity;
            _product = product;
        }
        public int LineItemId
        {
            get
            {
                return _lineItemId;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        public Product Peoductlist
        {
            get
            {
                return _product;
            }
        }

        public double TotalItemCost()
        {
            _totalItemCost = _product.ProductTotalCost * _quantity;
            return _totalItemCost;
        }

    }
}
