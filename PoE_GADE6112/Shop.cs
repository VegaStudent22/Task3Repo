using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
    public class Shop
    {
        //public Weapon[] weaponArr { get { return this.weaponArr; } set { weaponArr = value; } }
        public Weapon[] weaponArr { get; set; }
        Random random = new Random();
        Character buyer;
        public Shop(Character newBuyer)
        {
            buyer = newBuyer;
            weaponArr = new Weapon[3];
            for (int i = 0; i < 3; i++)
            {
                weaponArr[i] = randomWeapon();
            }
        }
        Weapon randomWeapon()
        {
            int randomWeaponNumber = random.Next(0,4);
            switch(randomWeaponNumber)
            {
                case 0:
                    return new MeleeWeapon(MeleeWeapon.MeleeWeaponTypes.DAGGER, 0, 0, Tile.TileType.WEAPON);
                    break;
                case 1:
                    return new MeleeWeapon(MeleeWeapon.MeleeWeaponTypes.LONGSWORD, 0, 0, Tile.TileType.WEAPON);
                    break;
                case 2:
                    return new RangedWeapon(RangedWeapon.RangedWeaponTypes.RIFLE, 0, 0, Tile.TileType.WEAPON);
                    break;
                case 3:
                    return new RangedWeapon(RangedWeapon.RangedWeaponTypes.LONGBOW, 0, 0, Tile.TileType.WEAPON);
                    break;
            }
            return new MeleeWeapon(MeleeWeapon.MeleeWeaponTypes.DAGGER, 0, 0, Tile.TileType.WEAPON);

        }
        bool canBuy(int num)
        {
            if (buyer.GoldPurse >= weaponArr[num].cost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void Buy(int num)
        {
            buyer.GoldPurse -= weaponArr[num].cost;
            buyer.Pickup(weaponArr[num]);
            weaponArr[num] = randomWeapon();
        }

        public string DisplayWeapon(int num)
        {
            return "Buy " + weaponArr[num].weaponType.ToString() + " ( " + weaponArr[num].cost.ToString() + " Gold) ";
        }
    }
}
