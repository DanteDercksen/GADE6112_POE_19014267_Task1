using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE_19014267
{
    class Goblin : Enemy
    {
        int xPos;
        int yPos;
        char symbol;

        public Goblin(int xPos, int yPos, int damage, int health, int maxHealth, char symbol) : base(xPos,yPos,damage,health,maxHealth,symbol)
        {
            health = 10;
            damage = 1;
            type = TileType.GOBLIN;

            //this.health = health;
            this.damage = damage;
        }

        public override Movements ReturnMove(Movements move = Movements.NO_MOVEMENT)
        {
            int moveOption;

            moveOption = r.Next(0, 6);

            if(moveOption == 0)
            {
                move = Movements.NO_MOVEMENT;
            }
            else if(moveOption == 1)
            {
                move = Movements.UP;
            }
            else if(moveOption == 2)
            {
                move = Movements.RIGHT;
            }
            else if(moveOption == 3)
            {
                move = Movements.DOWN;
            }
            else
            {
                move = Movements.LEFT;
            }

            for(int i = 0; i < characterVision.Length; i++)
            {
                if (characterVision[i] != null)
                {
                    move = Movements.NO_MOVEMENT;
                }
            }

            //TODO: Use character vision array to determine if the enemy is able to move in a direction
            //or if they are blocked by another character.

            return move;
        }
    }
}
