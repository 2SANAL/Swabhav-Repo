using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib;
using System.Collections.Generic;
namespace ShoppingCartUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CustmorTestCase()
        {
            Custmoer customer = new Custmoer(101, "Abc", "Mumbai");
            int Id = customer.CustmorId;
            string name = customer.CustmorName;
            string location = customer.CustmorLocation;

            Assert.AreEqual(101, Id, "get Currect Id");
            Assert.AreEqual("Abc", name, "get Currectname");
            Assert.AreEqual("Mumbai", location, "get Currect Cost");

        }

        [TestMethod]
        public void LineItemTestCase()
        {
            LineItem lineItem = new LineItem(120, 2, new Product(101, "laptop", 12500));

            int productId = lineItem.Peoductlist.ProductId;
            string name = lineItem.Peoductlist.ProductName;
            double cost = lineItem.Peoductlist.ProductCost;
            double discount = lineItem.Peoductlist.ProductDiscount;
            double totalCost = lineItem.Peoductlist.TotalCost;

            Assert.AreEqual(101, productId, "get Currect Id");
            Assert.AreEqual("laptop", name, "get Currectname");
            Assert.AreEqual(12500, cost, "get Currect Cost");
            Assert.AreEqual(6250, discount, "get Currect discount");
            Assert.AreEqual(6250, totalCost, "get Currect TotalCost");

            int lineItemId = lineItem.LineItemId;
            int quantity = lineItem.Quantity;
            Assert.AreEqual(120, lineItemId, "get LineItem Id");
            Assert.AreEqual(2, quantity, "get quantity ");

        }
        [TestMethod]
        public void OrderTestCase()
        {
            Order order = new Order(120, new DateTime(2019, 12, 15));

            int orderId = order.OrderId;
            DateTime date = order.Date;

            Assert.AreEqual(120, orderId, "get order Id");
            Assert.AreEqual(new DateTime(2019, 12, 15), date, "get order date");

            order.AddItem(new LineItem(120, 2, new Product(101, "laptop", 12500)));
            
            Assert.AreEqual(1, order.OrderLineItemList.Count, "get order date");
           
            List<LineItem> lineItem1 = order.OrderLineItemList;

            foreach (LineItem lineitem in lineItem1)
            {
                int productId = lineitem.Peoductlist.ProductId;
                string name = lineitem.Peoductlist.ProductName;
                double cost = lineitem.Peoductlist.ProductCost;
                double discount = lineitem.Peoductlist.ProductDiscount;
                double totalCost = lineitem.Peoductlist.TotalCost;

                Assert.AreEqual(101, productId, "get Currect Id");
                Assert.AreEqual("laptop", name, "get Currectname");
                Assert.AreEqual(12500, cost, "get Currect Cost");

                Assert.AreEqual(6250, discount, "get Currect discount");
                Assert.AreEqual(6250, totalCost, "get Currect TotalCost");

                int lineItemId = lineitem.LineItemId;
                int quantity = lineitem.Quantity;
                Assert.AreEqual(120, lineItemId, "get LineItem Id");
                Assert.AreEqual(2, quantity, "get quantity ");
            }
        }
    }
}
