using System;
using System.Collections.Generic;
using TicTacToeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToeUnitTest
{
    [TestClass]
    public class BoardUnitTest
    {
        [TestMethod]
        public void Test_AreCellsInitiallyEmpty()
        {
            Board board = new Board();
            foreach (Cell cell in board.Cell)
            {
                Assert.AreEqual(Mark.EMPTY, cell.Mark);
            }
        }

        [TestMethod]
        public void Test_SetPositionMethod()
        {
            Board board = new Board();
            board.SetMark(1, Mark.O);
            Assert.AreEqual(Mark.O, board.GetMark(1));

        }

        [TestMethod]
        public void Test_ExceptionCaseOfSetMethod()
        {
            Board board = new Board();
            board.SetMark(1, Mark.X);
            try
            {
                board.SetMark(1, Mark.O);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Cell Already Marked", e.Message);
            }
        }

        [TestMethod]
        public void Test_IsFullMethod()
        {
            Board board = new Board();
            foreach (Cell cell in board.Cell)
            {
                cell.Mark = Mark.X;
            }
            Assert.AreEqual(true, board.IsFull());
        }

        [TestMethod]
        public void Test_IsEmptyMethod()
        {
            Board board = new Board();
            foreach (Cell cell in board.Cell)
            {
                cell.Mark = Mark.EMPTY;
            }
            Assert.AreEqual(true, board.IsEmplty());
        }

    }
}
