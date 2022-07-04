using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Squares
{
    public class Ladder : Square
    {
        public Ladder(int firstPosition, int finalPosition)
            : base(firstPosition, finalPosition) { }

        public override void ExtraAction(Token token)
        {
            if (token.Position == StartPosition)
            {
                token.Position = FinalPosition;
            }
            else
            {
                throw new Exception("Ladder start position is not same token position");
            }
        }
    }
}
