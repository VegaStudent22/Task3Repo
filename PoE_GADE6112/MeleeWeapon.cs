using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
  [Serializable]
  public class MeleeWeapon : Weapon
    {
        public enum MeleeWeaponTypes
        {
            DAGGER, LONGSWORD
        }

        public MeleeWeaponTypes meleeWeaponTypes { get; set; }

        public MeleeWeapon(MeleeWeaponTypes meleeTypes, int x, int y, TileType tileTypeMelee) : base(x, y)
        {
            meleeWeaponTypes = meleeTypes;
        }

        public override int Range => 1;
        (MeleeWeaponTypes meleeWeaponTypes == MeleeWeaponTypes.DAGGER)

    }
}
