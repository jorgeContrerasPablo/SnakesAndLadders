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

        [Fact]
        public void SnakeTest()
        {
            Token token = new Token(14);
            _board.MoveToken(2, token).Should().Be(6);
        }

        [Fact]
        public void LadderTest()
        {
            Token token = new Token(14);
            _board.MoveToken(1, token).Should().Be(26);
        }

        [Fact]
        public void NormalSquareTest()
        {
            Token token = new Token(4);
            _board.MoveToken(1, token).Should().Be(5);
        }
    }
}
