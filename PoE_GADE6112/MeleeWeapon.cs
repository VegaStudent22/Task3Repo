using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
    public class MeleeWeapon : Weapon
    {
        public enum MeleeWeaponTypes
        {
            DAGGER, LONGSWORD
        }

        public MeleeWeaponTypes meleeWeaponTypes { get; set; }

        public MeleeWeapon(MeleeWeaponTypes meleeTypes, int x, int y, TileType tileType) : base(x, y)
        {
            meleeWeaponTypes = meleeTypes;
        }

        public override int Range()
        {
            return 1;
        }

        if (MeleeWeaponTypes meleeWeaponTypes == MeleeWeaponTypes.DAGGER)

    }
}
