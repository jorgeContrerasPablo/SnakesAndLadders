using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Dice
    {
        private int _minorNumber;
        private int _biggerNumber;

        public Dice(int minorNumber, int biggerNumber)
        {
            _minorNumber = minorNumber;
            _biggerNumber = biggerNumber;
        }

        public int Roll()
        {
            Random rnd = new Random();
            return rnd.Next(_minorNumber, _biggerNumber);
        }
    }
}
