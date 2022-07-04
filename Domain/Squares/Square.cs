using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Squares
{
    public abstract class Square
    {
        public Square(int startPosition, int finalPosition) 
        {
            StartPosition = startPosition;
            FinalPosition = finalPosition;
        }

        public int StartPosition { get; set; }

        public int FinalPosition { get; set; }

        public abstract void ExtraAction(Token token);
    }
}
