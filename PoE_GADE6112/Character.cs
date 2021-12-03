using System;

using System.Collections.Generic;

using System.Text;

namespace PoE_GADE6112
{
  [Serializable]
  public abstract class Character : Tile
    {
        protected int hp;
        
        public int HP { get { return this.hp; } set { hp = value; } }
       
        protected int maxHP { get; set; }
       
        public int MaxHP { get { return this.maxHP; } set { maxHP = value; } }
       
        protected int damage { get; set; }
       
        public int Damage { get { return this.damage; } set { damage = value; } }
       
        private int goldPurse;
       
        public int GoldPurse { get { return this.goldPurse; } set { goldPurse = value; } }

        public Weapon weapon { get; set; }

        public Tile[] VisionArr { get; set; } = new Tile[4]; //index 0 up, 1 right, 2 down, 3 left; used to check valid movement
       
        public enum Movement
        {  
            NOMOVEMENT, UP, DOWN, LEFT, RIGHT
        }

        public Character(int x, int y, TileType tileType, int damage, int hp, int maxHP) : base(x, y, tileType)
        {
            this.damage = damage;
            this.maxHP = maxHP;
            this.hp = hp;
        }
        
        public virtual void Attack(Character target)
        {
            target.HP -= damage;

            if (target.IsDead())
            {
                loot(target);
            }
        }

        public bool IsDead()
        {
            if (HP == 0)
            {
                return true;
            }  
            return false;
        }

        public virtual bool CheckRange(Character target)
        {            
            if (DistanceTo(target) < 2) //Question 2.3 fix
            {
                return true;
            }
            return false;
        }

        private int DistanceTo(Character target)
        {
            return Math.Abs(X - target.X) + Math.Abs(Y - target.Y);
        }

        public void Move(Movement move)
        {
            if (move == Movement.UP)
            {
                Y = Y + 1;
            }
            else if (move == Movement.DOWN)
            {   
                Y = Y - 1;
            }
            else if (move == Movement.LEFT)
            {   
                X = X - 1;
            }
            else if (move == Movement.RIGHT)
            {   
                X = X + 1;
            }
        }

        public abstract Movement ReturnMove(Movement move = Movement.NOMOVEMENT);
        
        public abstract override String ToString();
        
        public void Pickup(Item i)
        {
            if (i.tileType == TileType.GOLD)
            {
                Gold gold = (Gold)i;
                goldPurse += gold.GoldAmount;
            }
            else if (i.tileType == TileType.WEAPON)
            {
                equip((Weapon)i);
            }
        }
        private void equip(Weapon w)
        {
            weapon = w;
        }

        void loot(Character enemyKilled)
        {
            goldPurse += enemyKilled.GoldPurse;
            if (weapon == null)
            {
                weapon = enemyKilled.weapon;
                if (GetType() != typeof(Mage))
                {
                    weapon = enemyKilled.weapon;
                }
            }
        }
    }
}

