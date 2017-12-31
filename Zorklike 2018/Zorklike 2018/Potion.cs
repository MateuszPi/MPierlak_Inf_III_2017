using System;
using System.Security;

namespace Zorklike2018
{
    public abstract class Potion : Item
    {
        public int PotionPower;
        public Hero Hero;
    }

    public class HealtPotion : Potion
    {
        public HealtPotion(int potionPower, Hero hero)
        {
            Name = $"Health potion {potionPower}";
            PotionPower = potionPower;
            Hero = hero;
        }

        public override void Use()
        {
            Hero.Hp += PotionPower;
            Console.Clear();
            Console.WriteLine($"health restored\tHP:{Hero.Hp}");
        }

//        public void Use(Hero hero)
//        {
//            hero.Hp += PotionPower;
//            Console.WriteLine($"health restored\tHP:{hero.Hp}");
//        }
    }

    public class SkillPotion : Potion
    {
        private string Type { get; set; }

        public SkillPotion(string type, int potionPower, Hero hero)
        {
            Type = type;
            Name = $"{type} potion +{potionPower}";
            PotionPower = potionPower;
            Hero = hero;
        }

        public override void Use()
        {
            switch (Type)
            {
                case "Strenght ":
                    Hero.Str += PotionPower;
                    Console.Clear();
                    Console.WriteLine($"Skill points added\tHP:{Hero.Str}");
                    break;
                case "Magic ":
                    Hero.Mag += PotionPower;
                    Console.Clear();
                    Console.WriteLine($"Skill points added\tHP:{Hero.Mag}");
                    break;
                case "Dexteriti ":
                    Hero.Dxt += PotionPower;
                    Console.Clear();
                    Console.WriteLine($"Skill points added\tHP:{Hero.Dxt}");
                    break;
                case "Charisma ":
                    Hero.Cha += PotionPower;
                    Console.Clear();
                    Console.WriteLine($"Skill points added\tHP:{Hero.Cha}");
                    break;
            }
        }

//        public void Use(Hero hero)
//        {
//            switch (Type)
//            {
//                case "Strenght ":
//                    hero.Str += PotionPower;
//                    break;
//                case "Magic ":
//                    hero.Mag += PotionPower;
//                    break; 
//                case "Dexteriti ":
//                    hero.Dxt += PotionPower;
//                    break;
//                case "Charisma ":
//                    hero.Cha += PotionPower;
//                    break;
//            }
//        }
    }
}