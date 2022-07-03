using Domain.Squares;
using System;
using System.Linq;

namespace Domain
{
    public class Board
    {
        private Square[] _squares{ get; set; }

        public Board(int numberSquares)
        {
            _squares = new Square[numberSquares]
                .Select(h => new NormalSquare())
                .ToArray();
        }

        public int MoveToken(int spaces, Token token)
        {
            throw new NotImplementedException();
        }
    }
}