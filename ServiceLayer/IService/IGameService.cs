using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.IService
{
    public interface IGameService
    {
        public void StartGame();

        public int DiceRoll(int playerNumber);
    }
}
