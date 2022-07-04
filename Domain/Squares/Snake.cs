using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Squares
{
    public class Snake : Square
    {
        public Snake(int firstPosition, int finalPosition)
            : base(firstPosition, finalPosition) { }

        public override void ExtraAction(Token token)
        {
            if(token.Position == StartPosition)
            {
                token.Position = FinalPosition;
            }
            else
            {
                throw new Exception("Snake final position is not same token position");
            }
        }
    }
}
