using System;
using RPS.Models;

namespace RPS 
{
    public class Program
    {
        public static void Main() 
        {
            Console.WriteLine("Welcome to 'Rock, Paper, Scissors' game!");
            while (true)
            {
                bool flag = false;
                Console.Write("Enter [Rock/Paper/Scissors]:");
                string userInput = Console.ReadLine();
                string[] choices = {"Rock", "Paper", "Scissors"};
                if (!Array.Exists(choices, element => element == userInput))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                
                string computerChoice = Game.RandomizeChoice();
                Console.WriteLine("Computer hand: " + computerChoice);
                Console.WriteLine($"Result of game: {Game.CheckWinner(userInput, computerChoice)}");
                while (true)
                {
                    Console.WriteLine("Do you want to play a game [yes/no]:");
                    string userInput2 = Console.ReadLine();
                    if (userInput2 == "no") 
                    {
                        flag = true;
                        break;
                    }
                    else if (userInput2 == "yes")
                    {
                        break;
                    }

                }
                if (flag)
                {
                    break;
                }

            }

        }
    }
}