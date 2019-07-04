using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPInvoiceSolution
{
    class PrintInvoice
    {
        private Invoice _invoice;

        public PrintInvoice(Invoice invoice)
        {
            _invoice = invoice;
        }
        public void Print()
        {
            Console.WriteLine("Invoice Id           :" + _invoice.InvoiceId);
            Console.WriteLine("Invoice Name         :" + _invoice.InvoiceName);
            Console.WriteLine("Cost                 :" + _invoice.Cost);
            Console.WriteLine("Discount             :" + _invoice.Discount);
            Console.WriteLine("Gst                 :" + _invoice.GST);
            Console.WriteLine("Cost After Discount :" + _invoice. CalaculateAfterDiscount());
            Console.WriteLine("Tax On price        :" +_invoice.CalaculateTax());
            Console.WriteLine("Total Cost          :" +_invoice.CalaculateFinalCost());
        }
    }
}
