using System;
using System.Collections.Generic;
using System.Text;

namespace PoE_GADE6112
{
    [Serializable]
    public class Leader : Enemy
    {
        private Tile Target { get; set; }

        public Leader(int enemyXPosition, int enemyYPosition, TileType enemySymbol, int enemyDamage = 2, int enemyStartingHP = 20, int enemyMaxHP = 20) : base(enemyXPosition, enemyYPosition, enemyDamage, enemyStartingHP, enemyMaxHP, enemySymbol)
        {
            weapon = new MeleeWeapon(MeleeWeapon.MeleeWeaponTypes.LONGSWORD, 0, 0, TileType.WEAPON);
        }

        public override Movement ReturnMove(Movement moveDirection = Movement.NOMOVEMENT)
        {
            if (x != Target.X)
            {
                if (x < Target.X)
                {
                    return isValid(Movement.RIGHT);
                }
                else
                {
                    return isValid(Movement.LEFT);
                }
            }
            else if (y != Target.Y)
            {
                if (y < Target.Y)
                {
                    return isValid(Movement.DOWN);
                }
                else
                {
                    return isValid(Movement.UP);
                }
            }
            return Movement.NOMOVEMENT;
        }
        Movement isValid(Movement currentMove)
        {
            switch (currentMove)
            {
                case Movement.UP:
                    if (isTileClear(Movement.UP))
                    {
                        return Movement.UP;
                    }
                    else
                    {
                        int randomDirection = randomNumber.Next(1, 5);
                        Movement tempMove = (Movement)randomDirection;
                        while (isTileClear(tempMove) == false)
                        {
                            randomDirection = randomNumber.Next(1, 5);
                            tempMove = (Movement)randomDirection;
                        }
                        return tempMove;
                    }
                    break;
                case Movement.DOWN:
                    if (isTileClear(Movement.DOWN))
                    {
                        return Movement.DOWN;
                    }
                    else
                    {
                        int randomDirection = randomNumber.Next(1, 5);
                        Movement tempMove = (Movement)randomDirection;
                        while (isTileClear(tempMove) == false)
                        {
                            randomDirection = randomNumber.Next(1, 5);
                            tempMove = (Movement)randomDirection;
                        }
                        return tempMove;
                    }
                    break;
                case Movement.LEFT:
                    if (isTileClear(Movement.LEFT))
                    {
                        return Movement.LEFT;
                    }
                    else
                    {
                        int randomDirection = randomNumber.Next(1, 5);
                        Movement tempMove = (Movement)randomDirection;
                        while (isTileClear(tempMove) == false)
                        {
                            randomDirection = randomNumber.Next(1, 5);
                            tempMove = (Movement)randomDirection;
                        }
                        return tempMove;
                    }
                    break;
                case Movement.RIGHT:
                    if (isTileClear(Movement.RIGHT))
                    {
                        return Movement.RIGHT;
                    }
                    else
                    {
                        int randomDirection = randomNumber.Next(1, 5);
                        Movement tempMove = (Movement)randomDirection;
                        while (isTileClear(tempMove) == false)
                        {
                            randomDirection = randomNumber.Next(1, 5);
                            tempMove = (Movement)randomDirection;
                        }
                        return tempMove;
                    }
                    break;
            }
            return Movement.NOMOVEMENT;
        }
        bool isTileClear(Movement direction)
        {
            Tile targetTile = null;
            for (int i = 0; i < VisionArr.Length; i++)
            {
                switch (direction)
                {
                    case Movement.UP:
                        if (VisionArr[i].Y < Y)
                        {
                            targetTile = VisionArr[i];
                        }
                            break;
                    case Movement.DOWN:
                        if (VisionArr[i].Y > Y)
                        {
                            targetTile = VisionArr[i];
                        }
                        break;
                    case Movement.LEFT:
                        if (VisionArr[i].X < X)
                        {
                            targetTile = VisionArr[i];
                        }
                        break;
                    case Movement.RIGHT:
                        if (VisionArr[i].X > X)
                        {
                            targetTile = VisionArr[i];
                        }
                        break;
                }
            }
            if (targetTile.tileType == TileType.EMPTY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
