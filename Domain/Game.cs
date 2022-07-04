using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Game
    {
        public Game()
        {
            FirstPositionTokens = 1;
            NumberSpaces = 100;
        }

        public List<Player> Players { get; set; }

        public Board Board { get; set; }

        public int FirstPositionTokens { get; set; }

        public int NumberSpaces { get; set; }

        public void Start(int numberPlayers) 
        {
            PlayersInitialize(numberPlayers);
            BoardInitialize();
        }

        public Player GetPlayer(int playerNumber)
        {
            return Players.FirstOrDefault(player => player.PlayerNumber == playerNumber);
        }

        private void PlayersInitialize(int numberPlayers)
        {
            Players = new List<Player>();
            for (int numberPlayer = 1; numberPlayer <= numberPlayers; numberPlayer++)
            {
                Players.Add(new Player(numberPlayer, FirstPositionTokens));
            }
        }

        private void BoardInitialize()
        {
            Board = new Board(100);
        }
    }
}
