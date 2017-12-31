using System;
using System.Collections.Generic;

namespace Zorklike2018
{
    public class Level2
    {
        private Hero _hero { get; set; }

        private MinorEnemy enemy0 = new MinorEnemy("Johns dad", 30, 6, 6, 5, 20, new Sword("Major Sword", 10, 7),
            new Armour("Minor Armour", 2));

        private MinorEnemy enemy1 = new MinorEnemy("Johns older brother older brother", 28, 7, 8, 5, 20,
            new Sword("Minor Sword", 2, 1),
            new Armour("Minor Armour", 2));
        
        private MinorEnemy enemy2 = new MinorEnemy("Jim", 32, 7, 7, 5, 30,
            new Sword("Minor Sword", 2, 1),
            new Armour("Minor Armour", 2));
        private MinorEnemy enemy8 = new MinorEnemy("Jack", 32, 7, 7, 5, 30,
            new Sword("Minor Sword", 2, 1),
            new Armour("Minor Armour", 2));
        
        private MinorEnemy enemy3 = new MinorEnemy("Bob", 34, 7, 7, 5, 30,
            new Sword("Minor Sword", 4, 1),
            new Armour("Minor Armour", 3));
        private MinorEnemy enemy9 = new MinorEnemy("Dylan", 34, 7, 7, 5, 30,
            new Sword("Minor Sword", 4, 1),
            new Armour("Minor Armour", 3));
        
        private MinorEnemy enemy4 = new MinorEnemy("Rob", 38, 7, 8, 5, 30,
            new Sword("Minor Sword", 4, 1),
            new Armour("Minor Armour", 3));
        private MinorEnemy enemy10 = new MinorEnemy("Tommy", 38, 8, 7, 5, 30,
            new Sword("Minor Sword", 4, 1),
            new Armour("Minor Armour", 3));
        
        private MinorEnemy enemy6 = new MinorEnemy("Frank", 42, 10, 8, 5, 30,
            new Sword("Minor Sword", 4, 1),
            new Armour("Minor Armour", 3));
        private MinorEnemy enemy12 = new MinorEnemy("Victor", 42, 10, 7, 5, 30,
            new Sword("Minor Sword", 4, 1),
            new Armour("Minor Armour", 3));
        
        private MinorEnemy enemy5 = new MinorEnemy("Rich", 45, 10, 10, 10, 30,
            new Sword("Minor Sword", 9, 8),
            new Armour("Minor Armour", 5));
        private MinorEnemy enemy11 = new MinorEnemy("Sam", 45, 10, 10, 10, 30,
            new Sword("Minor Sword", 9, 8),
            new Armour("Minor Armour", 5));
        
        private MinorEnemy enemy7 = new MinorEnemy("Gatekeeper1", 50, 10, 10, 10, 30,
            new Sword("Minor Sword", 9, 8),
            new Armour("Minor Armour", 5));
        private MinorEnemy enemy13 = new MinorEnemy("Gatekeeper2", 50, 10, 10, 10, 30,
            new Sword("Minor Sword", 9, 8),
            new Armour("Minor Armour", 5));
        private MinorEnemy enemy7n = new MinorEnemy("Gatekeeper3", 60, 10, 10, 10, 30,
            new Sword("Minor Sword", 12, 8),
            new Armour("Minor Armour", 5));
        private MinorEnemy enemy13e = new MinorEnemy("Gatekeeper4", 60, 10, 10, 10, 30,
            new Sword("Minor Sword", 12, 8),
            new Armour("Minor Armour", 5));

        private Boss boss = new Boss("Great Troll", 65, 12, 12, 0, 150, new Spear("Spuer Spear of Underworld", 15, 5),
            new Armour("Major Armour", 7), new Armour("Kings Armour", 35));

        private Battle _battle = new Battle();

        public Level2(Hero hero)
        {
            _hero = hero;
        }


        public bool startLevel()
        {
            Generate itemGenerate = new Generate(_hero);



            var room0 = new BetterRoom(enemy0, _hero, itemGenerate, _battle, 1, 0, 0, 40);
            var room1 = new BetterRoom(enemy1, _hero, itemGenerate, _battle, 2, 0, 8, 42);
            var room2 = new BetterRoom(enemy2, _hero, itemGenerate, _battle, 3, 0, 0, 44);
            var room3 = new BetterRoom(enemy3, _hero, itemGenerate, _battle, 4, 0, 6, 46);
            var room4 = new BetterRoom(enemy4, _hero, itemGenerate, _battle, 0, 0, 5, 48);
            var room5 = new BetterRoom(enemy5, _hero, itemGenerate, _battle, 0, 0, 7, 50);
            var room6 = new BetterRoom(enemy6, _hero, itemGenerate, _battle, 6, 0, 0, 52);
            var room7 = new BetterRoom(enemy7, _hero, itemGenerate, _battle, 14, 0, 16, 55);
            var room8 = new BetterRoom(enemy8, _hero, itemGenerate, _battle, 0, 0, 9, 44);
            var room9 = new BetterRoom(enemy9, _hero, itemGenerate, _battle, 12, 0, 10, 46);
            var room10 = new BetterRoom(enemy10, _hero, itemGenerate, _battle, 11, 0, 0, 48);
            var room11 = new BetterRoom(enemy11, _hero, itemGenerate, _battle, 13, 0, 0, 50);
            var room12 = new BetterRoom(enemy12, _hero, itemGenerate, _battle, 0, 0, 11, 52);
            var room13 = new BetterRoom(enemy13, _hero, itemGenerate, _battle, 16, 0, 15, 55);

            var room7n = new LootRoom(enemy7n, _hero, itemGenerate, _battle, new HealtPotion(100, _hero), 1);
            var room13e = new LootRoom(enemy13e, _hero, itemGenerate, _battle,
                new SkillPotion("Magic ", 10, _hero) {Name = "Epic Magic Potion 10"}, 1);

            var bossRoom = new BossRoom(boss, _hero, itemGenerate, _battle, 2);


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
            ListOfRooms.Add(room13);
            ListOfRooms.Add(room7n);
            ListOfRooms.Add(room13e);
            ListOfRooms.Add(bossRoom);

            int nextRoom = 0;
            Console.WriteLine("You are in level 2.");
            Console.WriteLine("Press enter to countinue");
            Console.Read();
            while (nextRoom >= 0)
            {
                
                int roomResult = ListOfRooms[nextRoom].VisitRoom();
                if (roomResult == 99)
                {
                    Console.WriteLine("99");
                    return new Level3(_hero).startLevel();
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













































