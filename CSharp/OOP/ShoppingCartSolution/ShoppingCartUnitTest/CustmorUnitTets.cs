using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib;



namespace ShoppingCartUnitTest
{
    [TestClass]
    public class CustmorUnitTets
    {
        [TestMethod]
        public void CustmorTestCase()
        {
            Custmoer customer = new Custmoer(101, "Abc", "Mumbai");
            int Id = customer.CustmorId;
            string name = customer.CustmorName;
            string location = customer.CustmorLocation;
 
            customer.AddOrder(new Order(121, new System.DateTime(2018 / 02 / 04)));

            Assert.AreEqual(101, Id, "get Currect Id");
            Assert.AreEqual("Abc", name, "get Currectname");
            Assert.AreEqual("Mumbai", location, "get Currect location");
            Assert.AreEqual(1, customer.OrderList.Count, "get Currect location");

        }

    }
}
