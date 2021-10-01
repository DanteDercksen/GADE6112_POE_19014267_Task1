using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE_19014267
{
    abstract class Character : Tile
    {
        public enum Movements { NO_MOVEMENT, UP, DOWN, LEFT, RIGHT};

        public enum Weapon { BAREHANDED };

        protected int hp;
        protected int maxHp;
        protected int damage;

        public Tile[] characterVision;

        public TileType type;

        public int HP
        {
            get { return hp; }
        }

        public int MaxHP
        {
            get { return maxHp; }
        }

        public int Damage
        {
            get { return damage; }
        }

        public Character(int xPos, int yPos, char character) : base(xPos,yPos)
        {

        }

        public virtual void Attack(Character target)
        {
            if(target != null)
            {
                target.hp -= damage;
            }
        }

        public bool IsDead()
        {
            if(hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool CheckRange(Character target)
        {
            if(DistanceTo(target) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int DistanceTo (Character target)
        {
            int distance;

            distance = ((x - target.x) * 2) + ((y - target.y) * 2) / 2;
            
            return distance;
        }

        public void Move(Movements move)
        {
            if(move == Movements.UP)
            {
                y++;
            }
            if(move == Movements.DOWN)
            {
                y--;
            }
            if(move == Movements.RIGHT)
            {
                x++;
            }
            if(move == Movements.LEFT)
            {
                x--;
            }
        }

        public abstract Movements ReturnMove(Movements move = 0);

        public abstract override string ToString();
    }
}
