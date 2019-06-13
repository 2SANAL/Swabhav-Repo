using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace InvoiceGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // CaseStudy1();
            // CaseStudy2();
            //CaseStudy3();
            CaseStudy4();

        }

        public static void CaseStudy1()
        {
            List<string> list = new List<string>();
            Custmore customer = new Custmore(101, "Abc", "Mumbai");
            LineItem laptop = new LineItem(10001, 2, new Product(20002, "Hp", 450000));
            LineItem mobile = new LineItem(10002, 3, new Product(3000, "1+", 45000));

            Order order1 = new Order(123, new DateTime(2019, 01, 05));
            order1.AddItem(laptop);
            order1.AddItem(mobile);
            customer.AddOrder(order1);

            Invoice invoice = new Invoice(customer);

            list = invoice.AllCustmoreOrderDetails;
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void CaseStudy2()
        {
            Product product = new Product(101, "laptop", 12500);
            Console.WriteLine("Product Id " + product.ProductId);
            Console.WriteLine("Product Name " + product.ProductName);
            Console.WriteLine("Product TotalCost " + product.ProductTotalCost);
            Console.WriteLine("Product After Discount " + product.ProductDiscount);

        }

        public static void CaseStudy3()
        {
            LineItem lineItem = new LineItem(120, 2, new Product(101, "laptop", 12500));
            Console.WriteLine("Line Item Id " + lineItem.LineItemId);
            Console.WriteLine("Line Item   qunatity " + lineItem.Quantity);
            Console.WriteLine("Product Id " + lineItem.Peoductlist.ProductId);
            Console.WriteLine("Product Name " + lineItem.Peoductlist.ProductName);
            Console.WriteLine("Product TotalCost " + lineItem.Peoductlist.ProductTotalCost);
            Console.WriteLine("Product After Discount " + lineItem.Peoductlist.ProductDiscount);
        }
        public static void CaseStudy4()
        {
            Order order = new Order(120, new DateTime(2019, 12, 15));
            Console.WriteLine("Order Id " + order.OrderId);
            Console.WriteLine("Order Date " + order.Date);
            order.AddItem(new LineItem(120, 2, new Product(101, "laptop", 12500)));
            order.AddItem(new LineItem(120, 2, new Product(101, "laptop", 12500)));

            Console.WriteLine("order CheckOut " + order.CheckOutPrice());
            List<LineItem> lineItem1 = order.OrderLineItemList;
            foreach (LineItem item in lineItem1)
            {
                Console.WriteLine("Line Item Id " + item.LineItemId);
                Console.WriteLine("Line Item   qunatity " + item.Quantity);
                Console.WriteLine("Product Id " + item.Peoductlist.ProductId);
                Console.WriteLine("Product Name " + item.Peoductlist.ProductName);
                Console.WriteLine("Product Cost " + item.Peoductlist.ProductTotalCost);
                Console.WriteLine("Product After Discount " + item.Peoductlist.ProductDiscount);
            }

        }

    }
}