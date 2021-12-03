using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using static PoE_GADE6112.Character;
using static PoE_GADE6112.Tile;

namespace PoE_GADE6112
{
  [Serializable]
  public class GameEngine
    {
        static string fileName;
        private Map map;
        public Shop shop { get; set; }
        public Map Map { get { return this.map; } set { map = value; } }
        private static readonly string[] symbols = { "h", ".", "g", "o", "w", "$", "m" }; // $: GOLD

        public GameEngine()
        {
            map = new Map(10, 10, 20, 20, 3, 5, 5);
            fileName = "game.dat";
            shop = new Shop(map.Hero);
        }
        public bool MovePlayer(Movement move)
        {
            map.Hero.Move(move);

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
            string temp = "";
            for (int x = 0; x < map.Width; x++)
            {
                for (int y = 0; y < map.Height; y++)
                {
                    if (Map.Tile[x, y] != null)
                    {
                        switch (Map.Tile[x, y].tileType)
                        {
                            case TileType.HERO:
                                temp += symbols[0];
                                break;
                            case TileType.EMPTY:
                                temp += symbols[1];
                                break;
                            case TileType.ENEMY:
                                if (Map.Tile[x, y].GetType() == typeof(Goblin))
                                {
                                    temp += "G";
                                }
                                else if (Map.Tile[x, y].GetType() == typeof(Mage))
                                {
                                    temp += "M";
                                }
                                else if (Map.Tile[x, y].GetType() == typeof(Leader))
                                {
                                    temp += "L";
                                }
                                break;
                            case TileType.OBSTACLE:
                                temp += symbols[3];
                                break;
                            case TileType.WEAPON:
                                temp += symbols[4];
                                break;
                            case TileType.GOLD:
                                temp += symbols[5];
                                break;
                            case TileType.MAGE:
                                temp += symbols[6];
                                break;
                            default:
                                temp += symbols[1];
                                break;
                        }
                    }
                    else
                    {
                        temp += symbols[1];//empty if null
                    }
                }
                temp += "\n";
            }
            return temp;
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

        public void MoveEnemies() 
        {
            for (int i = 0; i < Map.EnemyArr.Length; i++)
            {   
                //Map.EnemyArr[i].Attack(c);
                //Map.UpdateVision();
                if (map.EnemyArr[i].GetType() == typeof(Goblin) || map.EnemyArr[i].GetType() == typeof(Leader))
                {
                    map.UpdateTile(new EmptyTile(map.EnemyArr[i].X, map.EnemyArr[i].Y));
                    map.EnemyArr[i].Move(map.EnemyArr[i].ReturnMove());
                    map.UpdateTile(map.EnemyArr[i]);
                    map.UpdateVision();
                }
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
        
        public string playerAttack(Enemy e)
        {
            Map.Hero.Attack(e);

            if (e.IsDead())
            {   
                Map.Tile[e.X, e.Y] = new EmptyTile(e.X, e.Y);
                Map.removeEnemy(e);
                return "You killed a " + e.tileType.ToString() + "\n";
            }
            else
            {
                return "You attacked a " + e.tileType.ToString() + " for " + map.Hero.Damage + "\n"; 
            }
        }
    }
}


    
   