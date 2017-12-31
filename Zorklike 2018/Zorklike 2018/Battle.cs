using System;
using System.Xml;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;


namespace Zorklike2018
{
    public class Battle
    {
        public bool MinorBattle(Hero hero, MinorEnemy minorEnemy)
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine(
                    "----------------------------------------------------------------------------------------------");
                Console.WriteLine($"Your stats:" +
                                  $"HP: {hero.Hp}|" +
                                  $"STR: {hero.Str}|" +
                                  $"DXT: {hero.Dxt}|" +
                                  $"MAG: {hero.Mag}|" +
                                  $"CHA: {hero.Cha}|" +
                                  $"WEAPON: [DMG] {hero.Weapon.Dmg}|[DEF] {hero.Weapon.Def}" +
                                  $"ARMOUR: [DEF] {hero.Armour.Def}]");
                Console.WriteLine($"Enemy stats:" +
                                  $"HP: {minorEnemy.Hp}|" +
                                  $"MENTAL: {minorEnemy.Cha}|" +
                                  $"STR: {minorEnemy.Str}|" +
                                  $"DXT: {minorEnemy.Dxt}|" +
                                  $"MAG: {minorEnemy.Mag}|" +
                                  $"WEAPON: [DMG] {minorEnemy.EnemyWeapon.Dmg}|[DEF] {minorEnemy.EnemyWeapon.Def}" +
                                  $"ARMOUR: [DEF] {minorEnemy.EnemyArmour.Def}]");
                Console.WriteLine(
                    "----------------------------------------------------------------------------------------------");
                HerosAttack(hero, minorEnemy);
                if (minorEnemy.Hp <= 0 || minorEnemy.Cha <= 0)
                {
                    return true;
                }
                MinorEnemyAttack(hero, minorEnemy);
                if (hero.Hp <= 0)
                {
                    return false;
                }
            }
        }

        public bool FirstBossBattle(Hero hero, Boss boss)
        {
            while (true)
            {
                Console.WriteLine(
                    "----------------------------------------------------------------------------------------------");
                Console.WriteLine($"Your stats:" +
                                  $"HP: {hero.Hp}|" +
                                  $"STR: {hero.Str}|" +
                                  $"DXT: {hero.Dxt}|" +
                                  $"MAG: {hero.Mag}|" +
                                  $"CHA: {hero.Cha}|" +
                                  $"WEAPON: [DMG] {hero.Weapon.Dmg}|[DEF] {hero.Weapon.Def}" +
                                  $"ARMOUR: [DEF] {hero.Armour.Def}]");
                Console.WriteLine($"Enemy stats:" +
                                  $"HP: {boss.Hp}|" +
                                  $"MENTAL: {boss.Cha}|" +
                                  $"STR: {boss.Str}|" +
                                  $"DXT: {boss.Dxt}|" +
                                  $"MAG: {boss.Mag}|" +
                                  $"WEAPON: [DMG] {boss.EnemyWeapon.Dmg}|[DEF] {boss.EnemyWeapon.Def}" +
                                  $"ARMOUR: [DEF] {boss.EnemyArmour.Def}]");
                Console.WriteLine(
                    "----------------------------------------------------------------------------------------------");
                HerosAttack(hero, boss);
                if (boss.Hp <= 0 || boss.Cha <= 0)
                {
                    return true;
                }
                FirstBossAttack(hero, boss);
                if (hero.Hp <= 0)
                {
                    return false;
                }
            }
        }

        public bool SecondBossFight(Hero hero, Boss boss)
        {
            boss.SubHp1 = 25;
            boss.SubHp2 = 25;
            boss.SubHp3 = 25;
            while (true)
            {
                Console.WriteLine(
                    "----------------------------------------------------------------------------------------------");
                Console.WriteLine($"Your stats:" +
                                  $"HP: {hero.Hp}|" +
                                  $"STR: {hero.Str}|" +
                                  $"DXT: {hero.Dxt}|" +
                                  $"MAG: {hero.Mag}|" +
                                  $"CHA: {hero.Cha}|" +
                                  $"WEAPON: [DMG] {hero.Weapon.Dmg}|[DEF] {hero.Weapon.Def}" +
                                  $"ARMOUR: [DEF] {hero.Armour.Def}]");
                Console.WriteLine($"Enemy stats:" +
                                  $"HP: {boss.Hp}|" +
                                  $"MENTAL: {boss.Cha}|" +
                                  $"STR: {boss.Str}|" +
                                  $"DXT: {boss.Dxt}|" +
                                  $"MAG: {boss.Mag}|" +
                                  $"WEAPON: [DMG] {boss.EnemyWeapon.Dmg}|[DEF] {boss.EnemyWeapon.Def}" +
                                  $"ARMOUR: [DEF] {boss.EnemyArmour.Def}]");
                Console.WriteLine(
                    "----------------------------------------------------------------------------------------------");
                Console.WriteLine(
                    "----------------------------------------------------------------------------------------------");
                Console.WriteLine($"Torso: {boss.SubHp1}" +
                                  $"\tLegs: {boss.SubHp2}" +
                                  $"\tArms: {boss.SubHp3}");
                Console.WriteLine(
                    "----------------------------------------------------------------------------------------------");
                HerosAttackOnBoss(hero, boss);
                if (boss.Hp <= 0 || boss.Cha <= 0)
                {
                    return true;
                }
                SecondBossAttack(hero, boss);
                if (hero.Hp <= 0)
                {
                    return false;
                }
            }
        }
        
        public bool ThirdBossFight(Hero hero, Boss boss)
        {
            boss.SubHp1 = 25;
            boss.SubHp2 = 25;
            boss.SubHp3 = 25;
            boss.SubHp4 = 25;
            boss.SubHp5 = 25;

            while (true)
            {
                Console.WriteLine(
                    "----------------------------------------------------------------------------------------------");
                Console.WriteLine($"Your stats:" +
                                  $"HP: {hero.Hp}|" +
                                  $"STR: {hero.Str}|" +
                                  $"DXT: {hero.Dxt}|" +
                                  $"MAG: {hero.Mag}|" +
                                  $"CHA: {hero.Cha}|" +
                                  $"WEAPON: [DMG] {hero.Weapon.Dmg}|[DEF] {hero.Weapon.Def}" +
                                  $"ARMOUR: [DEF] {hero.Armour.Def}]");
                Console.WriteLine($"Enemy stats:" +
                                  $"HP: {boss.Hp}|" +
                                  $"MENTAL: {boss.Cha}|" +
                                  $"STR: {boss.Str}|" +
                                  $"DXT: {boss.Dxt}|" +
                                  $"MAG: {boss.Mag}|" +
                                  $"WEAPON: [DMG] {boss.EnemyWeapon.Dmg}|[DEF] {boss.EnemyWeapon.Def}" +
                                  $"ARMOUR: [DEF] {boss.EnemyArmour.Def}]");
                Console.WriteLine(
                    "----------------------------------------------------------------------------------------------");
                Console.WriteLine(
                    "----------------------------------------------------------------------------------------------");
                Console.WriteLine($"Torso: {boss.SubHp1}" +
                                  $"\tFront legs: {boss.SubHp2}" +
                                  $"\tBack legs: {boss.SubHp3}" +
                                  $"\tTail: {boss.SubHp4}" +
                                  $"\tWings: {boss.SubHp5}");
                Console.WriteLine(
                    "----------------------------------------------------------------------------------------------");
                HerosAttackOnDragon(hero, boss);
                if (boss.Hp <= 0 || boss.Cha <= 0)
                {
                    return true;
                }
                SecondBossAttack(hero, boss);
                if (hero.Hp <= 0)
                {
                    return false;
                }
            }
        }

        private void HerosAttack(Hero hero, Enemy enemy)
        {
            while (true)
            {
            Console.WriteLine("Chose your attack:\r\n" +
                              "[1]: Physical attack.\r\n" +
                              "[2]: Magicla attack.\r\n" +
                              "[3]: Try to convince your enemy to yield.\r\n" +
                              "[4]: Use item.");
            var input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(
                "----------------------------------------------------------------------------------------------");
            
                switch (input)
                {
                    case "1":
                        PhysicalAttack(hero, enemy);
                        return;
                    case "2":
                        MagicAttack(hero, enemy);
                        return;
                    case "3":
                        CharismaAttack(hero, enemy);
                        return;
                    case "4":
                        UseItem(hero);
                        return;
                    default:
                        Console.WriteLine("Wrong key");
                        break;
                }
            }
        }

         private void HerosAttackOnDragon(Hero hero, Boss boss)
        {
            Console.WriteLine("Chose your attack:\r\n" +
                              "[1]: Physical attack.\r\n" +
                              "[2]: Magicla attack.\r\n" +
                              "[3]: Try to convince your enemy to yield.\r\n" +
                              "[4]: Use item.");
            var input1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(
                "----------------------------------------------------------------------------------------------");
            if ((input1 == "2" || input1 == "1") && (boss.SubHp1 > 0 || boss.SubHp2 > 0 || boss.SubHp3 > 0))
            {
                Console.WriteLine("Pick Target:");
                if (boss.SubHp1>0)
                    Console.WriteLine("[1]: Torso.");
                if (boss.SubHp2>0)
                    Console.WriteLine("[2]: Front legs.");
                if (boss.SubHp3>0)
                    Console.WriteLine("[3]: Back legs.");
                if (boss.SubHp4>0)
                    Console.WriteLine("[4]: Tail legs.");
                if (boss.SubHp5>0)
                    Console.WriteLine("[5]: Wings.");
                var input2 = Console.ReadLine();
                TargetAttack(input1, input2, hero, boss);

            }
            else
            {
                while (true)
                {
                    switch (input1)
                    {
                        case "1":
                            PhysicalAttack(hero, boss);
                            return;
                        case "2":
                            MagicAttack(hero, boss);
                            return;
                        case "3":
                            CharismaAttack(hero, boss);
                            return;
                        case "4":
                            UseItem(hero);
                            return;
                        default:
                            Console.WriteLine("Wrong key");
                            break;
                    }
                }
            }
        }
        private void HerosAttackOnBoss(Hero hero, Boss boss)
        {
            Console.WriteLine("Chose your attack:\r\n" +
                              "[1]: Physical attack.\r\n" +
                              "[2]: Magicla attack.\r\n" +
                              "[3]: Try to convince your enemy to yield.\r\n" +
                              "[4]: Use item.");
            var input1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(
                "----------------------------------------------------------------------------------------------");
            if ((input1 == "2" || input1 == "1") && (boss.SubHp1 > 0 || boss.SubHp2 > 0 || boss.SubHp3 > 0))
            {
                Console.WriteLine("Pick Target:");
                if (boss.SubHp1>0)
                    Console.WriteLine("[1]: Torso.");
                if (boss.SubHp2>0)
                    Console.WriteLine("[2]: Legs.");
                if (boss.SubHp3>0)
                    Console.WriteLine("[3]: Arms.");
                var input2 = Console.ReadLine();
                TargetAttack(input1, input2, hero, boss);

            }
            else
            {
                while (true)
                {
                    switch (input1)
                    {
                        case "1":
                            PhysicalAttack(hero, boss);
                            return;
                        case "2":
                            MagicAttack(hero, boss);
                            return;
                        case "3":
                            CharismaAttack(hero, boss);
                            return;
                        case "4":
                            UseItem(hero);
                            return;
                        default:
                            Console.WriteLine("Wrong key");
                            break;
                    }
                }
            }
        }

        private void TargetAttack(string input1, string input2 , Hero hero, Boss boss)
        {
            double herosAttack;
            double enemyDeffence;
            var random = new Random();
            double criticalMulti = 1;
            var criticalRnd = random.Next(1, 100);
            double diffMulti = 1;
            if (hero.Hp <= 20)
            {
                if (criticalRnd <= hero.Dxt * 4)
                {
                    Console.WriteLine("CRITICAL HIT!");
                    Console.WriteLine(criticalRnd);
                    criticalMulti = hero.Dxt;
                    diffMulti = 4;
                }
            }
            if (input1 == "1")
            {
                herosAttack =
                    (random.Next(0, Convert.ToInt32(hero.Str + 1)) + hero.Weapon.Dmg) * criticalMulti * diffMulti +
                    0.2 * hero.Hp;
                enemyDeffence = 0.125 * boss.Str + 0.25 * boss.Dxt + boss.EnemyArmour.Def + boss.EnemyWeapon.Def + boss.SubHp3 * 0.125;
            }
            else if (input1 == "2")
            {
                herosAttack = random.Next(0, Convert.ToInt32(hero.Mag + 1)) * criticalMulti * diffMulti;
                enemyDeffence = 0.25 * boss.Mag + 0.5 * boss.Dxt + boss.EnemyArmour.Def;
            }
            else
            {
                herosAttack = 1;
                enemyDeffence = 0;
            }
            var attackPower = herosAttack - enemyDeffence;
            
            if (!(attackPower >= 0))
            {
                Console.WriteLine($"Missed.");
                return;
            }
            hero.Str += 0.2;
            hero.Dxt += 0.15;
            Console.WriteLine($"Your turn: {attackPower} points of physical damage.");
            switch (input2)
            {
                case "1":
                    boss.SubHp1 -= attackPower;
                    if (boss.SubHp1 < 0)
                    {
                        boss.SubHp1 = 0;
                    }
                    break;
                case "2":
                    boss.SubHp2 -= attackPower;
                    if (boss.SubHp2 < 0)
                    {
                        boss.SubHp2 = 0;
                    }
                    break;
                case "3":
                    boss.SubHp3 -= attackPower;
                    if (boss.SubHp3 < 0)
                    {
                        boss.SubHp3 = 0;
                    }
                    break;
            }
        }
        
        private void PhysicalAttack(Hero hero, Enemy enemy)
        {
            var random = new Random();
            double criticalMulti = 1;
            var criticalRnd = random.Next(1, 100);
            double diffMulti = 1;
            if (hero.Hp <= 20)
            {
                if (criticalRnd <= hero.Dxt * 4)
                {
                    Console.WriteLine("CRITICAL HIT!");
                    Console.WriteLine(criticalRnd);
                    criticalMulti = hero.Dxt;
                    diffMulti = 4;
                }
            }
            if (criticalRnd <= hero.Dxt)
            {
                Console.WriteLine("CRITICAL HIT!");
                criticalMulti = hero.Dxt;
            }
            var herosAttack =
                (random.Next(0, Convert.ToInt32(hero.Str + 1)) + hero.Weapon.Dmg) * criticalMulti * diffMulti +
                0.02 * hero.Hp;
            var enemyDeffence = 0.25 * enemy.Str + 0.5 * enemy.Dxt + enemy.EnemyArmour.Def + enemy.EnemyWeapon.Def;
            var attackPower = herosAttack - enemyDeffence;
            if (!(attackPower >= 0))
            {
                Console.WriteLine($"Missed.");
                return;
            }
            hero.Str += 0.2;
            hero.Dxt += 0.15;
            Console.WriteLine($"Your turn: {attackPower} points of physical damage.");
            enemy.Hp -= attackPower;
        }

        private void MagicAttack(Hero hero, Enemy enemy)
        {
            var random = new Random();
            double criticalMulti = 1;
            var criticalRnd = random.Next(1, 100);
            double diffMulti = 1;
            if (hero.Hp <= 20)
            {
                if (criticalRnd <= hero.Dxt * 4)
                {
                    Console.WriteLine("CRITICAL HIT!");
                    Console.WriteLine(criticalRnd);
                    criticalMulti = hero.Dxt;
                    diffMulti = 4;
                }
            }
            if (criticalRnd <= hero.Dxt)
            {
                Console.WriteLine("CRITICAL HIT!");
                criticalMulti = hero.Dxt;
            }
            var herosAttack = random.Next(0, Convert.ToInt32(hero.Mag + 1)) * criticalMulti * diffMulti;
            var enemyDeffence = 0.25 * enemy.Mag + 0.5 * enemy.Dxt + enemy.EnemyArmour.Def;
            var attackPower = herosAttack - enemyDeffence;
            if (!(attackPower >= 0))
            {
                Console.WriteLine($"Your turn: Missed.");
                return;
            }
            hero.Mag += 0.2;
            hero.Dxt += 0.1;
            Console.WriteLine($"Your turn: {attackPower} points of physical damage.");
            enemy.Hp -= attackPower;
        }

        private void CharismaAttack(Hero hero, Enemy enemy)
        {
            var random = new Random();
            var attackPower = random.Next(0, Convert.ToInt32(hero.Cha));
            hero.Cha += 0.3;
            enemy.Cha -= attackPower;
            Console.WriteLine($"Your turn:: {attackPower} points of physical damage.");
        }

        private void MinorEnemyAttack(Hero hero, MinorEnemy minorEnemy)
        {
            double diffMulti = 1;
            if (hero.Hp <= 20)
            {
                diffMulti = 0.45;
            }
            var random = new Random();
            var enemyAttack = random.Next(1, Convert.ToInt32(minorEnemy.Str + 1)) +
                              minorEnemy.EnemyWeapon.Dmg * diffMulti + 0.4 * minorEnemy.Hp;
            var herosDeffence = 0.25 * hero.Str + 0.5 * hero.Dxt + hero.Armour.Def + hero.Weapon.Def;
            var attackPower = enemyAttack - herosDeffence;
            if (!(attackPower >= 0))
            {
                Console.WriteLine($"Enemy turn: Missed.");
                return;
            }
            hero.Hp -= attackPower;
            Console.WriteLine($"Enemy turn: {attackPower} points of damage");
        }

        private void FirstBossAttack(Hero hero, Boss boss)
        {
            double diffMulti = 1;
            if (hero.Hp <= 20)
            {
                diffMulti = 0.25;
            }
            var random = new Random();

            if (boss.Hp <= 50)
            {
                var enemyAttack2ndPhase = random.Next(0, Convert.ToInt32(hero.Mag + 1)) * diffMulti;
                var herosDefence2ndPhase = 0.25 * hero.Mag + 0.5 * hero.Dxt + hero.Armour.Def;
                var attackPower2ndPhase = enemyAttack2ndPhase - herosDefence2ndPhase;
                if (!(attackPower2ndPhase >= 0))
                {
                    Console.WriteLine($"Enemy turn: Missed.");
                    return;
                }
                hero.Hp -= attackPower2ndPhase;
                Console.WriteLine("Enemy used powerfull magic attack");
                Console.WriteLine($"Enemy turn: {attackPower2ndPhase} points of damage");
            }
            var enemyAttack = random.Next(1, Convert.ToInt32(boss.Str + 1)) +
                              boss.EnemyWeapon.Dmg * diffMulti + 0.4 * boss.Hp;
            var herosDeffence = 0.2 * hero.Str + 0.5 * hero.Dxt + hero.Armour.Def + hero.Weapon.Def;
            var attackPower = enemyAttack - herosDeffence;
            if (!(attackPower >= 0))
            {
                Console.WriteLine($"Enemy turn: Missed.");
                return;
            }
            hero.Hp -= attackPower;
            Console.WriteLine($"Enemy turn: {attackPower} points of damage");
        }

        private void SecondBossAttack(Hero hero, Boss boss)
        {
            double diffMulti = 0.5;
            if (hero.Hp <= 20)
            {
                diffMulti = 0.125;
            }
            var random = new Random();
            var enemyAttack = random.Next(1, Convert.ToInt32(boss.Str + 1)) +
                              boss.EnemyWeapon.Dmg + boss.SubHp2 * diffMulti + 0.4 * boss.Hp;
            var herosDeffence = 0.15 * hero.Str + 0.5 * hero.Dxt + hero.Armour.Def + hero.Weapon.Def;
            var attackPower = enemyAttack - herosDeffence;
            if (!(attackPower >= 0))
            {
                Console.WriteLine($"Enemy turn: Missed.");
                return;
            }
            hero.Hp -= attackPower;
            Console.WriteLine($"Enemy turn: {attackPower} points of damage");
            
        }

        public void UseItem(Hero hero)
        {
            var counter = 0;
            Console.WriteLine("Chose item to use:");
            foreach (var item in hero.Backpack)
            {
                Console.WriteLine($"[{counter}] {item.Name}");
                counter++;
            }
            Console.WriteLine($"[{counter}] Return.");
            var input = Console.ReadLine();
            var inputInt = Convert.ToInt16(input);
            if (inputInt == counter)
            {
                return;
            }
            if (inputInt < counter)
            {
                hero.Backpack[inputInt].Use();
                hero.Backpack.Remove(hero.Backpack[inputInt]);
            }
            else
                Console.WriteLine("Wrong input!");
        }
    }
}