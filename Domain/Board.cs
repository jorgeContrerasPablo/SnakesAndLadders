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
            _squares = Enumerable.Repeat<Square>(new NormalSquare(0, 0),100).ToArray();
            InitSnakes();
            InitLadders();
        }

        public int MoveToken(int spaces, Token token)
        {
            int initPosition = token.Position;
            int finalPosition = initPosition + spaces;

            // Check over final position.
            if(IsOverFinal(finalPosition))
            {
                return initPosition;
            }

            token.Position = finalPosition;
            // Aditional movement.
            _squares[finalPosition-1].ExtraAction(token);
            return token.Position;
        }

        private bool IsOverFinal(int finalPosition)
        {
            return finalPosition > _squares.Length;
        }

        private void InitSnakes()
        {
            _squares[15] = new Snake(16, 6);
        }

        private void InitLadders()
        {
            _squares[14] = new Ladder(15, 26);
        }
    }
}