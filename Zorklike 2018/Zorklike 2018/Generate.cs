using System;
using System.Collections.Generic;

namespace Zorklike2018
{
    public class Generate
    {
        private Hero _Hero{ get; set; }

        public Generate(Hero hero)
        {
            _Hero = hero;
        }

        private  List <Weapon> _listOfLegendaryWeapons = new List<Weapon>
        {
            new Sword("Sword of Armageddon", 100, 0),
            new Sword("the Notched Sword", 50, 50),
            new Sword("Braveheart", 75, 25),
            new Sword("Joyeuse", 80, 20),
            new Sword("Mercy", 91, 9),
            new Sword("Excalibur", 125, 50),
            new Axe("Aurum Axe", 100, 0),
            new Axe("Legendary Battle Axe", 90, 10),
            new Axe("Axe of Perun", 95, 5),
            new Spear("Gungnir", 50, 50),
            new Sword("True fake sword", 0, 0)
        };

        private List <Armour> _listOfLegendaryArmours = new List<Armour>
        {
            new Armour("Green Armour", 100),
            new Armour("Athenes Armour", 50)
        };
        
        public Weapon CreateNewRandomWeapon(string name, double dmg, double def, int type)
        {
            switch (type)
            {
                case 1:
                    name += "sword";
                    return new Sword(name, dmg, def);
                case 2:
                    name += "axe";
                    return new Axe(name, dmg, def);
                case 3:
                    name += "spear";
                    return new Spear(name, dmg, def);
                default:
                    return new Sword(name, dmg, def);
            }
        }
        
        private Armour createNewRandomArmour(string name, double def)
        {
             return new Armour(name, def);
        }
        
        

        public Weapon GenerateWeapon(int value)
        {
            var random = new Random();
            var isLegendary = random.Next(0, 100);
            if (isLegendary <= value)
            {
                var pickLegendary = random.Next(0, _listOfLegendaryWeapons.Count);
                var resultWeapon = _listOfLegendaryWeapons[pickLegendary];
                _listOfLegendaryWeapons.Remove(_listOfLegendaryWeapons[pickLegendary]);
                return resultWeapon;
            }
            if (value > 80)
            {
                return CreateNewRandomWeapon("Great ", random.Next(30, 60), random.Next(15, 30), random.Next(1, 3));
            }
            else if (value > 55)
            {
                return CreateNewRandomWeapon("Steel ", random.Next(18, 40), random.Next(8, 20), random.Next(1, 3));
            }
            else if (value > 30)
            {
                return CreateNewRandomWeapon("Iron ", random.Next(12, 30), random.Next(3, 12), random.Next(1, 3));
            }
            return CreateNewRandomWeapon("Wooden ", random.Next(0, 10), random.Next(0, 5), random.Next(1, 3));
        }
        public Armour GenerateArmour(int value)
        {
            var random = new Random();
            var isLegendary = random.Next(0, 100);
            if (isLegendary <= value)
            {
                var pickLegendary = random.Next(0, _listOfLegendaryArmours.Count);
                var resulArmour = _listOfLegendaryArmours[pickLegendary];
                _listOfLegendaryArmours.Remove(_listOfLegendaryArmours[pickLegendary]);
                return resulArmour;
;
            }
            if (value > 80)
            {
                return createNewRandomArmour("Great ", random.Next(30, 60));
            }
            else if (value > 55)
            {
                return createNewRandomArmour("Steel ", random.Next(18, 40));
            }
            else if (value > 30)
            {
                return createNewRandomArmour("Iron ", random.Next(12, 30));
            }
            return createNewRandomArmour("Leather ", random.Next(0, 10));
        }

        public Potion GeneratePotion(int value)
        {
            var random = new Random();
            var pickType = random.Next(0, 2);
            if (pickType == 0)
            {
                return new HealtPotion(random.Next(value, 100), _Hero);
            }
            var pickSkill = random.Next(0, 3);
            switch (pickSkill)
            {
                case 0:
                    return new SkillPotion("Strenght ", random.Next(value/10, 100), _Hero);
                case 1:
                    return new SkillPotion("Magic ", random.Next(value/10, 100), _Hero);
                case 2:
                    return new SkillPotion("Dexteriti ", random.Next(value/10, 100), _Hero);
                case 3:
                    return new SkillPotion("Charisma ", random.Next(value/10, 100), _Hero);
            }
            return new HealtPotion(random.Next(value, 100), _Hero);
        }

        public void GenerateLoot(int value, int type = 4)
        {
            var rnd = new Random();
            int lootType = rnd.Next(1, 4);
            if (lootType == 1)
            {
                var potion = GeneratePotion(value);
                Console.Clear();
                Console.WriteLine($"You got a {potion.Name}.");
                Console.WriteLine("Potion has been addet to your inventory.");
                _Hero.Backpack.Add(potion);
                Console.WriteLine("Press enter to continue.");
                Console.Read();
            }
            else if (lootType == 2)
            {
                var weapon = GenerateWeapon(value);
                Console.Clear();
                Console.WriteLine($"You got a {weapon.Name}.");
                Console.WriteLine($"New weapon stats:Damage: {weapon.Dmg} \t Defence: {weapon.Def}");
                Console.WriteLine($"Current weapon stats: Damage: {_Hero.Weapon.Dmg} \t Defence: {_Hero.Weapon.Def}");
                Console.WriteLine("Do you want to swich your weapon?\t[Y]es\t[N]o\r\n (Old weapon will no longer be available!)");
                var inpoutNewWeapon = Console.ReadLine();
                while (true)
                {
                    switch (inpoutNewWeapon)
                    {
                        case "y":
                        case "Y":
                            _Hero.Weapon = weapon;
                            return;
                        case "n":
                        case "N":
                            return;
                        default:
                            Console.WriteLine("Wrong key.");
                            break;
                    }
                }
            }
            else if (lootType == 3)
            {
                var armour = GenerateArmour(value);
                Console.Clear();
                Console.WriteLine($"You got a {armour.Name}.");
                Console.WriteLine($"New Armour stats: Defence: {armour.Def}");
                Console.WriteLine($"Current weapon stats: Defence: {_Hero.Armour.Def}");
                Console.WriteLine("Do you want to swich your armour?\t(Old armour will no longer be available!)");
                var inpoutNewWeapon = Console.ReadLine();
                while (true)
                {
                    switch (inpoutNewWeapon)
                    {
                        case "y":
                        case "Y":
                            _Hero.Armour = armour;
                            return;
                        case "n":
                        case "N":
                            return;
                        default:
                            Console.WriteLine("Wrong key.");
                            break;
                    }
                }
            }
            
        }
    }
}