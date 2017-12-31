using System;

namespace Zorklike2018
{
    public class Armour : Item
    {
        public double Def { get; set; }

        public override void Use()
        {
            Console.WriteLine("You can't use this item right now.");
        }

        public Armour(string name, double def)
        {
            Name = name;
            Def = def;
        }
    }
}