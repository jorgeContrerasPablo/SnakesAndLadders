using Domain;
using FluentAssertions;
using System;
using Xunit;

namespace DomainUnitTest
{
    public class SquaresTest
    {
        private Board _board;

        public SquaresTest()
        {
            _board = new Board(100);
        }

        /// <summary>
        /// Snake move.
        /// From position 16 to 6.
        /// </summary>
        [Fact]
        public void SnakeTest()
        {
            Token token = new Token(14);
            _board.MoveToken(2, token).Should().Be(6);
        }

        /// <summary>
        /// Ladder move.
        /// From position 15 to 26.
        /// </summary>
        [Fact]
        public void LadderTest()
        {
            Token token = new Token(14);
            _board.MoveToken(1, token).Should().Be(26);
        }

        /// <summary>
        /// Normal square move.
        /// No extra movement.
        /// </summary>
        [Fact]
        public void NormalSquareTest()
        {
            Token token = new Token(4);
            _board.MoveToken(1, token).Should().Be(5);
        }
    }
}
