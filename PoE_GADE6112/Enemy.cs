using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
  [Serializable]
  public abstract class Enemy : Character
    {
        protected Random randomNumber = new Random();

        public Enemy(int enemyXPosition, int enemyYPosition, int enemyDamage, int enemyStartingHP, int enemyMaxHP, TileType enemySymbol) :
            base(enemyXPosition, enemyYPosition, enemySymbol, enemyDamage, enemyStartingHP, enemyMaxHP)
        {
            //includes the details of an enemy
        }
        public override string ToString()
        {
            string EnemyClassName = this.GetType().Name;

            if (weapon != null)
            {
                return "Equipped: " + EnemyClassName + " at [" + X + "," + Y + "] " + " with " + weapon.weaponType + "\n" + "(" + (weapon.durability * weapon.damage).ToString() + ")" + " With HP: " + HP.ToString();
            }
            else
            {
                return "Bare Handed: " + EnemyClassName + " at [" + X + "," + Y + "] " + Damage + " With HP: " + HP.ToString(); ;
            }
        }
    }
}
