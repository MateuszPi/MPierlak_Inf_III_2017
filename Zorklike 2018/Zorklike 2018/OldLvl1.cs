//using System;
//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Runtime.InteropServices.ComTypes;
//
//namespace Zorklike2018
//{
//    public class OldLevel1
//    {
//        private Hero _Hero { get; set; }
//        private Battle _battle = new Battle();
//
//        public OldLevel1(Hero hero)
//        {
//            _Hero = hero;
//        }
//
//        public bool Room0()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room0 = new Room(new MinorEnemy("John", 10, 1, 1, 0, 5, new Sword("Minor Sword", 1, 1),
//                new Armour("Minor Armour", 2)));
//            Console.WriteLine("You have enterd dangerous dungeon.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room0.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//
//            bool breakeFlag = false;
//            while (breakeFlag == false)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and one door.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go trough the door. \r\n" +
//                                  "[3] Use item");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room0.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(20);
//                        Room0.isLooted = true;
//                        break;
//                    case "2":
//                        return Room1();
//                    case "3":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//            return true;
//        }
//
//        public bool Room1()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room1 = new Room(new MinorEnemy("Rick", 15, 2, 2, 1, 7, new Sword("Minor Sword", 2, 1),
//                new Armour("Minor Armour", 2)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room1.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and three doors.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go north. \r\n" +
//                                  "[3] Go east. \r\n" +
//                                  "[4] Go west. \r\n" +
//                                  "[5] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room1.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.ReadKey();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(22);
//                        Room1.isLooted = true;
//                        break;
//                    case "2":
//                        return Room2();
//                    case "3":
//                        bool nextRoom1e = Room1e();
//                        if (nextRoom1e == false)
//                        {
//                            return false;
//                        }
//                        break;
//                    case "4":
//                        bool nextRoom1w = Room1w();
//                        if (nextRoom1w == false)
//                        {
//                            return false;
//                        }
//                        break;
//                    case "5":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//
//        public bool Room1e()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room1e = new Room(new MinorEnemy("Rick", 25, 4, 4, 2, 10, new Sword("Minor Sword", 3, 2),
//                new Armour("Minor Armour", 3)));
//            Console.WriteLine("You have enterd eastern room.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room1e.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            Console.WriteLine("You have found Epic Health Potion 100! You can return to this room for more.");
//            _Hero.Backpack.Add(new HealtPotion(100, _Hero) {Name = "Epic Health Potion 100"});
//            Console.WriteLine("Press any key to continue.");
//            Console.Read();
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("[1] Go back." +
//                                  "[2] Use item.");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        return true;
//                    case "2":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//
//        public bool Room1w()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room1w = new Room(new MinorEnemy("Brook", 25, 4, 4, 2, 10, new Sword("Minor Sword", 3, 2),
//                new Armour("Minor Armour", 3)));
//            Console.WriteLine("You have enterd weastern room.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room1w.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            Console.WriteLine("You have found Epic Strenght Potion 10! You can return to this room for more.");
//            _Hero.Backpack.Add(new SkillPotion("Strenght ", 10, _Hero) {Name = "Epic Strenght Potion 10"});
//            Console.WriteLine("Press any key to continue.");
//            Console.Read();
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("[1] Go back." +
//                                  "[2] Use item.");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        return true;
//                    case "2":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//
//        public bool Room2()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room2 = new Room(new MinorEnemy("Brook", 25, 4, 4, 2, 10, new Sword("Minor Sword", 3, 2),
//                new Armour("Minor Armour", 3)));
//            Console.WriteLine("You have enterd northern room.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room2.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and one door.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go trough the door. \r\n" +
//                                  "[3] Use item");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room2.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(24);
//                        Room2.isLooted = true;
//                        break;
//                    case "2":
//                        return Room3();
//                    case "3":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//
//        public bool Room3()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room3 = new Room(new MinorEnemy("Johns older brother", 22, 3, 3, 2, 10, new Sword("Minor Sword", 2, 1),
//                new Armour("Minor Armour", 2)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room3.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and three doors.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go north. \r\n" +
//                                  "[3] Go east. \r\n" +
//                                  "[4] Go west. \r\n" +
//                                  "[5] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room3.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(28);
//                        Room3.isLooted = true;
//                        break;
//                    case "2":
//                        return Room4();
//                    case "3":
//                        bool nextRoom1e = Room3e();
//                        if (nextRoom1e == false)
//                        {
//                            return false;
//                        }
//                        break;
//                    case "4":
//                        bool nextRoom1w = Room3w();
//                        if (nextRoom1w == false)
//                        {
//                            return false;
//                        }
//                        break;
//                    case "5":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room3e()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room3e = new Room(new MinorEnemy("Mike", 25, 4, 4, 2, 10, new Sword("Minor Sword", 3, 2), new Armour("Minor Armour", 3)));
//            Console.WriteLine("You have enterd weastern room.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room3e.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            itemGenerator.GenerateLoot(75);            
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("[1] Go back." +
//                                  "[2] Use item.");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        return true;
//                    case "2":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room3w()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room3w = new Room(new MinorEnemy("Leonard", 25, 1, 7, 2, 10, new Sword("Minor Sword", 1, 1), new Armour("Terrible Armour", 0)));
//            Console.WriteLine("You have enterd weastern room.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room3w.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            Console.WriteLine("You have found Epic Dexterity Potion 10! You can return to this room for more.");
//            _Hero.Backpack.Add(new SkillPotion("Dexterity ", 10, _Hero) {Name = "Epic Dexterity Potion 10"});
//            Console.WriteLine("Press any key to continue.");
//            Console.Read();
//            while (true)
//            {
//                Console.WriteLine("[1] Go back." +
//                                  "[2] Use item.");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        return true;
//                    case "2":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room4()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room4 = new Room(new MinorEnemy("Johns older brother older brother", 25, 4, 2, 2, 20, new Sword("Minor Sword", 2, 2), new Armour("Minor Armour", 2)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room4.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            Console.WriteLine("You have found Epic Health Potion 100! You can return to this room for more.");
//            _Hero.Backpack.Add(new HealtPotion(100, _Hero) {Name = "Epic Health Potion 100"});
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and three doors.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go north. \r\n" +
//                                  "[3] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room4.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(32);
//                        Room4.isLooted = true;
//                        break;
//                    case "2":
//                        return Room5();
//                    case "3":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room5()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room5 = new Room(new Boss("Prince", 35, 5, 5, 7, 30, new Spear("Spear of Underworld", 5, 0),new Armour("Super Armour", 4), new Axe("Super Battle Axe", 25, 10)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Boss approaches.");
//            bool q = _battle.FirstBossBattle(_Hero, Room5.Enemy as Boss);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            Console.WriteLine("You have found Epic Health Potion 100!");
//            var reward = Room5.Enemy.Reward as Weapon;
//            _Hero.Backpack.Add(new HealtPotion(100, _Hero) {Name = "Epic Health Potion 100"});
//            Console.WriteLine($"You have found {reward.Name}");
//            Console.WriteLine($"New weapon stats:Damage: {reward.Dmg} \t Defence: {reward.Def}");
//            Console.WriteLine($"Current weapon stats: Damage: {_Hero.Weapon.Dmg} \t Defence: {_Hero.Weapon.Def}");
//            Console.WriteLine("Do you want to swich your weapon?\t[Y]es\t[N]o\r\n (Old weapon will no longer be available!)");
//            var inpoutNewWeapon = Console.ReadLine();
//            bool flag = true;
//            while (flag == true)
//            {
//                Console.Clear();
//                switch (inpoutNewWeapon)
//                {
//                    case "y":
//                    case "Y":
//                        _Hero.Weapon = reward;
//                        flag = false;
//                        break;
//                    case "n":
//                    case "N":
//                        flag = false;
//                        break;
//                    default:
//                        Console.WriteLine("Wrong key.");
//                        break;
//                }
//            }
//            Console.WriteLine("Gate behind dead boss is now opend. You went deeper into the dougeons.");
//            var level2 = new Level2(_Hero);
//        }
//    }
//}
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
