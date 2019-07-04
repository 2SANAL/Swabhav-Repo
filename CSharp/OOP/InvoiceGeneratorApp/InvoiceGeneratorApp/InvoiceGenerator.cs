using System;
using System.Collections.Generic;
using System.Collections;

namespace InvoiceGeneratorApp
{
    class InvoiceGenerator
    {
        private List<string> _allOrderdetails = new List<string>();
        private Custmore _customer;
        private List<Order> _orderlist;
        private List<LineItem> _listlineitem2 ;

        public InvoiceGenerator(Custmore customer)
        {
            _customer = customer;
            _orderlist = _customer.OrderList;
            DisplayCustomerAndOrderDetais(_orderlist);

        }
        public void DisplayCustomerAndOrderDetais(List<Order> orderlist)
        {
            foreach (Order order in orderlist)
            {
                Console.WriteLine("Customer Id       "+_customer.CustmorId);
                Console.WriteLine("Customer Name     " + _customer.CustmorName);
                Console.WriteLine("Customer Location " + _customer.CustmorLocation);
                Console.WriteLine("Order Id         :" + order.OrderId);
                Console.WriteLine("Order Date         :" + order.Date);

                _listlineitem2 = order.OrderLineItemList;
                DispliayLineItemAndOroduct(_listlineitem2);
            }
        }
        public void DispliayLineItemAndOroduct(List<LineItem> listlineitem2)
        {
            foreach (LineItem lineItem in listlineitem2)
            {
                Console.WriteLine ("Line Item Id         " + lineItem.LineItemId);
                Console.WriteLine ("Line Item Quantity   " + lineItem.Quantity);
                Console.WriteLine ("Line Item TotalCost  " + lineItem.TotalItemCost());
                Console.WriteLine ("ProductDiscount      " + lineItem.Peoductlist.ProductDiscount);
                Console.WriteLine (" Product Id          " + lineItem.Peoductlist.ProductId);
                Console.WriteLine ("Product Name         " + lineItem.Peoductlist.ProductName);
                Console.WriteLine ("ProductCost          " + lineItem.Peoductlist.ProductTotalCost);
                Console.WriteLine("\n");
            }
        }
    }
}
