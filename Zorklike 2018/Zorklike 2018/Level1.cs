using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Zorklike2018
{
    public class Level1
    {
        private Hero _hero { get; set; }

        private MinorEnemy enemy0 = new MinorEnemy("John", 10, 1, 1, 0, 5, new Sword("Minor Sword", 1, 1),
            new Armour("Minor Armour", 2));

        private MinorEnemy enemy1 = new MinorEnemy("Rick", 15, 2, 2, 1, 7, new Sword("Minor Sword", 2, 1),
            new Armour("Minor Armour", 2));

        private MinorEnemy enemy1w = new MinorEnemy("Brick", 25, 4, 4, 2, 10, new Sword("Minor Sword", 3, 2),
            new Armour("Minor Armour", 3));

        private MinorEnemy enemy1e = new MinorEnemy("Brook", 25, 4, 4, 2, 10, new Sword("Minor Sword", 3, 2),
            new Armour("Minor Armour", 3));

        private MinorEnemy enemy2 = new MinorEnemy("Brook jr.", 25, 4, 4, 2, 10, new Sword("Minor Sword", 3, 2),
            new Armour("Minor Armour", 3));

        private MinorEnemy enemy3 = new MinorEnemy("Johns older brother", 22, 3, 3, 2, 10,
            new Sword("Minor Sword", 2, 1), new Armour("Minor Armour", 2));

        private MinorEnemy enemy3e = new MinorEnemy("Mike", 25, 4, 4, 2, 10, new Sword("Minor Sword", 3, 2),
            new Armour("Minor Armour", 3));

        private MinorEnemy enemy3w = new MinorEnemy("Leonard", 25, 1, 7, 2, 10, new Sword("Minor Sword", 1, 1),
            new Armour("Terrible Armour", 0));

        private MinorEnemy enemy4 = new MinorEnemy("Johns older brother older brother", 25, 4, 2, 2, 20,
            new Sword("Minor Sword", 2, 2), new Armour("Minor Armour", 2));

        private Battle _battle = new Battle();

        private Boss levelBoss = new Boss("Prince", 35, 5, 5, 7, 30, new Spear("Spear of Underworld", 5, 0),
            new Armour("Super Armour", 4), new Axe("Super Battle Axe", 25, 10));


        public Level1(Hero hero)
        {
            _hero = hero;
        }

        public bool startLevel()
        {
            Generate itemGenerate = new Generate(_hero);

            var room0 = new BetterRoom(enemy0, _hero, itemGenerate, _battle, 1, 0, 0, 20);
            var room1 = new BetterRoom(enemy1, _hero, itemGenerate, _battle, 2, 6, 7, 24);
            var room2 = new BetterRoom(enemy2, _hero, itemGenerate, _battle, 3, 0, 0, 28);
            var room3 = new BetterRoom(enemy3, _hero, itemGenerate, _battle, 4, 8, 9, 32);
            var room4 = new BetterRoom(enemy4, _hero, itemGenerate, _battle, 5, 0, 0, 36);

            var room1w = new LootRoom(enemy1w, _hero, itemGenerate, _battle, new HealtPotion(100, _hero), 1);
            var room1e = new LootRoom(enemy1e, _hero, itemGenerate, _battle, new SkillPotion("Strenght ", 10, _hero){Name = "Epic Strenght Potion 10"}, 1);
            var room3w = new LootRoom(enemy3w, _hero, itemGenerate, _battle, new SkillPotion("Dexteriti ", 10, _hero){Name = "Epic Dexterity Potion 10"}, 3);
            var room3e = new LootRoom(enemy3e, _hero, itemGenerate, _battle, new HealtPotion(100, _hero), 3);

            var bossRoom = new BossRoom(levelBoss, _hero, itemGenerate, _battle, 1);

            List<AbstractRoom> ListOfRooms = new List<AbstractRoom>();
            ListOfRooms.Add(room0);
            ListOfRooms.Add(room1);
            ListOfRooms.Add(room2);
            ListOfRooms.Add(room3);
            ListOfRooms.Add(room4);
            ListOfRooms.Add(bossRoom);//5
            ListOfRooms.Add(room1w);//6
            ListOfRooms.Add(room1e);//7
            ListOfRooms.Add(room3w);//8
            ListOfRooms.Add(room3e);//9


            int nextRoom = 0;

            while (nextRoom >= 0)
            {
                int roomResult = ListOfRooms[nextRoom].VisitRoom();
                if (roomResult == 99)
                {
                    return new Level2(_hero).startLevel();
                }
                if (roomResult == 0)
                {
                    Console.WriteLine("9");
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



































