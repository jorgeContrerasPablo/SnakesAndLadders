using Domain;
using ServiceLayer.IService;
using System;
using System.Collections.Generic;

namespace ServiceLayer
{
    public class GameService : IGameService
    {
        private Game _game;

        public GameService()
        {
            _game = new Game();
        }

        public int DiceRoll(int playerNumber)
        {
            throw new NotImplementedException();
        }

        public int GetPositionToken(int playerNumber)
        {
            Player player = _game.GetPlayer(playerNumber);
            return player.Token.Position;
        }

        public int MovePlayerToken(int spaces, int playerNumber)
        {
            throw new NotImplementedException();
        }

        public int GetFinalPosition()
        {
            throw new NotImplementedException();
        }

        public void StartGame(int numberPlayers)
        {
            _game.Start(numberPlayers);
        }
    }
}
