using FluentAssertions;
using ServiceLayer;
using ServiceLayer.IService;
using System;
using Xunit;

namespace ServiceLayerUnitTest
{
    public class GameServiceTest
    {
        private IGameService _gameService;
        private int _numberPlayers = 2;

        public GameServiceTest()
        {
            _gameService = new GameService();
            var numberPlayers = 2;
            _gameService.StartGame(numberPlayers);
        }

        /// <summary>
        /// US1-UAT1
        /// Given the game is started,
        /// When the token is placed on the board,
        /// Then the token is on square 1.
        /// </summary>
        [Fact]
        public void FirstPositionTokenTest()
        {
            for (int numberPlayer = 1; numberPlayer <= _numberPlayers; numberPlayer++)
            {
                _gameService.GetPositionToken(numberPlayer).Should().Be(1);
                _gameService.GetPositionToken(numberPlayer).Should().Be(1);
            }
        }

        /// <summary>
        /// US1-UAT2
        /// Given the token is on square 1,
        /// When the token is moved 3 spaces,
        /// Then the token is on square 4.
        /// </summary>
        [Fact]
        public void FirstPositionTokenMove3SpacesTest()
        {
            int diceRollReturns = 3;
            _gameService.MovePlayerToken(diceRollReturns, 1).Should().Be(4);
        }

        /// <summary>
        /// US1-UAT3
        /// Given the token is on square 1,
        /// When the token is moved 3 spaces,
        /// And then it is moved 4 spaces,
        /// Then the token is on square 8.
        /// </summary>
        [Fact]
        public void StartGameFirstPositionTokenTest()
        {
            int diceRollReturns = 3;
            int secondDiceRollReturns = 4;
            _gameService.MovePlayerToken(diceRollReturns, 1);
            _gameService.MovePlayerToken(secondDiceRollReturns, 1).Should().Be(8);
        }
    }
}
