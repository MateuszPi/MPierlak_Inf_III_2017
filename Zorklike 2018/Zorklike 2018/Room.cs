using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;

namespace Zorklike2018
{

    public abstract class AbstractRoom
    {
        public abstract int VisitRoom();
    }
    
    public class Room
    {
        public Enemy Enemy { get; set; }
        public bool isLooted { get; set; }

        public Room(Enemy enemy)
        {
            Enemy = enemy;
            isLooted = false;
        }
    }

    public class BetterRoom : AbstractRoom
    {        
        public Enemy Enemy { get; set; }
        public bool isLooted { get; set; }
        public bool isVisited { get; set; }
        public Hero Hero { get; set; }
        public Generate ItemGenerator { get; set; }
        private Battle _Battle { get; set; }
        public int north { get; set; }
        public int west { get; set; }
        public int east { get; set; }
        public int lootValue { get; set; }
        
        
        public BetterRoom(Enemy enemy, Hero hero, Generate itemGenerator, Battle battle, int north, int west, int east, int lootValue)
        {
            Enemy = enemy;
            isLooted = false;
            isVisited = false;
            Hero = hero;
            ItemGenerator = itemGenerator;
            _Battle = battle;
            this.north = north;
            this.west = west;
            this.east = east;
            this.lootValue = lootValue;
        }

        public override int VisitRoom()
        {
            
            if (isVisited == false)
            {
                Console.WriteLine("You have enterd next room and entrence colapsed.");
                Console.WriteLine("Minor Enemy approaches.");
                bool battle = _Battle.MinorBattle(Hero, Enemy as MinorEnemy);
                if (battle == false)
                {
                    Console.WriteLine("You died");
                    return 0;
                }
                if (battle == true)
                {
                    Console.WriteLine("Victory!");
                    Console.WriteLine("Press enter to continue.");
                    Console.Read();
                    isVisited = true;
                }
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You see lootbox and one way into the north.");
                Console.WriteLine("[1] Check lootbox.");
                if (north != 0)
                Console.WriteLine("[2] Go north.");
                if (west != 0)
                Console.WriteLine("[3] Go west.");
                if (east != 0)
                Console.WriteLine("[4] Go east.");
                Console.WriteLine("[5] Use item.");

                var inpoutPostBattle = Console.ReadLine();
                switch (inpoutPostBattle)
                {
                    case "1":
                        if (isLooted == true)
                        {
                            Console.WriteLine("You have looted this room.");
                            Console.WriteLine("Press enter to continue.");
                            Console.Read();
                            break;
                        }
                        ItemGenerator.GenerateLoot(lootValue);
                        Console.WriteLine("Press enter to continue.");
                        Console.Read();
                        isLooted = true;
                        break;
                    case "2":
                        if (north !=0)
                            return north;
                        else
                            Console.WriteLine("Wrong direction");
                            break;
                    case "3":
                        if (west !=0)
                            return west;
                        else
                            Console.WriteLine("Wrong direction");
                        break;
                    case "4":
                        if (east !=0)
                            return east;
                        else
                            Console.WriteLine("Wrong direction");
                        break;
                    case "5":
                        _Battle.UseItem(Hero);
                        break;
                }
            }
        }
    }

    public class BossRoom : AbstractRoom
    {
        public Enemy Enemy { get; set; }
        public bool isLooted { get; set; }
        public Hero Hero { get; set; }
        public Generate ItemGenerator { get; set; }
        private Battle _Battle { get; set; }
        private int _BossNumber { get; set; }

        public BossRoom(Enemy enemy, Hero hero, Generate itemGenerator, Battle battle, int bossNumber)
        {
            Enemy = enemy;
            isLooted = false;
            Hero = hero;
            ItemGenerator = itemGenerator;
            _Battle = battle;
            _BossNumber = bossNumber;
        }
        
        public override int VisitRoom()
        {
            if (_BossNumber == 1)
                return Boss1();
            if (_BossNumber == 2)
                return Boss2();
            if (_BossNumber == 3)
                return Boss3();
            return 9999;
        }


