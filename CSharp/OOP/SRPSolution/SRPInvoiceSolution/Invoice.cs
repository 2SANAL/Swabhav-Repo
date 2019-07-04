using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPInvoiceSolution
{
    class Invoice
    {
        private readonly int _InvoiceId;
        private readonly string _InvoiceName;
        private readonly double _cost;
        private readonly float _discount;
        private readonly float _gst;

        public Invoice(int id, string name, double cost, float discount, float gst)
        {
            _InvoiceId = id;
            _InvoiceName = name;
            _cost = cost;
            _discount = discount;
            _gst = gst;
        }

        public double CalaculateAfterDiscount()
        {
            return _cost - (_cost * _discount);
        }
        public double CalaculateTax()
        {
            return (_cost * _gst);
        }

        public double CalaculateFinalCost()
        {
            return CalaculateAfterDiscount() + CalaculateTax();
        }

       public int InvoiceId
        {
            get
            {
                return _InvoiceId;
            }
        }
        public string InvoiceName
        {
            get
            {
                return _InvoiceName;
            }
        }
        public double Cost
        {
            get
            {
                return _cost;
            }
        }
        public double Discount
        {
            get
            {
                return _discount;
            }
        }
        public double GST
        {
            get
            {
                return _gst;
            }
        }
        
    }
}

