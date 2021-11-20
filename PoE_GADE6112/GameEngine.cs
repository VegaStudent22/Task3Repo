using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using static PoE_GADE6112.Character;
using static PoE_GADE6112.Tile;

namespace PoE_GADE6112
{
    public class GameEngine
    {
        static string fileName;
        private Map map;
        public Map Map { get { return this.map; } set { map = value; } }
        private static readonly string[] symbols = { "h", ".", "g", "o", "w", "$", "m" }; // $: GOLD

        public GameEngine()
        {
            map = new Map(5, 10, 5, 10, 3, 5);
            fileName = "game.dat";
        }
        public bool MovePlayer(Movement move)
        {
            var isValid = false;
            //CheckRange movement against character vision array
            switch (move)
            {
                case Movement.UP:
                    isValid = Map.Hero.VisionArr[0].tileType != TileType.OBSTACLE ? true : false;
                    break;
                case Movement.RIGHT:
                    isValid = Map.Hero.VisionArr[1].tileType != TileType.OBSTACLE ? true : false;
                    break;
                case Movement.DOWN:
                    isValid = Map.Hero.VisionArr[2].tileType != TileType.OBSTACLE ? true : false;
                    break;
                case Movement.LEFT:
                    isValid = Map.Hero.VisionArr[3].tileType != TileType.OBSTACLE ? true : false;
                    break;
                default:
                    break;
            }

            if (isValid)
            {
                Map.UpdateVision();
                //Question 3.2 -> 2.
                //the hero position is already updated
                var item = Map.GetItemAtPosition(Map.Hero.X, Map.Hero.Y);//get item at its position
                if(item != null)
                {
                    Map.Hero.Pickup(item);//pickup item
                }                
            }
            return isValid;        

        }

        public override string ToString()
        {
            string grid = string.Empty;
            for (int i = 0; i < Map.Width; i++)
            {
                grid += "X".PadRight(3);
            }
            grid += "\n";
            
            for (int i = 0; i < Map.Width; i++)
            {
                grid += "X".PadRight(3);
                for (int j = 0; j < Map.Height; j++)
                {
                    if (Map.Tile[i, j] != null)
                    {                        
                        switch (Map.Tile[i, j].tileType)
                        {
                            case TileType.HERO:
                                grid += symbols[0].PadRight(3);
                                break;
                            case TileType.EMPTY:
                                grid += symbols[1].PadRight(3);
                                break;
                            case TileType.GOBLIN:
                                grid += symbols[2].PadRight(3);
                                break;
                            case TileType.OBSTACLE:
                                grid += symbols[3].PadRight(3);
                                break;
                            case TileType.WEAPON:
                                grid += symbols[4].PadRight(3);
                                break;
                            case TileType.GOLD:
                                grid += symbols[5].PadRight(3);
                                break;
                            case TileType.MAGE:
                                grid += symbols[6].PadRight(3);
                                break;
                            default:
                                grid += symbols[1].PadRight(3);
                                break;
                        }
                    }
                    else
                    {
                        grid += symbols[1].PadRight(3);//empty if null
                    }
                    
                    //grid += " | " + Map.Tile[i, j];
                }
                grid += "X".PadLeft(3) + "\n";
            }

            for (int i = 0; i < Map.Width; i++)
            {
                grid += "X".PadRight(3);
            }
            grid += "\n";
            return grid;
        }

        public void EnemyAttacks(Character c, Enemy g) //g: Goblin
        {
            for(int i = 0; i < Map.EnemyArr.Length; i++)
            {
                Map.EnemyArr[i].Attack(c);
                Map.UpdateVision();
            }

            for (int j = 0; j < Map.EnemyArr.Length; j++) //map updates after goblin moves
            {
                Map.EnemyArr[j].Attack(c);
                Map.UpdateVision();
            }
        }

        public void MoveEnemies(Character c) 
        {
            for (int i = 0; i < Map.EnemyArr.Length; i++)
            {
                
                Map.EnemyArr[i].Attack(c);
                Map.UpdateVision();

            }
        }
        
        public void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream ms = File.OpenWrite(fileName);
            formatter.Serialize(ms, Map.Tile);
            ms.Flush();
            ms.Close();
            ms.Dispose();
        }

        public void Load()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = File.Open(fileName, FileMode.Open);
            object obj = formatter.Deserialize(fs);
            Map.Tile = (Tile[,])obj;
            fs.Flush();
            fs.Close();
            fs.Dispose();
        }
    }
}


    
   