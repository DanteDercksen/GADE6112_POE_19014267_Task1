using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE_19014267
{
    class Hero : Character
    {
        Form1 frm1;

        public Hero(int xPos, int yPos, int health,int maxHealth, char symbol) : base(xPos,yPos, symbol)
        {
            damage = 2;
            hp = health;
            maxHp = maxHealth;
            type = TileType.HERO;
        }

        public override void Attack(Character target)
        {
            base.Attack(target);
        }

        public override bool CheckRange(Character target)
        {
            return base.CheckRange(target);
        }

        public override Movements ReturnMove(Movements move = Movements.NO_MOVEMENT)
        {
            if (frm1.UpMove)
            {
                move = Movements.UP;
            }
            else if (frm1.DownMove)
            {
                move = Movements.DOWN;
            }
            else if (frm1.LeftMove)
            {
                move = Movements.LEFT;
            }
            else if (frm1.RightMove)
            {
                move = Movements.RIGHT;
            }

            for (int i = 0; i < characterVision.Length; i++)
            {
                if (characterVision[i] != null)
                {
                    move = Movements.NO_MOVEMENT;
                }
            }

            return move;
        }

        public override string ToString()
        {
            return $"Player Stats:\n" +
                $"HP: {HP}/ {MaxHP}\n" +
                $"Damage: {Damage}\n" +
                $"[{X},{Y}]";
        }
    }
}
