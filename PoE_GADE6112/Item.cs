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

        public abstract override string ToString();
    }
}
