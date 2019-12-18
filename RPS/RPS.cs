using System;
using RPS.Models;

namespace RPS 
{
    public class Program
    {
        public static void Main() 
        {
            Console.WriteLine("Welcome to 'Rock, Paper, Scissors' game!");
            PlayGame();
        }
        private static void PlayGame()
        {
            Console.Write("Enter [Rock/Paper/Scissors]:");
            string input = Console.ReadLine();
            string strFirstLetter = input.Substring(0, 1).ToUpper();
            string userInput = strFirstLetter + input.Substring(1);
            string[] choices = {"Rock", "Paper", "Scissors"};
            // If the input is not "rock", "Paper" nor "Scissors"
            if (!Array.Exists(choices, element => element == userInput))
            {
                ErrorMessage();
                PlayGame();
            }
            else
            {
                string computerChoice = Game.RandomizeChoice();
                Console.WriteLine("\nComputer hand: " + computerChoice);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\nResult of game: {Game.CheckWinner(userInput, computerChoice)}\n");
                Console.ResetColor();
                AskPlayAgain();
            }
        }
        private static void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input");
            Console.ResetColor();
        }

        private static void AskPlayAgain()
        {
            Console.WriteLine("Do you want to play again? [yes/no]:");
            string userInput = Console.ReadLine();
            if (userInput == "no")
            {
                Console.WriteLine("Thank you for playing with us!");
                return;
            }
            else if (userInput == "yes")
            {
                PlayGame();
            }
            else
            {
                ErrorMessage();
                AskPlayAgain();
            }
        }
    }
}