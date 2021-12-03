using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
  [Serializable]
  public class Hero : Character
    {
        public int heroXPosition;
        public int heroYPosition;
        public int heroHP;
        public new int maxHP;

        public Hero(int heroXPosition, int heroYPosition, int heroHP, int maxHP, int goldAmount = 0) : base(heroXPosition, heroYPosition, TileType.HERO, 2, heroHP, maxHP)
        {
            this.heroXPosition = heroXPosition;
            this.heroYPosition = heroYPosition;
            this.heroHP = heroHP;
            this.maxHP = maxHP;
            GoldPurse = goldAmount;
        }

        public override Movement ReturnMove(Movement move)
        {
            //CheckRange movement against character vision array
            switch (move)
            {
                case Movement.UP:
                    //if(VisionArr[0] == null)
                    //{
                    //    return move;
                    //}
                    //return VisionArr[0].tileType != TileType.OBSTACLE ? move : Movement.NOMOVEMENT;
                    if (VisionArr[0] != null)
                    {
                        if (VisionArr[0].tileType != TileType.OBSTACLE && VisionArr[0].tileType != TileType.ENEMY)
                        {
                            return Movement.UP;
                        }
                        else
                        {
                            return Movement.NOMOVEMENT;
                        }
                    }
                    else
                    {
                        return Movement.NOMOVEMENT;
                    }
                    
                case Movement.RIGHT:
                    if (VisionArr[1] != null)
                    {
                        if (VisionArr[1].tileType != TileType.OBSTACLE && VisionArr[1].tileType != TileType.ENEMY)
                        {
                            return Movement.RIGHT;
                        }
                        else
                        {
                            return Movement.NOMOVEMENT;
                        }
                    }
                    else
                    {
                        return Movement.NOMOVEMENT;
                    }
                case Movement.DOWN:
                    if (VisionArr[2] != null)
                    {
                        if (VisionArr[2].tileType != TileType.OBSTACLE && VisionArr[2].tileType != TileType.ENEMY)
                        {
                            return Movement.DOWN;
                        }
                        else
                        {
                            return Movement.NOMOVEMENT;
                        }
                    }
                    else
                    {
                        return Movement.NOMOVEMENT;
                    }
                case Movement.LEFT:
                    if (VisionArr[3] != null)
                    {
                        if (VisionArr[3].tileType != TileType.OBSTACLE && VisionArr[3].tileType != TileType.ENEMY)
                        {
                            return Movement.LEFT;
                        }
                        else
                        {
                            return Movement.NOMOVEMENT;
                        }
                    }
                    else
                    {
                        return Movement.NOMOVEMENT;
                    }
                default:
                    return Movement.NOMOVEMENT;
            }
        }

        public override string ToString()
        {
            string weaponString;
            if (weapon != null)
            {
                weaponString = weapon.weaponType;
            }
            else
            {
                weaponString = "Bare Hands";
            }

            string Hero = "Player Stats:" + "\n HP: " + HP + "/ " + MaxHP + "\n " + "Weapon: " + weaponString + "\n Gold: " +  GoldPurse + "\n Damage: " + Damage + "\n [" + X + "," + Y + "]";
            return Hero;
        }
    }
}
