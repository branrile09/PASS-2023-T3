using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASS_WK9
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

        public Stats()
        {
            //there's a shortcut we could add here...
            Random newRand = new Random();
            //randomly assign stats
            strength = newRand.Next(2, 11);
            dexterity = newRand.Next(2, 11);
            constituion = newRand.Next(2, 11);
            intelligence = newRand.Next(2, 11);
            wisdom = newRand.Next(2, 11);
            charisma = newRand.Next(2, 11);

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
            //int choice = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int randomInt = rnd.Next(1, 5);
            int choice = randomInt;
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
            damage *= level;
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

            float damage = 0;
            switch (i)
            {
                case 1:
                    damage = strength;
                    Console.WriteLine($"{name}: used {CombatMove1} for {damage}Damage");
                    break;
                case 2:
                    damage = strength* (2 * (health/100));
                    Console.WriteLine($"{name}: used {CombatMove2} for {damage}Damage");
                    break;
                case 3:
                    damage = strength * (3 * (health / 100) * (dexterity/10));
                    Console.WriteLine($"{name}: used {CombatMove3} for {damage}Damage");
                    break;
                case 4:
                    damage = strength * (3 * (health / 100) * (intelligence / 10));
                    Console.WriteLine($"{name}: used {CombatMove4} for {damage}Damage");
                    break;
            }
            
            gainExp(damage);
            damage *= level;
            return damage;

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
            float damage = 0;
            switch (i)
            {
                case 1:
                    damage = strength;
                    Console.WriteLine($"{name}: used {CombatMove1} for {damage}Damage");
                    break;
                case 2:
                    damage = 0;
                    float heal = (100 - health) * 0.5f ;
                    health += heal;
                    Console.WriteLine($"{name}: used {CombatMove2} for {damage}Damage and healed for {heal}");
                    break;
                case 3:
                    damage = strength * (3 * (health / 100) * (dexterity / 10));
                    Console.WriteLine($"{name}: used {CombatMove3} for {damage}Damage");
                    break;
                case 4:
                    damage = strength * (3 * (health / 100) * (intelligence / 10));
                    Console.WriteLine($"{name}: used {CombatMove4} for {damage}Damage");
                    break;
            }
            gainExp(damage);
            damage *= level;
            return damage;

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
            CombatMove4 = "Cloak";
        }

        protected override float callCombatMethod(int i)
        {
            float damage = 0;
            switch (i)
            {
                case 1:
                    damage = strength * ( charisma/10 );
                    Console.WriteLine($"{name}: used {CombatMove1} for {damage}Damage");
                    break;
                case 2:
                    damage = strength * (2 * (health / 100));
                    Console.WriteLine($"{name}: used {CombatMove2} for {damage}Damage");
                    break;
                case 3:
                    damage = strength * (3 * (health / 100) * (dexterity / 10));
                    Console.WriteLine($"{name}: used {CombatMove3} for {damage}Damage");
                    break;
                case 4:
                    damage = strength * (3 * (health / 100) * (intelligence / 10));
                    Console.WriteLine($"{name}: used {CombatMove4} for {damage}Damage");
                    break;
            }
            gainExp(damage);
            damage *= level;
            return damage;

        }
             

    }


    internal class Nercromancer : Player
    {
        private bool specialAbilityTrigger = false;

        public Nercromancer(string name, Stats newStats)
        {
            this.name = name;
            AssignStats(newStats);
            CombatMove1 = "spirit bomb";
            CombatMove2 = "blood wrath";
            CombatMove2 = "Resurrection";
            CombatMove4 = "Resurrection";
        }

        protected override float callCombatMethod(int i)
        {
            float damage = 0;
            switch (i)
            {
                case 1:
                    damage = intelligence * (intelligence / 10);
                    Console.WriteLine($"{name}: used {CombatMove1} for {damage}Damage");
                    break;
                case 2:
                    damage = intelligence * (2 * (health / 100));
                    health += (damage / 3);
                    Console.WriteLine($"{name}: used {CombatMove2} for {damage}Damage");
                    break;
                case 3:
                    specialAbilityTrigger = true;
                    Console.WriteLine($"{name}: used {CombatMove3}");
                    break;
                case 4:
                    specialAbilityTrigger = true;
                    Console.WriteLine($"{name}: used {CombatMove3}");
                    break;
            }
            gainExp(damage);
            damage *= level;
            return damage;

        }

        public bool specialAbility()
        {
            if (specialAbilityTrigger)
            {
                specialAbilityTrigger = false;
                return true;            
            }
            else return false;               
        }


    }


    internal class undead : Player
    {
        public undead(string name, Stats newStats)
        {
            this.name = name;
            AssignStats(newStats);
            CombatMove1 = "Punch";
            CombatMove2 = "Kick";
            CombatMove3 = "Bash";
            CombatMove4 = "Stab";
            health = 50; //we only give half health, necro is just a healer who is late
        }


        protected override float callCombatMethod(int i)
        {
            //
            float damage = strength / 2; //undead uses half strength for damage,  
            switch (i)
            {
                case 1:
                    Console.WriteLine($"{name}: used {CombatMove1} for {damage}Damage");
                    break;
                case 2:
                    Console.WriteLine($"{name}: used {CombatMove2} for {damage}Damage");
                    break;
                case 3:
                    Console.WriteLine($"{name}: used {CombatMove3} for {damage}Damage");
                    break;
                case 4:
                    Console.WriteLine($"{name}: used {CombatMove4} for {damage}Damage");
                    break;
            }
            gainExp(damage);
            damage *= level;
            return damage;
        }

    }


}