using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class Dice
    {
        public int Throw()
        {
            Random rnd = new Random();
            return rnd.Next(1, 6);
        }
    }
}
