//using System;
//
//namespace Zorklike2018
//{
//    public class OldLevel2
//    {
//        private Hero _Hero { get; set; }
//        private Battle _battle = new Battle();
//
//        public Level2(Hero hero)
//        {
//            _Hero = hero;
//        }
//
//        public bool Room20()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room0 = new Room(new MinorEnemy("Johns dad", 35, 8, 7, 2, 20, new Sword("Major Sword", 10, 7),
//                new Armour("Minor Armour", 2)));
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
//                        itemGenerator.GenerateLoot(30);
//                        Room0.isLooted = true;
//                        break;
//                    case "2":
//                        return Room21();
//                    case "3":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//            return true;
//        }
//
//        public bool Room21()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room21 = new Room(new MinorEnemy("Johns older brother", 22, 3, 3, 2, 10, new Sword("Minor Sword", 2, 1),
//                new Armour("Minor Armour", 2)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room21.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and two doors.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go north. \r\n" +
//                                  "[3] Go east. \r\n" +
//                                  "[4] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room21.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(32);
//                        Room21.isLooted = true;
//                        break;
//                    case "2":
//                        return Room22();
//                    case "3":
//                        return Room28();
//                    case "4":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room28()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room28 = new Room(new MinorEnemy("Jim", 23, 3, 3, 2, 11, new Sword("Minor Sword", 3, 2),
//                new Armour("Minor Armour", 3)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room28.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and one way into the east.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go east. \r\n" +
//                                  "[3] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room28.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(34);
//                        Room28.isLooted = true;
//                        break;
//                    case "2":
//                        return Room29();
//                        break;
//                    case "3":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room29()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room29 = new Room(new MinorEnemy("Jack", 25, 4, 3, 4, 12, new Sword("Minor Sword", 4, 5),
//                new Armour("Minor Armour", 3)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room29.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and two doors.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go north. \r\n" +
//                                  "[3] Go east. \r\n" +
//                                  "[4] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room29.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(36);
//                        Room29.isLooted = true;
//                        break;
//                    case "2":
//                        return Room210();
//                        break;
//                    case "3":
//                        return Room211();
//
//                        break;
//                    case "4":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room210()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room210 = new Room(new MinorEnemy("Jack", 25, 4, 3, 4, 12, new Sword("Minor Sword", 4, 5),
//                new Armour("Minor Armour", 3)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room210.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and one way into the east.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go east. \r\n" +
//                                  "[3] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room210.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(36);
//                        Room210.isLooted = true;
//                        break;
//                    case "2":
//                        return Room212();
//                    case "3":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room211()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room211 = new Room(new MinorEnemy("TrapMan", 50, 7, 8, 9, 25, new Sword("Minor Sword", 9, 9),
//                new Armour("Minor Armour", 7)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room211.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and one way into the north.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go north. \r\n" +
//                                  "[3] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room211.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(40);
//                        Room211.isLooted = true;
//                        break;
//                    case "2":
//                        return Room212();
//                    case "3":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room212()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room212 = new Room(new MinorEnemy("Tommy", 30, 6, 6, 7, 22, new Sword("Minor Sword", 7, 5),
//                new Armour("Minor Armour", 5)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room212.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and two doors.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go north. \r\n" +
//                                  "[3] Go east. \r\n" +
//                                  "[3] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room212.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(40);
//                        Room212.isLooted = true;
//                        break;
//                    case "2":
//                        return Room213();
//                        break;
//                    case "3":
//                        bool nextRoom4w = Room212e();
//                        if (nextRoom4w == false)
//                        {
//                            return false;
//                        }
//                        break;
//                    case "4":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room212e()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room212e = new Room(new MinorEnemy("Leonard", 25, 1, 7, 2, 10, new Sword("Minor Sword", 1, 1), new Armour("Terrible Armour", 0)));
//            Console.WriteLine("You have enterd eastern room.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room212e.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            Console.WriteLine("You have found Epic Magic Potion 12! You can return to this room for more.");
//            _Hero.Backpack.Add(new SkillPotion("Magic ", 12, _Hero) {Name = "Epic Magic Potion 12"});
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
//        public bool Room213()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room213 = new Room(new MinorEnemy("Tommy", 30, 6, 6, 7, 22, new Sword("Minor Sword", 7, 5),
//                new Armour("Minor Armour", 5)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room213.Enemy as MinorEnemy);
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
//                Console.WriteLine("You see lootbox and one way into the north.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go north. \r\n" +
//                                  "[3] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room213.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(45);
//                        Room213.isLooted = true;
//                        break;
//                    case "2":
//                        return RoomBoss2();
//                    case "3":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room22()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room22 = new Room(new MinorEnemy("Bill", 28, 5, 5, 6, 20, new Sword("Minor Sword", 5, 4),
//                new Armour("Minor Armour", 4)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room22.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and one way into the north.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go north. \r\n" +
//                                  "[3] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room22.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(30);
//                        Room22.isLooted = true;
//                        break;
//                    case "2":
//                        return Room23();
//
//                    case "3":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room23()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room22 = new Room(new MinorEnemy("Bill", 28, 5, 5, 6, 20, new Sword("Minor Sword", 5, 4),
//                new Armour("Minor Armour", 4)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room22.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and two doors.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go north. \r\n" +
//                                  "[3] Go east. \r\n" +
//                                  "[4] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room22.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(32);
//                        Room22.isLooted = true;
//                        break;
//                    case "2":
//                        return Room24();
//
//                    case "3":
//                        return Room25();
//                    case "4":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room24()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room22 = new Room(new MinorEnemy("Bill", 28, 5, 5, 6, 20, new Sword("Minor Sword", 5, 4),
//                new Armour("Minor Armour", 4)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room22.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and one way into the east.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go east. \r\n" +
//                                  "[3] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room22.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(34);
//                        Room22.isLooted = true;
//                        break;
//                    case "2":
//                        return Room26();
//
//                    case "3":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room25()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room22 = new Room(new MinorEnemy("Bill", 28, 5, 5, 6, 20, new Sword("Minor Sword", 5, 4),
//                new Armour("Minor Armour", 4)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room22.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and one way into the north.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go north. \r\n" +
//                                  "[3] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room22.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(34);
//                        Room22.isLooted = true;
//                        break;
//                    case "2":
//                        return Room26();
//
//                    case "3":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room26()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room22 = new Room(new MinorEnemy("Bill", 28, 5, 5, 6, 20, new Sword("Minor Sword", 5, 4),
//                new Armour("Minor Armour", 4)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room22.Enemy as MinorEnemy);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("You see lootbox and two doors.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go north. \r\n" +
//                                  "[3] Go east. \r\n" +
//                                  "[4] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room22.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(36);
//                        Room22.isLooted = true;
//                        break;
//                    case "2":
//                        bool nextRoom4 = Room26n();
//                        if (nextRoom4 == false)
//                        {
//                            return false;
//                        }
//                        break;
//                    case "3":
//                        return Room27();
//
//                    case "4":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool Room26n()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room26n = new Room(new MinorEnemy("Leonard", 25, 1, 7, 2, 10, new Sword("Minor Sword", 1, 1), new Armour("Terrible Armour", 0)));
//            Console.WriteLine("You have enterd weastern room.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room26n.Enemy as MinorEnemy);
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
//            return true;
//        }
//        public bool Room27()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var Room27 = new Room(new MinorEnemy("Bill", 28, 5, 5, 6, 20, new Sword("Minor Sword", 5, 4),
//                new Armour("Minor Armour", 4)));
//            Console.WriteLine("You have enterd next room and entrence colapsed.");
//            Console.WriteLine("Minor Enemy approaches.");
//            bool q = _battle.MinorBattle(_Hero, Room27.Enemy as MinorEnemy);
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
//                Console.WriteLine("You see lootbox and one way into the east.");
//                Console.WriteLine("[1] Check lootbox. \r\n" +
//                                  "[2] Go east. \r\n" +
//                                  "[3] Use item. \r\n");
//                var inpoutPostBattle = Console.ReadLine();
//                switch (inpoutPostBattle)
//                {
//                    case "1":
//                        if (Room27.isLooted == true)
//                        {
//                            Console.WriteLine("You have looted this room.");
//                            Console.WriteLine("Press any key to continue.");
//                            Console.Read();
//                            break;
//                        }
//                        itemGenerator.GenerateLoot(40);
//                        Room27.isLooted = true;
//                        break;
//                    case "2":
////                        bool nextRoom4e = RoomBoss2();
////                        if (nextRoom4e == false)
////                        {
////                            return false;
////                        }
//                        return RoomBoss2();
//                        break;
//                    case "3":
//                        _battle.UseItem(_Hero);
//                        break;
//                }
//            }
//        }
//        public bool RoomBoss2()
//        {
//            var itemGenerator = new Generate(_Hero);
//            var RoomBoss2 = new Room(new Boss("SmallBoss", 65, 12, 12, 0, 150, new Spear("Spuer Spear of Underworld", 15, 5), new Armour("Major Armour", 7), new Armour("Kings Armour", 35)));
//            Console.WriteLine("You have enterd weastern room.");
//            Console.WriteLine("Great Troll approaches.");
//            bool q = _battle.SecondBossFight(_Hero, RoomBoss2.Enemy as Boss);
//            if (q == false)
//            {
//                Console.WriteLine("You died");
//                return false;
//            }
//            Console.WriteLine("You have found new item!");
//            itemGenerator.GenerateLoot(77);
//            Console.WriteLine("New gates open. You have decided to go deeper into the dungeons");
//            return true;
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
