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

        [TestMethod]
        public void Game_CheckWinnerRockScissors_Player1() 
        {
            string result = Game.CheckWinner("Rock", "Scissors");
            Assert.AreEqual(result, "Player1");
        }
        [TestMethod]
        public void Game_CheckWinnerRockPaper_Player2() 
        {
            string result = Game.CheckWinner("Rock", "Paper");
            Assert.AreEqual(result, "Player2");
        }
        [TestMethod]
        public void Game_CheckWinnerScissorsPaper_Player1() 
        {
            string result = Game.CheckWinner("Scissors", "Paper");
            Assert.AreEqual(result, "Player1");
        }              

    }
}