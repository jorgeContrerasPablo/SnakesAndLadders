using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.IService
{
    public interface IGameService
    {
        /// <summary>
        /// Start players, tokens and board.
        /// </summary>
        /// <param name="numberPlayers">Number of players to play.</param>
        public void StartGame(int numberPlayers);

        /// <summary>
        /// Rolling a dice.
        /// </summary>
        /// <param name="playerNumber">Number of player that roll the dice.</param>
        /// <returns>The number of dice.</returns>
        public int DiceRoll(int playerNumber);

        /// <summary>
        /// Move the player token to the final position.
        /// </summary>
        /// <param name="spaces">The spaces to move the token.</param>
        /// <param name="playerNumber">The token player.</param>
        /// <returns></returns>
        public int MovePlayerToken(int spaces, int playerNumber);

        /// <summary>
        /// Get the token position of a player.
        /// </summary>
        /// <param name="playerNumber">Player Number.</param>
        /// <returns></returns>
        public int GetPositionToken(int playerNumber);

        /// <summary>
        /// Get the final position of the game.
        /// </summary>
        /// <returns>Final position.</returns>
        public int GetFinalPosition();
    }
}
