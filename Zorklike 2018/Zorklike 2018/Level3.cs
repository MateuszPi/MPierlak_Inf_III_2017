using System;
using System.Collections.Generic;

namespace Zorklike2018
{
    public class Level3
    {
        private Hero _hero { get; set; }

        
        private MinorEnemy enemy0 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        
        private MinorEnemy enemy1 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        
        private MinorEnemy enemy2 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        private MinorEnemy enemy9 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        
        private MinorEnemy enemy3 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        private MinorEnemy enemy10 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        private MinorEnemy enemy13 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        
        private MinorEnemy enemy11 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        
        private MinorEnemy enemy12 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        
        private MinorEnemy enemy4 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        private MinorEnemy enemy14 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        
        private MinorEnemy enemy5 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        
        private MinorEnemy enemy6 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        
        private MinorEnemy enemy7 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        private MinorEnemy enemy15 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        
        private MinorEnemy enemy8 = new MinorEnemy("Johns mom", 50, 7, 8, 8, 30, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));
        
        private Boss boss = new Boss("Dragon", 100, 40, 40, 0, 150, new Spear("None", 0, 0),
            new Armour("None", 0), new Armour("Emperor Armour", 35));

        private Battle _battle = new Battle();
        
        public Level3(Hero hero)
        {
            _hero = hero;
        }

        public bool startLevel()
        {
            Generate itemGenerate = new Generate(_hero);

            var room0 = new BetterRoom(enemy0, _hero, itemGenerate, _battle, 0, 1, 0, 60);
            var room1 = new BetterRoom(enemy1, _hero, itemGenerate, _battle, 2, 9, 8, 62);
            var room2 = new BetterRoom(enemy2, _hero, itemGenerate, _battle, 3, 0, 0, 64);
            var room3 = new BetterRoom(enemy3, _hero, itemGenerate, _battle, 4, 0, 13, 66);
            var room4 = new BetterRoom(enemy4, _hero, itemGenerate, _battle, 5, 14, 0, 68);
            var room5 = new BetterRoom(enemy5, _hero, itemGenerate, _battle, 0, 0, 6, 70);
            var room6 = new BetterRoom(enemy6, _hero, itemGenerate, _battle, 7, 0, 0, 72);
            var room7 = new BetterRoom(enemy7, _hero, itemGenerate, _battle, 8, 0, 15, 75);
            var room8 = new BetterRoom(enemy8, _hero, itemGenerate, _battle, 15, 0, 0, 80);
            var room9 = new BetterRoom(enemy9, _hero, itemGenerate, _battle, 0, 10, 0, 75);
            var room10 = new BetterRoom(enemy10, _hero, itemGenerate, _battle, 11, 0, 0, 75);
            var room11 = new BetterRoom(enemy11, _hero, itemGenerate, _battle, 12, 0, 0, 75);
            var room12 = new BetterRoom(enemy12, _hero, itemGenerate, _battle, 0, 0, 3, 75);
            var room3e = new LootRoom(enemy13, _hero, itemGenerate, _battle, new SkillPotion("Magic", 10, _hero){Name = "Epic Magic Potion 10"}, 3 );
            var room4w = new LootRoom(enemy14, _hero, itemGenerate, _battle, new SkillPotion("Magic", 10, _hero){Name = "Epic Magic Potion 10"}, 4 );
            var room7e = new LootRoom(enemy15, _hero, itemGenerate, _battle, new SkillPotion("Magic", 10, _hero){Name = "Epic Magic Potion 10"}, 7 );
            var bossRoom = new BossRoom(boss, _hero, itemGenerate, _battle, 3);

            
            List<AbstractRoom> ListOfRooms = new List<AbstractRoom>();
            ListOfRooms.Add(room0);
            ListOfRooms.Add(room1);
            ListOfRooms.Add(room2);
            ListOfRooms.Add(room3);
            ListOfRooms.Add(room4);
            ListOfRooms.Add(room5);
            ListOfRooms.Add(room6);
            ListOfRooms.Add(room7);
            ListOfRooms.Add(room8);
            ListOfRooms.Add(room9);
            ListOfRooms.Add(room10);
            ListOfRooms.Add(room11);
            ListOfRooms.Add(room12);
            ListOfRooms.Add(room3e);
            ListOfRooms.Add(room7e);
            ListOfRooms.Add(bossRoom);
            
            int nextRoom = 0;
            Console.WriteLine("You are in level 3.");
            Console.WriteLine("Press enter to countinue");
            while (nextRoom >= 0)
            {
                int roomResult = ListOfRooms[nextRoom].VisitRoom();
                if (roomResult == 99)
                {
                    Console.WriteLine("999");
                    return true;
                }
                if (roomResult == 0)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine($"Continue{roomResult}");
                    nextRoom = roomResult;
                }
            }
            return true;
            
            
            
            
            
            
            
            
            
            
        }



























































    }
}