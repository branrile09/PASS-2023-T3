using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASS_WK8
{
    //as much as i dislike structs, this is super useful
    public struct Stats
    {
        public int strength = 10;
        public int dexterity = 10;
        public int constituion = 10;
        public int intelligence = 10;
        public int wisdom = 10;
        public int charisma = 10;

        public Stats(int str, int dex, int consti, int intel, int wis, int charisma)
        {
            strength = str;
            dexterity = dex;
            constituion = consti;
            intelligence = intel;
            wisdom = wis;
            this.charisma = charisma;
        }

    }

    /// <summary>
    /// this is our base class
    /// </summary>
    internal class Player
    {
        //core stats
        protected float health = 100;
        protected string name = "";
        protected int level = 1;
        protected float exp = 0;

        //ability stats
        protected int strength = 10;
        protected int dexterity = 10;
        protected int constituion = 10;
        protected int intelligence = 10;
        protected int wisdom = 10;
        protected int charisma = 10;

        //combat moves (4)
        protected string CombatMove1 = "";
        protected string CombatMove2 = "";
        protected string CombatMove3 = "";
        protected string CombatMove4 = "";


        public Player()
        {

        }

        public Player(string name, Stats newStats)
        {
            this.name = name;
            AssignStats(newStats);
        }

        /// <summary>
        /// instead of doing this for each constructor, we can reuse this code
        /// </summary>
        /// <param name="newStats"></param>
        protected void AssignStats(Stats newStats)
        {
            strength = newStats.strength;
            dexterity = newStats.dexterity;
            constituion = newStats.constituion;
            intelligence = newStats.intelligence;
            wisdom = newStats.wisdom;
            charisma = newStats.charisma;
        }

        protected void gainExp(float xp)
        {
            exp += xp;
            if (xp >= 30 * level)
            {
                level++;
                xp = 0;
                Console.WriteLine($"{name}: is now level{level}");
            }

        }

        public float DealDamage()
        {
            return combatChoice();
        }

        protected float combatChoice()
        {
            Console.WriteLine($"combat choises are as follows");
            Console.WriteLine($"1:{CombatMove1} 2:{CombatMove2} 3:{CombatMove3} 4:{CombatMove4}");
            int choice = int.Parse(Console.ReadLine());
            return callCombatMethod(choice);
        }

        //this needs to be re-written for each class
        protected virtual float callCombatMethod(int i)
        {
            float damage = 0;
            switch (i)
            {
                case 1:
                    damage = 1;
                    Console.WriteLine($"{name}: used {CombatMove1} for {damage}Damage");
                    break;
                case 2:
                    damage = 2;
                    Console.WriteLine($"{name}: used {CombatMove2} for {damage}Damage");
                    break;
                case 3:
                    damage = 3;
                    Console.WriteLine($"{name}: used {CombatMove3} for {damage}Damage");
                    break;
                case 4:
                    damage = 4;
                    Console.WriteLine($"{name}: used {CombatMove4} for {damage}Damage");
                    break;
            }
            gainExp(damage);
            return damage;
        }

        public void TakeDamage(float d)
        {
            health -= d;
        }

        public bool isAlive()
        {
            return health > 0;
        }

    }

    internal class Warrior : Player
    {
        public Warrior(string name, Stats newStats)
        {
            this.name = name;
            AssignStats(newStats);
            CombatMove1 = "Punch";
            CombatMove2 = "Kick";
            CombatMove3 = "Bash";
            CombatMove4 = "Stab";
        }


        protected override float callCombatMethod(int i)
        {
            return base.callCombatMethod(i);

        }

    }

    internal class Mage : Player
    {
        public Mage(string name, Stats newStats)
        {
            this.name = name;
            AssignStats(newStats);
            CombatMove1 = "Fire Blast";
            CombatMove2 = "Teleport";
            CombatMove3 = "Silence";
            CombatMove4 = "Polymorph";
        }

        protected override float callCombatMethod(int i)
        {
            return base.callCombatMethod(i);

        }

    }


    internal class Archer : Player
    {
        public Archer(string name, Stats newStats)
        {
            this.name = name;
            AssignStats(newStats);
            CombatMove1 = "Head shot";
            CombatMove2 = "Sniper";
            CombatMove2 = "Deadly Aim";
            CombatMove4 = "Cloack";
        }

        protected override float callCombatMethod(int i)
        {
            return 1;

        }

        public void specialAbility()
        {


        }

    }
}