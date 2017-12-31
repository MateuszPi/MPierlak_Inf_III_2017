using System;
using System.Collections.Generic;

namespace Zorklike2018
{
    public class Game
    {
        static void Restart()
        {
            Console.WriteLine("You died \r\nDou you want to restart? [Y]es\t[N]o");
            var inputRestart = Console.ReadLine();
            if (inputRestart == "Y" || inputRestart == "y")
            {
                StartGame();
            }
            else if (inputRestart == "N" || inputRestart == "n")
            {
                return;
            }
            else
            {
                Console.WriteLine("Wrong Key.");
                Restart();
            }
        }


        public static void StartGame()
        {
            var hero = new Hero
            {
                Weapon = new Sword("Iron sword", 1, 1),
                Armour = new Armour("Leather armour", 3)
            };
            hero.Backpack.Add(new HealtPotion(25, hero)
            {
                Name = "Starting Health Potion 25",
            });


            var Lvl = new Level1(hero);
            var q = Lvl.startLevel();
            if (q == true)
            {
                Console.WriteLine("Grats! You have finished this game!");
            }
            else
            {
                Restart();
            }

        }
    }
}