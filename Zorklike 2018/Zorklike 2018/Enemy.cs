namespace Zorklike2018
{
    public abstract class Enemy
    {
        public string EnemyName { get; set; }
        public double Hp { get; set; }
        public double Str { get; set; }
        public double Dxt { get; set; }
        public double Mag { get; set; }
        public double Cha { get; set; }
        public Weapon EnemyWeapon { get; set; }
        public Armour EnemyArmour { get; set; }
        public Item Reward { get; set; }
    }

    public class MinorEnemy : Enemy
    {
   
        public MinorEnemy(string enemyName, double hp, double str, double dxt, double mag, double cha, Weapon enemyWeapon, Armour enemyArmour)
        {
            EnemyName = enemyName;
            Hp = hp;
            Str = str;
            Dxt = dxt;
            Mag = mag;
            Cha = cha;
            EnemyWeapon = enemyWeapon;
            EnemyArmour = enemyArmour;
        }
    }
    public class SubBos : Enemy
    {

        public SubBos(string enemyName, double hp, double str, double dxt, double mag, double cha, Weapon enemyWeapon, Armour enemyArmour, Item reward)
        {
            EnemyName = enemyName;
            Hp = hp;
            Str = str;
            Dxt = dxt;
            Mag = mag;
            Cha = cha;
            EnemyWeapon = enemyWeapon;
            EnemyArmour = enemyArmour;
            Reward = reward;
        }
    }
    public class Boss : Enemy
    {
        public double SubHp1 { get; set; }
        public double SubHp2 { get; set; }
        public double SubHp3 { get; set; }
        public double SubHp4 { get; set; }
        public double SubHp5 { get; set; }
        public double SubHp6 { get; set; }

        public Boss(string enemyName, double hp, double str, double dxt, double mag, double cha, Weapon enemyWeapon, Armour enemyArmour, Item reward)
        {
            EnemyName = enemyName;
            Hp = hp;
            Str = str;
            Dxt = dxt;
            Mag = mag;
            Cha = cha;
            EnemyWeapon = enemyWeapon;
            EnemyArmour = enemyArmour;
            Reward = reward;
        }
    }
}