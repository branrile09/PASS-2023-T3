namespace PASS_WK8
{
    /*TODO LIST:
            *
            *  ----- 5min intro/setup -----
            *
            *  Hellos, plan for todays workshop,
            *  everyone write a message in the hello world function               
            *
            *  ----- 25min to go through this -----
            *
            *  1.refresh on what objects and inheritence
            *  2.lets make some DnD Sub-Classes 
            *  
            *  ----- 5 min Break -----
            *
            *  Go make a coffee and get some biscuits maybe??
            *
            *  ----- 25min to go through this -----
            *  
            *  3. 
            *  4. 
            *  
            *  ----- 5-10 min Q&A -----
            * 
            *   ask anything
            *               
            *  ----- Form/Survey(anon) -----         
            *  
            *  Mid term feedback form
            *
            *  ----- Additional Resources -----
            *
            *  //i will add some here when i find some
            *  
            *  ----- Next week -----
            *  
            *  revise custom objects (Module 6)
            *  Objects and inheritance (Module 7)
            *      
            * 
           */


    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "RB";
            Stats newStat = new Stats(10,10,10,10,10,10);
            Warrior newWarrior = new Warrior(name, newStat);

            name = "MG";
            newStat = new Stats(8,8,8,8,8,8);
            Mage newMage = new Mage(name, newStat);


            do
            {
                //damage phase
                float W_DealDamage = newWarrior.DealDamage();
                float M_DealDamage = newMage.DealDamage();


                newWarrior.TakeDamage(M_DealDamage);
                newMage.TakeDamage(W_DealDamage);

            } while (newMage.isAlive() && newWarrior.isAlive());


            Archer newArcher = new Archer(name, newStat);

            newArcher.specialAbility();

            List<Player> players = new List<Player>();
            players.Add(newArcher);
            players.Add(newMage);
            players.Add(newWarrior);


            players[0].DealDamage();


            if (players[0].GetType() == typeof(Archer))
            {
                Archer tempArcher = (Archer)players[0];
                tempArcher.specialAbility();
            }



        }
    }
}