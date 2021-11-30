using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
  [Serializable]
  class RangedWeapon : Weapon
    {
        public enum RangedWeaponTypes
        {
            RIFLE, LONGBOW
        }

        public RangedWeaponTypes rangedWeaponTypes { get; set; }

        public override int Range => base.Range;

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public RangedWeapon(RangedWeaponTypes rangedTypes, int x, int y, TileType tyleRanged) : base(x, y)
        {
            rangedWeaponTypes = rangedTypes;
            switch (rangedWeaponTypes)
            {
                case RangedWeaponTypes.RIFLE:
                    WeaponType = "Rifle";
                    Durability = 3;
                    Range = 3;
                    Damage = 5;
                    Cost = 7;
                    break;
                case RangedWeaponTypes.LONGBOW:
                    WeaponType = "LONGBOW";
                    Durability = 4;
                    Range = 2;
                    Damage = 4;
                    Cost = 6;
                    break;
            }
        }
    }
}
