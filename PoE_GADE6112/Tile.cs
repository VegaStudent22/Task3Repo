using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
    public abstract class Tile
    {
        protected int x;
        public int X { get { return this.x; } set { x = value; } }
        protected int y;
        public int Y { get { return this.y; } set { y = value; } }

        public enum TileType
        {
            HERO, ENEMY, GOBLIN, WEAPON, OBSTACLE, EMPTY, GOLD, MAGE
        }

        public TileType tileType { get; set; }
        public Tile(int x, int y, TileType tileType)
        {
            this.X = x;
            this.Y = y;
            this.tileType = tileType;
        }
    }
}
