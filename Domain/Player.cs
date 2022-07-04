namespace Domain
{
    public class Player
    {
        public Player(int playerNumber, int firstPosition)
        {
            PlayerNumber = playerNumber;
            Token = new Token(firstPosition);
        }

        public int PlayerNumber { get; set; }

        public Token Token{ get; set; }
    }
}