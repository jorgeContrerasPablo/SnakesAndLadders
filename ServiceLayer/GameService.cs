using Domain;
using ServiceLayer.IService;
using System;
using System.Collections.Generic;

namespace ServiceLayer
{
    public class GameService : IGameService
    {
        private Game _game;
        private Dice _dice;

        public GameService()
        {
            _game = new Game();
            _dice = new Dice(1, 6);
        }

        public int DiceRoll(int playerNumber)
        {
            return _dice.Roll();
        }

        public int GetPositionToken(int playerNumber)
        {
            Player player = _game.GetPlayer(playerNumber);
            return player.Token.Position;
        }

        public int MovePlayerToken(int spaces, int playerNumber)
        {
            return _game.MovePlayerToken(spaces, _game.GetPlayer(playerNumber));
        }

        public int GetFinalPosition()
        {
            return _game.NumberSpaces;
        }

        public void StartGame(int numberPlayers)
        {
            _game.Start(numberPlayers);
        }
    }
}
