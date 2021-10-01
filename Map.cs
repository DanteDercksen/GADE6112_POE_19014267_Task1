using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE_19014267
{
    class Map
    {
        Tile[,] map;

        EmptyTile emptyTile;

        Hero hero;
        Enemy[] enemies;

        int mapW, mapH;
        int xPos, yPos;
        int minW, minH, maxW, maxH;

        Random random = new Random();

        Form1 frm1 = new Form1();
        Form2 frm2 = new Form2();

        public int MapW
        {
            get { return mapW; }
        }

        public int MapH
        {
            get { return mapH; }
        }

        public Map(int minW, int maxW, int minH, int maxH, int numEnemies)
        {
            minW = frm2.minW;
            maxW = frm2.maxW;

            minH = frm2.minH;
            maxH = frm2.maxH;

            numEnemies = frm2.numEnemies;

            this.minW = minW;
            this.maxW = maxW;

            this.minH = minH;
            this.maxH = maxH;

            mapW = random.Next(minW, maxW + 1);
            mapH = random.Next(minH, maxH + 1);

            map = new Tile[mapW, mapH];

            enemies = new Enemy[numEnemies];

            Create(hero.type);

            foreach (Enemy enemy in enemies)
            {
                Create(enemy.type);
            }

            foreach(Character c in map)
            {
                UpdateVision(c);
            }
        }

        public void UpdateVision(Character c)
        {

        }

        private Tile Create(Tile.TileType type)
        {
            Hero h = new Hero(xPos, yPos, hero.HP, hero.MaxHP, 'H');

            Goblin g = new Goblin(xPos, yPos, 1, 10,10, 'G');

            xPos = random.Next(minW, maxW + 1);
            yPos = random.Next(minH, maxH + 1);

            if(map[xPos,yPos] != null)
            {
                xPos = random.Next(minW, maxW + 1);
                yPos = random.Next(minH, maxH + 1);
            }

            if (type == Tile.TileType.GOBLIN)
            {
                return g;
            }
            else if (type == Tile.TileType.HERO)
            {
                return h;
            }
            else
            {
                return emptyTile;
            }
        }

        public void GenerateMap()
        {
            for(int x = 0; x < mapW; x++)
            {
                for(int y = 0; y < mapH; y++)
                {
                    frm1.mapText += 'X';
                }
                frm1.mapText += 'Y';
            }
        }
    }
}
