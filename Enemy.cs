using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE_19014267
{
    abstract class Enemy : Character
    {
        protected Random r = new Random();

        public Enemy(int xPos, int yPos, int damage, int health, int maxHealth, char symbol) : base(xPos,yPos,symbol)
        {
            x = xPos;
            y = yPos;
            type = TileType.ENEMY;
        }

        public override string ToString()
        {
            return $"Enemy at [{x}, {y}] ({damage})";
        }
    }
}
