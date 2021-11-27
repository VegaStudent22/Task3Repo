using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
  [Serializable]
  class Obstacle : Tile
    {
        public Obstacle(int tileX, int tileY) : base(tileX, tileY, TileType.OBSTACLE)
        {

        }
    }
}
