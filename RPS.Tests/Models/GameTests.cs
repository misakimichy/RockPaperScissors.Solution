using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RPS.Models;

namespace RPS.TestTools
{
    [TestClass]
    public class GameTests
    {
        
        [TestMethod]
        public void Game_CheckWinnerDraw_Draw() 
        {
            string result = Game.CheckWinner("Rock", "Rock");
            Assert.AreEqual(result, "Draw");
        }
                

    }
}