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
            int initPosition = token.Position;
            int finalPosition = initPosition + spaces;

            // Check over final position.
            if(IsOverFinal(finalPosition))
            {
                finalPosition = initPosition;
            }

            // TODO Aditional movement.
            token.Position = finalPosition;
            return finalPosition;
        }

        private bool IsOverFinal(int finalPosition)
        {
            return finalPosition > _squares.Length;
        }
    }
}