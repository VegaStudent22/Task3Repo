﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
  [Serializable]
  public class Goblin : Enemy
    {
        public Goblin(int x, int y) : base(x, y, 0, 10,1, TileType.ENEMY)
        {
            weapon = new MeleeWeapon(MeleeWeapon.MeleeWeaponTypes.DAGGER,0, 0, TileType.WEAPON);
            GoldPurse = 1;
        }

        public override Movement ReturnMove(Movement move = Movement.NOMOVEMENT)// to validate movement with character vision
        {
            int movement = randomNumber.Next(1,4);



            while (VisionArr[movement].tileType != TileType.EMPTY)
            {
                movement = randomNumber.Next(1, 4);
            }

            if (movement == 1)
            {
               return Movement.UP;
            }
            else if (movement == 2)
            {
                return Movement.DOWN;
            }
            else if (movement == 3)
            {
               return Movement.LEFT;
            }
            else if (movement == 4)
            {
               return Movement.RIGHT;
            }
            return Movement.NOMOVEMENT;
        }
    }            
}