namespace RockPaperScissors.Model
{
    public abstract class Player : ComputerPlayer
    {
        protected Player(string playerName)
        {
            this.playerName = playerName;
        }
        protected string playerName;

        public string GetPlayerName() { return playerName; }
        public void SetPlayerName(string playerName) { this.playerName = playerName; }
    }
}
