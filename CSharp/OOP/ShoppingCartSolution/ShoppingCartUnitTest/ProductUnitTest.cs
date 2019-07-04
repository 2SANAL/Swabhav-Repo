using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib;


namespace ShoppingCartUnitTest
{
    [TestClass]
    public class ProductUnitTest
    {
        [TestMethod]
        public void ProductTestCase()
        {
            Product product = new Product( 1,"Pen",25);

            int Id = product.ProductId;
            string name = product.ProductName;
            double Cost = product.ProductCost;
            double discount = product.ProductDiscount;
            double totalCostAfterDiscount = product.AfterDiscount;

            Assert.AreEqual(1, Id, "get Currect Id");
            Assert.AreEqual(12.5,totalCostAfterDiscount, "get currect cost");
            Assert.AreEqual("Pen", name, "get Currectname");
            Assert.AreEqual(25, Cost, "get Currect Cost");
            Assert.AreEqual(12.5, totalCostAfterDiscount, "get Currect discount");
            Assert.AreEqual(12.5, discount, "get Currect discount");


        }

    }
}
