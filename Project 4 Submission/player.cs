using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Player
    {
        int xOrY;

        Player(int xOrY)
        {
            this.xOrY = xOrY;
        }

        public void turn(int player)
        {
            Random rando = new Random();
            Random rando2 = new Random();

            rando.Next(0, 3);
            rando2.Next(0, 3);
            return;
        }
    }
}
