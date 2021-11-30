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
            switch (meleeTypes)    
            {
                case MeleeWeaponTypes.DAGGER:
                    WeaponType = "DAGGER";
                    Durability = 10;
                    Damage = 3;
                    Cost = 3;
                    break;
                case MeleeWeaponTypes.LONGSWORD:
                    WeaponType = "LONGSWORD";
                    Durability = 6;
                    Damage = 4;
                    Cost = 5;
                    break;
            }
        }

        public override int Range => 1;
        (MeleeWeaponTypes meleeWeaponTypes == MeleeWeaponTypes.DAGGER)

        public override string ToString()
        {
            throw new NotImplementedException();
        }
  }
}
