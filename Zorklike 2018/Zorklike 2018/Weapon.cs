using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace Zorklike2018
{
    public abstract class Weapon : Item
    {
        public double Dmg;
        public double Def;
    }
    
    
    public class Sword : Weapon
    {
        public override void Use()
        {
            Console.WriteLine("You can't use this item right now.");
        }

        public Sword(string name, double dmg, double def)
        {
            Name = name;
            Dmg = dmg;
            Def = def;
        }
    }
    public class Spear : Weapon
    
    {
        public override void Use()
        {
            Console.WriteLine("You can't use this item right now.");
        }

        public Spear(string name, double dmg, double def)
        {
            Name = name;
            Dmg = dmg;
            Def = def;
        }
    }
    public class Axe : Weapon
    {
        public override void Use()
        {
            Console.WriteLine("You can't use this item right now.");
        }

        public Axe(string name, double dmg, double def)
        {
            Name = name;
            Dmg = dmg;
            Def = def;
        }
    }
//


}