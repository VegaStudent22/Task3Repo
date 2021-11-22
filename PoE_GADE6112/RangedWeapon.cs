using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
    class RangedWeapon
    {
        public enum RangedWeaponTypes
        {
            RIFLE, LONGBOW
        }

        public RangedWeaponTypes rangedWeaponTypes { get; set; }

        public override int Range()
        {
            return base.Range;
        }

        public RangedWeapon(RangedWeaponTypes rangedTypes, int x, int y, TileType tileTypeRanged)
        {
            rangedWeaponTypes = rangedTypes;
        }
    }
}
