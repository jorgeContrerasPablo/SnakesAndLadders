using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Squares
{
    public class NormalSquare : Square
    {
        public NormalSquare(int firstPosition, int finalPosition)
            : base(firstPosition, finalPosition) { }

        public override void ExtraAction(Token token)
        {
        }
    }
}
