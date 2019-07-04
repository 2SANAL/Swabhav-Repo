using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib;


namespace ShoppingCartUnitTest
{
    [TestClass]
    public class LineItemUnitTest
    {
        [TestMethod]
        public void LineItemTestCase()
        {
            LineItem lineItem = new LineItem(120, 2, new Product(101, "laptop", 12500));

            int productId = lineItem.Peoductlist.ProductId;
            string name = lineItem.Peoductlist.ProductName;
            double cost = lineItem.Peoductlist.ProductCost;
            double totalItemCost = lineItem.TotalItemCost;

            double discount = lineItem.Peoductlist.ProductDiscount;
            double totalCost = lineItem.Peoductlist.AfterDiscount;
            
            Assert.AreEqual(101, productId, "get Currect Id");
            Assert.AreEqual("laptop", name, "get Currectname");
            Assert.AreEqual(12500, cost, "get Currect Cost");
            Assert.AreEqual(25000, totalItemCost, "get Currect Cost");
            Assert.AreEqual(6250, discount, "get Currect discount");
            Assert.AreEqual(6250, totalCost, "get Currect TotalCost");

            int lineItemId = lineItem.LineItemId;
            int quantity = lineItem.Quantity;

            Assert.AreEqual(120, lineItemId, "get LineItem Id");
            Assert.AreEqual(2, quantity, "get quantity ");

        }

    }
}
