using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLib;
namespace CalcLibTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void PassEvenNumberExpectiongCube()
        {
            // Arrange

            int eveNumber = 2;
            int expect = 8;

            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.CubeOfEvenNumber(eveNumber);

            // Assert

            Assert.AreEqual(expect, actual, "give the currect cube");
        }

        [TestMethod]
        public void PassZeroExpectiongZero()
        {
            // Arrange

            int Zero = 0;
            int expect = 0;

            Calculator calculator = new Calculator();

            // Act
            int actal = calculator.CubeOfEvenNumber(Zero);

            // Assert

            Assert.AreEqual(expect, actal, "give the cube zero");
        }
        [TestMethod]
        public void Passing_OddNumber_Excepting_Exception()
        {

            int oddNumber = 1;
            string expect = "Odd Number Found";
            string message;
            Calculator calculator = new Calculator();


            try { calculator.CubeOfEvenNumber(oddNumber); }
            catch (Exception e)
            {
                message = e.Message;
                Assert.AreEqual(expect, message, "give the Exception");
            }
        }

        [TestMethod]
        public void Passing_NegiativeNumber_Excepting_Exception()
        {

            int negitiveNumber = -2;
            string expect = "Number is Negiative";
            string message;
            Calculator calculator = new Calculator();

            try { calculator.CubeOfEvenNumber(negitiveNumber); }
            catch (Exception e)
            {
                message = e.Message;
                Assert.AreEqual(expect, message, "give the Exception");
            }

        }
    }
}