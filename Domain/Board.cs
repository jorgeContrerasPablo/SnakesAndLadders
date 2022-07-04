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
            AddSnake(16, 6);
            AddSnake(49, 11);
            AddSnake(46, 25);
            AddSnake(64, 60);
            AddSnake(62, 19);
            AddSnake(74, 53);
            AddSnake(89, 68);
            AddSnake(92, 88);
            AddSnake(95, 75);
            AddSnake(99, 80);
        }

        private void AddSnake(int firstPosition, int finalPosition)
        {
            _squares[firstPosition-1] = new Snake(firstPosition, finalPosition);
        }

        private void InitLadders()
        {
            AddLadder(2, 38);
            AddLadder(7, 14);
            AddLadder(8, 31);
            AddLadder(15, 26);
            AddLadder(21, 42);
            AddLadder(28, 84);
            AddLadder(36, 44);
            AddLadder(51, 67);
            AddLadder(71, 91);
            AddLadder(78, 98);
            AddLadder(87, 94);
        }

        private void AddLadder(int firstPosition, int finalPosition)
        {
            _squares[firstPosition-1] = new Ladder(firstPosition, finalPosition);
        }
    }
}