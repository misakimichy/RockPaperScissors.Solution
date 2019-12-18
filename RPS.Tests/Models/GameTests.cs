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
        public void Game_CheckWinnerRockScissors_Player() 
        {
            string result = Game.CheckWinner("Rock", "Scissors");
            Assert.AreEqual(result, "Player");
        }
        [TestMethod]
        public void Game_CheckWinnerRockPaper_Computer() 
        {
            string result = Game.CheckWinner("Rock", "Paper");
            Assert.AreEqual(result, "Computer");
        }
        [TestMethod]
        public void Game_CheckWinnerScissorsPaper_Player() 
        {
            string result = Game.CheckWinner("Scissors", "Paper");
            Assert.AreEqual(result, "Player");
        }              

    }
}