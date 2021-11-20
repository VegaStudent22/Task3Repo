using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
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
            this.HP = this.HP - target.Damage;
        }

        public bool IsDead()
        {
            bool dead;

            if (HP == 0)
            {
                dead = true;
            }
            else
            {
                dead = false;
            }
            return dead;
        }

        public virtual bool CheckRange(Character target)
        {            
            bool characterRange = true;

            if (DistanceTo(target) == 1)
            {
                characterRange = true;
            }
            else
            {
                characterRange = true;
            }

            return characterRange;
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
            else if(move == Movement.NOMOVEMENT)
            {
                // X and Y remains as they are
            }
        }

        public abstract Movement ReturnMove(Movement move = Movement.NOMOVEMENT);
        public abstract override String ToString();
        public void Pickup(Item i)
        {
            if (i.tileType == TileType.GOLD)
            {
                //goldPurse += i.GoldAmount;
            }
        }
    }
}

