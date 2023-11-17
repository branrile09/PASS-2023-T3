using System.Runtime.Intrinsics.X86;

namespace PASS_WK9
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
           *  1.recap on inheritence and objects (dnd classes)
           *  2. recap on polymorphism  concept(example 2)
           *  3. add level to damage
           *  
           *  ----- 5 min Break -----
           *
           *  Go make a coffee and get some biscuits maybe??
           *
           *  ----- 25min to go through this -----
           *  
           *  3.  practice encapsulation
           *  4.  practice polymorphism
           *  
           *  ----- 5-10 min Q&A -----d
           * 
           *   ask anything
           *               
           *  ----- Form/Survey(anon) -----         
           *  
           *  https://forms.office.com/r/Y30Gf5ZDVF
           *
           *  ----- Additional Resources -----
           *
           *  //i will add some here when i find some
           *  
           *  ----- Next week -----
           *  Finish this weeks task with polymorphism.
           *  
           *  look into debuging and testing
           *  maybe look at diagrams.
           *      
           * 
          */
    internal class Program
    {
        static void Main(string[] args)
        {
            //example();
            example2();


        }



        static void example()
        {
            string name = "RB";
            Stats newStat = new Stats(10, 10, 10, 10, 10, 10);
            Warrior newWarrior = new Warrior(name, newStat);

            name = "MG";
            newStat = new Stats(10, 10, 10, 10, 10, 10);
            Mage newMage = new Mage(name, newStat);


            do
            {
                //damage phase
                float W_DealDamage = newWarrior.DealDamage();
                float M_DealDamage = newMage.DealDamage();


                newWarrior.TakeDamage(M_DealDamage);
                newMage.TakeDamage(W_DealDamage);

            } while (newMage.isAlive() && newWarrior.isAlive());


            if (newWarrior.isAlive())
            {
                Console.WriteLine("Warrior won");
            }
            else
            {
                Console.WriteLine("Mage won");
            }





        }

        static void example2()
        {
            string name = "RB";
            Stats newStat = new Stats(10, 10, 10, 10, 10, 10);
            Warrior newWarrior = new Warrior(name, newStat);

            name = "MG";
            newStat = new Stats(8, 8, 8, 8, 8, 8);
            Mage newMage = new Mage(name, newStat);

            name = "Archie";
            Nercromancer newArcher = new Nercromancer(name, newStat);

            //newArcher.specialAbility(); we lost this ability as it was removed

            List<Player> players = new List<Player>();
            players.Add(newArcher);
            players.Add(newMage);
            players.Add(newWarrior);


            players[0].DealDamage();


            if (players[0].GetType() == typeof(Nercromancer))
            {
                Nercromancer tempNecro = (Nercromancer)players[0];
                tempNecro.specialAbility(); //we gave this necromancer a temp ability
            }



        }


        static void Encapsulation()
        {
            //1.  explain what encapsulation is
            // Encapsulation is to restrict acces to informations
            //
            //2. provide an example of when and how we would use it
            //For example if we want some user information private, we would give them a private access modifier
            //string private userEmail = "something@gmail.com";
            //string private password = "Password1234!"; <-- not a good password


            //https://stackoverflow.com/questions/54585/when-should-you-use-a-class-vs-a-struct-in-c
            //class vs struct
            //1. where would we use a class?
            //I'd use class when I need to access to higher level functionalities
            //making self managing objects with restricted accessibility. 


            //2. where would we use a struct
            //I would use struct when I want sort of wrap up some information and used them later on instead of repeating the code
            // wrapping data into small containers

        }

        static void Polymorphism()
        {

            //make 2 lists for 2 teams          
            List<Player> Alliance = new List<Player>();
            List<Player> Horde = new List<Player>();
            //make a list for graveyard
            List<Player>graveyard = new List<Player>();
            

            //add a mix of players to both teams that are either Warrior, Mage, or Archer, with randomized stats
            //stats range between 2-10. 

            for (int i = 0; i < 10; i++) 
            {

                Random newRand = new Random();

                int r = newRand.Next(1,5);

                if (r == 1) 
                {
                    string newname = $"warrior{i}";
                    Stats newStats = new Stats();
                    Warrior newWarrio = new Warrior(newname,newStats);
                    Alliance.Add(newWarrio);
                }
                else if (r == 2)
                {

                    string newname = $"mage{i}";
                    Stats newStats = new Stats();
                    Mage newWarrio = new Mage(newname, newStats);
                    Alliance.Add(newWarrio);
                }
                else if (r == 3)
                {

                    string newname = $"archer{i}";
                    Stats newStats = new Stats();
                    Archer newWarrio = new Archer(newname, newStats);
                    Alliance.Add(newWarrio);
                }
                else if (r == 4)
                {
                    string newname = $"Nercromancer{i}";
                    Stats newStats = new Stats();
                    Nercromancer newWarrio = new Nercromancer(newname, newStats);
                    Alliance.Add(newWarrio);
                
                }

            }
            for (int i = 0; i < 10; i++)
            {

                Random newRand = new Random();

                int r = newRand.Next(1, 5);

                if (r == 1)
                {
                    string newname = $"warrior{i}";
                    Stats newStats = new Stats();
                    Warrior newWarrio = new Warrior(newname, newStats);
                    Horde.Add(newWarrio);
                }
                else if (r == 2)
                {

                    string newname = $"mage{i}";
                    Stats newStats = new Stats();
                    Mage newWarrio = new Mage(newname, newStats);
                    Horde.Add(newWarrio);
                }
                else if (r == 3)
                {

                    string newname = $"archer{i}";
                    Stats newStats = new Stats();
                    Archer newWarrio = new Archer(newname, newStats);
                    Horde.Add(newWarrio);
                }
                else if (r == 4)
                {
                    string newname = $"Nercromancer{i}";
                    Stats newStats = new Stats();
                    Nercromancer newWarrio = new Nercromancer(newname, newStats);
                    Horde.Add(newWarrio);
                }

            }

            //make the 2 teams battle, all players that die, is removed from team and added to graveyard


            //for loop here, 



            //use polymorphism so necromancer re-animates dead players into undead players. 
            //creating a get method in player may help.




        }


    }
}