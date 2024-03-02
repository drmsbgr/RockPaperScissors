using RockPaperScissors.Model;
using System;
using System.Threading;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int computerScore = 0;
            int currentTour = 1;

            Console.WriteLine("Enter your nickname:");
            string playerName = Console.ReadLine();
            Console.Clear();

            HumanPlayer human = new HumanPlayer(playerName);
            RandomComputerPlayer computer = new RandomComputerPlayer();

            do
            {
                Console.WriteLine($"--Round {currentTour}----------------------------");
                Moves humanMove = human.MakeMove();
                Moves computerMove = computer.MakeMove();

                Console.WriteLine($"({human.GetPlayerName()}):{humanMove}");
                Thread.Sleep(1000);
                Console.WriteLine($"(computer):{computerMove}");
                Thread.Sleep(1000);

                if (humanMove == computerMove)
                    Console.WriteLine("Tie");
                else if (humanMove.CanWinAgainst(computerMove))
                {
                    Console.WriteLine($"({human.GetPlayerName()}) won this round.");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine($"(computer) won this round.");
                    computerScore++;
                }

                Console.WriteLine($"--Score State--({human.GetPlayerName()}):{playerScore}----(computer):{computerScore}--------");

                Console.WriteLine("Wanna play one more round? (y/n):");

                string answer = Console.ReadLine();

                if (answer == "n")
                    break;

                Console.WriteLine("\n");

                currentTour++;

            } while (true);

            Console.WriteLine($"Game ended after {currentTour} round(s).");
            if (computerScore > playerScore) Console.WriteLine("(computer) won the game.");
            else if (playerScore > computerScore) Console.WriteLine($"({human.GetPlayerName()}) won the game.");
            else Console.WriteLine("Game ended with tie.");

            Console.ReadKey();
        }
    }

    public static class Extensions
    {
        public static bool CanWinAgainst(this Moves move, Moves otherMove)
        {
            if (move == Moves.Rock && otherMove == Moves.Scissors ||
                move == Moves.Paper && otherMove == Moves.Rock ||
                move == Moves.Scissors && otherMove == Moves.Paper)
                return true;

            return false;
        }
    }
}
