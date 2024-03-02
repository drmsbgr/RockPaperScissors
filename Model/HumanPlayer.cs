using System;

namespace RockPaperScissors.Model
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string playerName) : base(playerName)
        {

        }

        public override Moves MakeMove()
        {
            Console.WriteLine("Select Move: (0-rock,1-paper,2-scissors):");

            int moveIndex = int.Parse(Console.ReadLine());

            return (Moves)moveIndex;
        }
    }
}
