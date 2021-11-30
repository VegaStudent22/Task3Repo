using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
  [Serializable]
  public abstract class Item : Tile
    {
        public Item(int x, int y): base(x, y, TileType.GOLD)
        {

        }

        public Item(int x, int y, TileType tileType) : base(x, y, tileType)
        {
        }

        public abstract override string ToString();
    }
}
