using System;

namespace RockPaperScissors.Model
{
    internal class RandomComputerPlayer : ComputerPlayer
    {
        public override Moves MakeMove()
        {
            Moves move = (Moves)new Random().Next(3);
            return move;
        }
    }
}
