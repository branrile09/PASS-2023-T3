namespace PASS_WK6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*TODO LIST:
             *
             *  ----- 5min intro/setup -----
             *
             *  Hellos, plan for todays workshop,
             *  everyone write a message in the hello world function             *  
             *
             *  ----- 25min to go through this -----
             *
             *  1.refresh on functions, 
             *  2.overloading functions
             *  
             *  ----- 5 min Break -----
             *
             *  Go make a coffee and get some biscuits maybe??
             *
             *  ----- 25min to go through this -----
             *
             *  1. Discuss what is a Custom object / Class
             *  2. Demonstrate and explain Structure
             *  3. interact with some basic custom objects, 
             *  4. make our own custom objects. 
             *                
             *  ----- 5-10 min Q&A -----
             * 
             *   ask anything
             *               
             *  ----- Form/Survey(anon) -----
             *  
             *  https://forms.office.com/r/Y30Gf5ZDVF
             *  
             *  ----- Next week -----
             *  
             *  revise custom objects (Module 6)
             *  Objects and inheritance (Module 7)
             *      
             * 
            */




            HelloWorld();


            person newPerson = new person();
            newPerson.outputProfile();

            person RB = new person(2, "Riley Branson", 28, true);
            RB.outputProfile();
            //gender was input incorrectly, we have updated to fix this
            RB.updateGender(false);
            RB.outputProfile();

            person TT = new person(23, "Titus Tarcsai", 36, false);
            TT.outputProfile();
            person TanTan = new person(7, "taner turkeri", 42, false);
            TanTan.outputProfile();


            Console.WriteLine(TanTan.getAge());
            TanTan.setAge(0);



            Console.WriteLine(TanTan.getAge());

            TanTan.setAge(43);
            Console.WriteLine(TanTan.getAge());



        }



        static void HelloWorld()
    {
        // everyone write in a message
        Console.WriteLine("RB says hello, also DC & Marvel movies are over-rated");
        Console.WriteLine("Titus here, can't wait to build that AI maze modell y");
        Console.WriteLine("Taner I need coffee");
    }



}



    public class person
    {

        //all info should be private (within rare exceptions)
        public int id;
        private string name;
        private int age;
        private bool gender; //male = false, female = true


        private List<person> Members = new List<person>();


        public person()
        {
            id = 1;
            name = "Test";
            age = 5;
            gender = true;
        }

        public person(int id, string name, int age, bool gender)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public void outputProfile()
        {
            string outputGender = "male";
            if (gender)
            {
                outputGender = "female";
            }

            Console.WriteLine($"{name} is a {age} year old {outputGender} and there ID number is {id}");

        }


        public int getAge()
        {
            return age;
        }
        public void setAge(int i)
        {
            if (i == age + 1)
                age = i;
        }


        public string getName()
        {
            return name;
        }

        public void setName(string s)
        { 
            name = s;
        }

        public bool isGender() 
        { 
            return gender;        
        }

        public void updateGender(bool g)
        {
            gender = g;
        }






    }


}