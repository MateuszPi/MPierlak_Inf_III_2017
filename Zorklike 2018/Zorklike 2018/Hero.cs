using System;
using System.Collections.Generic;


namespace Zorklike2018
{
    public class Hero
    {
        public string Name { get; }
        public double Hp { get; set; }
        public double Str { get; set; }
        public double Dxt { get; set; }
        public double Mag { get; set; }
        public double Cha { get; set; }
        public int Score { get; set; }
        public List<Item> Backpack = new List<Item>();
        public Weapon Weapon { get; set; }
        public Armour Armour { get; set; }
        
        public Hero()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            double startingStr = 0;
            double startingDxt = 0;
            double startingMag = 0;
            double startingCha = 0;
            Console.WriteLine("Distribute your skill points.");
            double skillPoints = 5;
            
            while (skillPoints > 0)
            {
                Console.WriteLine(
                    $"Skill points left\t\t:{skillPoints}\r\n" +
                    $"Type S for more Strenght\t:{startingStr} \r\nType D for more Dexterity\t:{startingDxt} \r\n" +
                    $"Type M for more Magic\t\t:{startingMag} \r\nType C for more Charisma\t:{startingCha}");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "S":
                    case "s":
                        startingStr++;
                        skillPoints--;
                        break;
                    case "D":
                    case "d":
                        startingDxt++;
                        skillPoints--;
                        break;
                    case "M":
                    case "m":
                        startingMag++;
                        skillPoints--;
                        break;
                    case "C":
                    case "c":
                        startingCha++;
                        skillPoints--;
                        break;
                    default:
                        Console.WriteLine("wrong key");
                        break;
                }
                Console.Clear();

            }
            Hp = 100;
            Str = startingStr;
            Dxt = startingDxt;
            Mag = startingMag;
            Cha = startingCha;
            Score = 0;
        }

        public void ShowSkillPoints()
        {
            Console.WriteLine(
                $"Type S for more Strenght\t:{Str} \r\nType D for more Dexterity\t:{Dxt} \r\n" +
                $"Type M for more Magic\t\t:{Mag} \r\nType C for more Charisma\t:{Cha}");
        }

        public void RiseSkill(string skill)
        {
            switch (skill)
            {
                    case "Str":
                        Str += 0.05;
                        break;
                    case "Dxt":
                        Dxt += 0.05;
                        break;
                    case "Mag":
                        Mag += 0.05;
                        break;
                    case "Cha":
                        Cha += 0.05;
                        break;
            }
        }

        public void AddToBackpack(Item item)
        {
            var count = Backpack.Count;
            if (count <= 20)
            {
                Backpack.Add(item);
                Console.WriteLine("Item addet do backpack.");
            }
            else
            {
                Console.WriteLine("Backpack is full");
            }
        }
    }
}