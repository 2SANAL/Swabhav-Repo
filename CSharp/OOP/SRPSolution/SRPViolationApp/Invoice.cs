using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPViolationApp
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

        public void Print()
        {
            Console.WriteLine("Invoice Id   :"+_InvoiceId);
            Console.WriteLine("Invoice Name :" + _InvoiceName);
            Console.WriteLine("Cost "+_cost);
            Console.WriteLine("Discount " + _discount);
            Console.WriteLine("Gst                 :" + _gst);
            Console.WriteLine("Cost After Discount :"+CalaculateAfterDiscount());
            Console.WriteLine("Tax On price        :" + CalaculateTax());
            Console.WriteLine("Total Cost          :" + CalaculateFinalCost());
        }
    }
}
