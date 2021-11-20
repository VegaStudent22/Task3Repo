using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
    public class Gold : Item
    {
        private int goldAmount;
        public int GoldAmount { get { return this.goldAmount; } set { goldAmount = value; } }
        private Random random = new Random();

        public Gold(int x, int y): base(x,y)
        {
            GoldAmount = Random.Next(1,5);
        }

        public Random Random { get { return this.random; } set { random = value; } }

        public override string ToString()
        {
            return tileType.ToString();
        }
    }
}
