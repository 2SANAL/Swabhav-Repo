using System;
using System.Collections.Generic;
using System.Collections;

namespace InvoiceGeneratorApp
{
    class Invoice
    {
        private List<string> _allOrderdetails = new List<string>();
        private Custmore _customer;
        private List<Order> _orderlist;
        private ArrayList _orderArrylist = new ArrayList();
        private ArrayList _lineItemList = new ArrayList();
        private List<LineItem> _listlineitem2 = new List<LineItem>();

        public Invoice(Custmore customer)
        {
            _customer = customer;


            _orderlist = _customer.GetOrderList;
            foreach (Order order in _orderlist)
            {
                _orderArrylist.Add(order);
            }
            ListOfOrder(_orderArrylist);

        }
        public void ListOfOrder(ArrayList orderlist)
        {

            for (int index = 0; index < _orderArrylist.Count; index++)
            {
                Order order2 = (Order)_orderArrylist[index];
                _allOrderdetails.Add(Convert.ToString("Order Id :"+order2.OrderId));
                _allOrderdetails.Add(Convert.ToString("Order Date :"+order2.Date));
                _listlineitem2 = order2.OrderLineItemList;
                ListOfLineitemAndProduct(_listlineitem2);
            }
        }
        public void ListOfLineitemAndProduct(List<LineItem> listlineitem2)
        {
            foreach (LineItem lineItem in listlineitem2)
            {
                _allOrderdetails.Add(Convert.ToString("Line Item Id "+lineItem.LineItemId));
                _allOrderdetails.Add(Convert.ToString("Line Item Quantity " + lineItem.Quantity));
                _allOrderdetails.Add(Convert.ToString("Line Item TotalCost " + lineItem.TotalItemCost()));
                _allOrderdetails.Add(Convert.ToString("ProductDiscount " + lineItem.Peoductlist.ProductDiscount));
                _allOrderdetails.Add(Convert.ToString(" Product Id" + lineItem.Peoductlist.ProductId));
                _allOrderdetails.Add(Convert.ToString("Product Name" + lineItem.Peoductlist.ProductName));
                _allOrderdetails.Add(Convert.ToString("ProductCost" + lineItem.Peoductlist.ProductTotalCost));
            }
        }
        public List<string> AllCustmoreOrderDetails
        {
            get
            {
                return _allOrderdetails;
            }
        }

    }
}