        private int Boss1()
        {
            var itemGenerator = new Generate(Hero);
            Console.WriteLine("You have enterd next room and entrence colapsed.");
            Console.WriteLine("Boss approaches.");
            bool q = _Battle.FirstBossBattle(Hero, Enemy as Boss);
            if (q == false)
            {
                Console.WriteLine("You died");
                return 0;
            }
            Console.WriteLine("You have found Epic Health Potion 100!");
            var reward = Enemy.Reward as Weapon;
            Hero.Backpack.Add(new HealtPotion(100, Hero) {Name = "Epic Health Potion 100"});
            Console.WriteLine("Gate behind dead boss is now opend. You went deeper into the dougeons.");
            Console.WriteLine("Press enter to continue.");
            Console.Read();
            
            return 99;
        }

        private int Boss2()
        {
            var itemGenerator = new Generate(Hero);
            Console.WriteLine("You have enterd weastern room.");
            Console.WriteLine("Great Troll approaches.");
            bool q = _Battle.SecondBossFight(Hero, Enemy as Boss);
            if (q == false)
            {
                Console.WriteLine("You died");
                return 0;
            }
            if (q == true)
            {
                Console.WriteLine("Victory!");
            }
            Console.WriteLine("You have found new item!");
            itemGenerator.GenerateLoot(77);
            Console.WriteLine("New gates open. You have decided to go deeper into the dungeons");
            Console.WriteLine("Press enter to continue.");
            Console.Read();
            return 99;
        }

        private int Boss3()
        {
            var itemGenerator = new Generate(Hero);
            Console.WriteLine("You have enterd weastern room.");
            Console.WriteLine("Dragon approaches.");
            bool q = _Battle.ThirdBossFight(Hero, Enemy as Boss);
            if (q == false)
            {
                Console.WriteLine("You died");
                return 0;
            }
            if (q == true)
            {
                Console.WriteLine("Victory!");
                Console.WriteLine("Press enter to continue.");
                Console.Read();
            }
            return 999;
        }
        
    }
    public class LootRoom : AbstractRoom
    {
        public Enemy Enemy { get; set; }
        public bool isLooted { get; set; }
        public Hero Hero { get; set; }
        public Generate ItemGenerator { get; set; }
        public Item RoomRevard { get; set; }
        private Battle _Battle { get; set; }
        public int back { get; set; }
        private double _enemyStartingHp { get; set; }


        public LootRoom(Enemy enemy, Hero hero, Generate itemGenerator, Battle battle, Item roomRevard, int back)
        {
            Enemy = enemy;
            isLooted = false;
            Hero = hero;
            ItemGenerator = itemGenerator;
            _Battle = battle;
            this.back = back;
            RoomRevard = roomRevard;
            _enemyStartingHp = Enemy.Hp;
        }
        
        public override int VisitRoom()
        {
            if (isLooted == true)
            {
                Enemy.Hp = _enemyStartingHp;
            }
            var itemGenerator = new Generate(Hero);
            Console.WriteLine("You have enterd eastern room.");
            Console.WriteLine("Minor Enemy approaches.");
            bool q = _Battle.MinorBattle(Hero, Enemy as MinorEnemy);
            if (q == false)
            {
                Console.WriteLine("You died");
                return 0;
            }
            if (q == true)
            {
                Console.WriteLine("Victory!");
            }
            isLooted = true;
            Console.WriteLine($"You have found {RoomRevard.Name}! You can return to this room for more.");
            Hero.Backpack.Add(RoomRevard);
            Console.WriteLine("Press enter to continue.");
            Console.Read();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[1] Go back." +
                                  "[2] Use item.");
                var inpoutPostBattle = Console.ReadLine();
                switch (inpoutPostBattle)
                {
                    case "1":
                        return back;
                    case "2":
                        _Battle.UseItem(Hero);
                        break;
                }
            }
        }        
    }
}






























