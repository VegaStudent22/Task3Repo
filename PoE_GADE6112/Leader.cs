using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
  [Serializable]
  abstract class Leader : Enemy
    {
        private Leader Tile { get; set; }

        public Leader(Leader enemyLeader, int x, int y, TileType tileTypeEnemy)
        {
            int leaderHP = 5;
            int leaderDamage = 2;
        }

        public override Movement ReturnMove(Movement move = Movement.NOMOVEMENT)
        {

        }
    }
}
