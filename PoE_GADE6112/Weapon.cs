using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
    public class Weapon : Item
    {
        private int damage;
        protected int Damage {get { return this.damage; } set { damage = value; } } //protected accessor for the Damage value

        public virtual int Range();

        private durability;
        protected int Durability {get { return this.durability; } set { durability = value; } } //protected accessor for the Durability value

        private cost;
        protected int Cost {get { return this.cost; } set { cost = value; } } //protected accessor for the Cost value

        private weaponType;
        protected string WeaponType {get { return this.weaponType; } set { weaponType = value; } } //protected accessor for the WeaponType value
        
        public Weapon(int x, int y): base(x, y, TileType.WEAPON)
        {
            
        }
    }
}
