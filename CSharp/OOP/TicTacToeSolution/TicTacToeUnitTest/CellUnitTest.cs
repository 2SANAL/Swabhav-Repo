using System;
using TicTacToeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToeUnitTest
{
    [TestClass]
    public class CellUnitTest
    {
        [TestMethod]
        public void Test_InitialCellValue()
        {
            Cell cell = new Cell();
            Assert.AreEqual(Mark.EMPTY, cell.Mark);
        }

        [TestMethod]
        public void Test_ExpectValueAsX()
        {
            Cell cell = new Cell();
            cell.Mark = Mark.X;
            Assert.AreEqual(Mark.X, cell.Mark);
        }

        [TestMethod]
        public void Test_ExpectValueAsO()
        {
            Cell cell = new Cell();
            cell.Mark = Mark.O;
            Assert.AreEqual(Mark.O, cell.Mark);
        }

        [TestMethod]
        public void Test_IsAlreadyMarked()
        {
            Cell cell = new Cell();
            cell.Mark = Mark.O;
            Assert.AreEqual(true, cell.IsAlreadyMarked());
        }
    }
}
