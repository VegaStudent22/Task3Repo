using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
    class EmptyTile : Tile
    {
        public EmptyTile(int tileX, int tileY) : base(tileX, tileY, TileType.EMPTY)
        {
            
        }
        
    }
}
