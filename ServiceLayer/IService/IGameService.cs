using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.IService
{
    public interface IGameService
    {
        public void StartGame(int numberPlayers);

        public int DiceRoll(int playerNumber);

        public int MovePlayerToken(int spaces, int playerNumber);

        public int GetPositionToken(int playerNumber);

        public int GetFinalPosition();
    }
}
