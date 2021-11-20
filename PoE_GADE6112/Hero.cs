using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
    public class Hero : Character
    {
        public int heroXPosition;
        public int heroYPosition;
        public int heroHP;
        public new int maxHP;
        public int goldAmount;

        public Hero(int heroXPosition, int heroYPosition, int heroHP, int maxHP, int goldAmount) : base(heroXPosition, heroYPosition, TileType.HERO, 2, heroHP, maxHP)
        {
            this.heroXPosition = heroXPosition;
            this.heroYPosition = heroYPosition;
            this.heroHP = heroHP;
            this.maxHP = maxHP;
            this.goldAmount = goldAmount;
        }

        public override Movement ReturnMove(Movement move)
        {
            //CheckRange movement against character vision array
            switch (move)
            {
                case Movement.UP:
                    if(VisionArr[0] == null)
                    {
                        return move;
                    }
                    return VisionArr[0].tileType != TileType.OBSTACLE ? move : Movement.NOMOVEMENT;
                case Movement.RIGHT:
                    if (VisionArr[1] == null)
                    {
                        return move;
                    }
                    return VisionArr[1].tileType != TileType.OBSTACLE ? move : Movement.NOMOVEMENT;
                case Movement.DOWN:
                    if (VisionArr[2] == null)
                    {
                        return move;
                    }
                    return VisionArr[2].tileType != TileType.OBSTACLE ? move : Movement.NOMOVEMENT;
                case Movement.LEFT:
                    if (VisionArr[3] == null)
                    {
                        return move;
                    }
                    return VisionArr[3].tileType != TileType.OBSTACLE ? move : Movement.NOMOVEMENT;
                default:
                    return Movement.NOMOVEMENT;
            }
        }

        public override string ToString()
        {
            string Hero = "Player Stats:" + "\n HP: " + HP + "/ " + MaxHP + "\n Gold: " + "\n " + goldAmount + "\n Damage: " + Damage + "\n [" + X + "," + Y + "]";

            return Hero;
        }
    }
}
