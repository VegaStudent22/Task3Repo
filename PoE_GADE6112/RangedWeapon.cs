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

        public RangedWeaponTypes rangedWeaponTypes { get; set; };

        public override Range()
        {
            return Range;
        }

        public RangedWeapon(RangedWeaponTypes rangedTypes, int x, int y, TileT tileType) : base(x, y)
        {
            rangedWeaponTypes = rangedTypes;
        }
    }
}
