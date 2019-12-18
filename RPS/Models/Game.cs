using System.Collections.Generic;
namespace RPS.Models 
{
    public class Game
    {
        public static string CheckWinner(string choice1, string choice2)
        {
            Dictionary<string, string> playerDict = new Dictionary<string, string>() {};
            playerDict.Add("Player1", choice1);
            playerDict.Add("Player2", choice2);
            if (choice1 == choice2) {
                return "Draw";
            }
            return "";
        }
    } 
}