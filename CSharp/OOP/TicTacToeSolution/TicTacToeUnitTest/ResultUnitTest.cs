using System;
using System.Collections.Generic;
using TicTacToeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToeUnitTest
{[TestClass]
   public class ResultUnitTest
    {
        [TestMethod]
        public void Test_GetResultMethod_PassingFirstRow()
        {
            Board board = new Board();
            board.SetMark(0, Mark.X);
            board.SetMark(3, Mark.X);
            board.SetMark(6, Mark.X);
            ResultAnalayzer analyzer = new ResultAnalayzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }

        [TestMethod]
        public void Test_GetResultMethod_PassingSecondRow()
        {
            Board board = new Board();
            board.SetMark(3, Mark.X);
            board.SetMark(4, Mark.X);
            board.SetMark(5, Mark.X);
            ResultAnalayzer analyzer = new ResultAnalayzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }

        [TestMethod]
        public void Test_GetResultMethod_PassingThirdRow()
        {
            Board board = new Board();
            board.SetMark(6, Mark.X);
            board.SetMark(7, Mark.X);
            board.SetMark(8, Mark.X);
            ResultAnalayzer analyzer = new ResultAnalayzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }

        [TestMethod]
        public void Test_GetResultMethod_PassingFirstColumn()
        {
            Board board = new Board();
            board.SetMark(0, Mark.X);
            board.SetMark(3, Mark.X);
            board.SetMark(6, Mark.X);
            ResultAnalayzer analyzer = new ResultAnalayzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }

        [TestMethod]
        public void Test_GetResultMethod_PassingSecondColumn()
        {
            Board board = new Board();
            board.SetMark(1, Mark.X);
            board.SetMark(4, Mark.X);
            board.SetMark(7, Mark.X);
            ResultAnalayzer analyzer = new ResultAnalayzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }
        [TestMethod]
        public void Test_GetResultMethod_PassingThirdColumn()
        {
            Board board = new Board();
            board.SetMark(2, Mark.X);
            board.SetMark(5, Mark.X);
            board.SetMark(8, Mark.X);
            ResultAnalayzer analyzer = new ResultAnalayzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }

        [TestMethod]
        public void Test_GetResultMethod_PassingFirstDiagonal()
        {
            Board board = new Board();
            board.SetMark(0, Mark.X);
            board.SetMark(4, Mark.X);
            board.SetMark(8, Mark.X);
            ResultAnalayzer analyzer = new ResultAnalayzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }

        [TestMethod]
        public void Test_GetResultMethod_PassingSecondDiagonal()
        {
            Board board = new Board();
            board.SetMark(2, Mark.X);
            board.SetMark(4, Mark.X);
            board.SetMark(6, Mark.X);
            ResultAnalayzer analyzer = new ResultAnalayzer(board);
            Assert.AreEqual(Results.WIN, analyzer.GetResult());
        }

        [TestMethod]
        public void Test_GetResultMethod_FillingAllCells()
        {
            Board board = new Board();
            board.SetMark(0, Mark.X);
            board.SetMark(1, Mark.O);
            board.SetMark(2, Mark.X);
            board.SetMark(3, Mark.X);
            board.SetMark(4, Mark.O);
            board.SetMark(5, Mark.O);
            board.SetMark(6, Mark.O);
            board.SetMark(7, Mark.X);
            board.SetMark(8, Mark.O);
            ResultAnalayzer analyzer = new ResultAnalayzer(board);
            Assert.AreEqual(Results.DRAW, analyzer.GetResult());
        }

    }
}
