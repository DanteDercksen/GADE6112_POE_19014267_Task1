using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE_19014267
{
    abstract class Tile
    {
        public enum TileType { Hero, Enemy, Goblin, Weapon};

        protected int x;
        protected int y;

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public Tile(int x, int y)
        {
            x = X;
            y = Y;
        }



    }
}
