using System;
using System.Collections.Generic;
using System.Text;
using static PoE_GADE6112.Tile;

namespace PoE_GADE6112
{
    [Serializable]
    public class Map
    {
        private Tile[,] tile;
        public Tile[,] Tile { get { return this.tile; } set { tile = value; } }
        private Hero hero;
        public Hero Hero { get { return this.hero; } set { hero = value; } }
        private Enemy[] enemyArr;
        public Enemy[] EnemyArr { get { return this.enemyArr; } set { enemyArr = value; } }
        
        private Item[] itemArr;// as part of question 3 Task 2
        public Item[] ItemArr { get { return this.itemArr; } set { itemArr = value; } }
        private int width;
        public int Width { get { return this.width; } set { width = value; } }

        private int height;
        public int Height { get { return this.height; } set { height = value; } }
        private Random random = new Random();
        public Random Random { get { return this.random; } set { random = value; } }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numberOfEnemies, int goldDrops, int weaponDrops)
        {
            this.Width = this.Random.Next(minWidth, maxWidth);
            this.Height = this.Random.Next(minHeight, maxHeight);
            this.EnemyArr = new Enemy[numberOfEnemies];
            this.ItemArr = new Item[goldDrops + weaponDrops];
            this.Tile = new Tile[this.Width, this.Height];
            Console.WriteLine("=======\nwidth: "+ this.width + "\n========\nheight: "+ this.height);

            //Spawning empty tiles
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Tile newEmpty = new EmptyTile(x, y);
                    tile[x, y] = newEmpty;
                }
            }

            //call create
            var h = Create(TileType.HERO);
            UpdateTile(h);

            //spawning barriers
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if (x == 0 || x == Width - 1 || y == 0 || y == Height - 1)
                    {
                        Tile newObstacle = Create(TileType.OBSTACLE);
                        newObstacle.X = x;
                        newObstacle.Y = y;
                        tile[x, y] = newObstacle;
                    }
                }    
            }

            //loop through enemies
            for (int i=0; i< numberOfEnemies; i++)
            {
                var enemy = Create(TileType.ENEMY);
                UpdateTile(enemy);
                enemyArr[i] = (Enemy)enemy;
            }

            //loop through items gold drop
            for (int i = 0; i < goldDrops; i++)
            {
                var gold = Create(TileType.GOLD);
                UpdateTile(gold);
                itemArr[i] = (Item)gold;
            }
            for (int i = 0; i < weaponDrops; i++)
            {
                var weapon = Create(TileType.WEAPON);
                UpdateTile(weapon);
                itemArr[i] = (Item)weapon;
            }
            //call update Vision
            UpdateVision();
        }

        public void UpdateTile(Tile tile)//own method to help update Tile
        {
            int previousX = tile.X;
            int previousY = tile.Y;
            //var previousTile = Tile[tile.X, tile.Y];
            Tile newEmpty = Create(TileType.EMPTY);
            newEmpty.X = previousX;
            newEmpty.Y = previousY;
            //tile[x, y] = newEmpty;
            Tile[previousX, previousY] = newEmpty;
            Tile[tile.X, tile.Y] = tile;
        }

        private Tile Create(TileType tileType)
        {
            int x = this.Random.Next(0, Width);
            int y = this.Random.Next(0, Height);
            while (tile[x, y].tileType != TileType.EMPTY)
            {
                x = this.Random.Next(0, Width);
                y = this.Random.Next(0, Height);
            }
            Console.WriteLine("=======\nH.X: " + x + "\n========\nH.Y: " + y);
            switch (tileType)
            {
                case TileType.HERO:
                    hero = new Hero(x, y, 10, 10, 0);
                    return hero;
                case TileType.ENEMY:
                    //Integration Question 3 Task 2
                    int enemyType = Random.Next(0, 3);
                    switch(enemyType)
                    {
                        case 0:
                            Goblin goblin = new Goblin(x, y);
                            return goblin;
                            break;
                        case 1:
                            Mage mage = new Mage(x, y);
                            return mage;
                            break;
                        case 2:
                            Leader leader = new Leader(x, y, TileType.ENEMY);
                            return leader;
                            break;
                    }
                    if (Random.Next(0,3) == 0)
                    {
                        Goblin goblin = new Goblin(x, y);
                        return goblin;
                    }
                    else
                    {
                        Mage mage = new Mage(x, y);
                        return mage;
                    }
                case TileType.GOLD://as for question 3 task 2
                    Gold gold = new Gold(x, y);
                    return gold;
                case TileType.WEAPON:
                    int randomWeaponNumber = random.Next(0, 4);
                    switch (randomWeaponNumber)
                    {
                        case 0:
                            return new MeleeWeapon(MeleeWeapon.MeleeWeaponTypes.DAGGER, x, y, TileType.WEAPON);
                            break;
                        case 1:
                            return new MeleeWeapon(MeleeWeapon.MeleeWeaponTypes.LONGSWORD, x, y, TileType.WEAPON);
                            break;
                        case 2:
                            return new RangedWeapon(RangedWeapon.RangedWeaponTypes.RIFLE, x, y, TileType.WEAPON);
                            break;
                        case 3:
                            return new RangedWeapon(RangedWeapon.RangedWeaponTypes.LONGBOW, x, y, TileType.WEAPON);
                            break;
                    }
                    return new MeleeWeapon(MeleeWeapon.MeleeWeaponTypes.DAGGER, x, y, TileType.WEAPON);
                    break;
                case TileType.OBSTACLE:
                    return new Obstacle(x, y);
                    break;
                case TileType.EMPTY:
                    return new EmptyTile(x, y);
                    break;
                default:
                    return null;
            }            
        }

        public void UpdateVision()
        {
            int x = 0, y = 0;
            
            //get position of Hero first
            for(int i = 0; i< width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    if(Tile[i,j] == Hero)
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            //update vision character 
            if (y < height - 1)
            {
                Hero.VisionArr[0] = Tile[x, y + 1];//up
            }
            else
            {
                Hero.VisionArr[0] = null;
            }
            if(x < width - 1)
            {
                Hero.VisionArr[1] = Tile[x + 1, y];//right
            }
            else
            {
                Hero.VisionArr[1] = null;
            }

            if (y > 1)
            {
                Hero.VisionArr[2] = Tile[x, y - 1];//down
            }
            else
            {
                Hero.VisionArr[2] = null;
            }

            if (x > 1)
            {
                Hero.VisionArr[3] = Tile[x - 1, y];//left
            }
            else
            {
                Hero.VisionArr[3] = null;
            }
        }
        
        public Item GetItemAtPosition(int x, int y)
        {
            var t = Tile[x, y];
            for (int i = 0; i < ItemArr.Length; i++)
            {
                if(ItemArr[i] == t)
                {
                    var result = ItemArr[i];
                    ItemArr[i] = null;
                    return result;
                }
            }
            return null;
        }
    }
}
