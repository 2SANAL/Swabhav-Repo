using System;
using System.Collections.Generic;
using TicTacToeLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToeUnitTest
{
    [TestClass]
   public class PlayerUnitTest
    {
        [TestMethod]
        public void Test_GetPlayerInput()
        {
            Player player = new Player("akash", Mark.X);
            Assert.AreEqual("akash", player.Name);
            Assert.AreEqual(Mark.X, player.Mark);
        }

    }
}
