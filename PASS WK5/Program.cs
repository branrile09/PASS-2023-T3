namespace PASS_WK5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ISE PASS wk5");

            /*TODO LIST:
             *
             *  ----- 5min intro/setup -----
             *
             *  Hellos,
             *  
             *
             *  ----- 25min to go through this -----
             *
             *  Loop Types recap (2min)
             *  Arrays (15min) from last week
             *  Lists (10min)
             *  
             *  ----- 5 min Break -----
             *
             *  Go make a coffee and get some biscuits maybe??
             *
             *  ----- 25min to go through this -----
             *
             *  1. Discuss what is a Function
             *  2. Demonstrate and explain Structure
             *  3. Everyone builds there own function for a different purpose
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
             *  revise Functions (Module 5)
             *  Objects and Classes (Module 6)
             *      
             * 
            */

            //first things first, everyone say Hello or share 1 thing. 
            //Console.WriteLine(
            //"RB has one of the best jobs running pass, " +
            // "\n and im not saying this just because my supervisor is attending this week");
            //Console.WriteLine("Hello guys Titus here, and I need my coffee.");

            //Console.WriteLine("Hello I am Taner, i need coffee too");


            // ----- Arrays ----
            //1. go to Wk4's project to finish Arrays



            // ----- Functions ----
            //Definition: A function in C# is a way of wrapping code to perform a certain task and return a value.
            //It is part of an object-oriented approach to programming and does not exist by itself.
            //A function has a name,a return type, a body, parameters, and an access specifier.
            //A function can be called from other parts of the code to avoid repetition



            //hellowWorld("BEN");
            int x = addNumber(3,4);
            Console.WriteLine(x);



            // ----- Functions to make/choose from ----
            // 1. calculate average of numbers from an array // taner
            int[] numbers = {2,4,6,8,10};
            calcAVG(numbers);

            
            // 2. a function that tells you if the number is even //Titus
            // 3. fibonacci sequence
            // 4. sum of Numbers
            // 5. if the number is prime
            // 6. find the highest prime number
            // 7. reverse string //Titus
            // 8. get number from user


        }


        // accessibility, return type, name, parameters, 
        static void hellowWorld(string name)
        {
            Console.WriteLine($"{name}: Hello World");  
            //void has no return type
        }

        // accessibility, return type, name, parameters, 
        static int addNumber(int a, int b)
        {
            return a + b;
        }

        static float solveForMagnitude(float x, float y)
        {
            //magnitude of a vector uses pythagoras to solve A^2 + B^2 = C^2
            //example A
            float sqrdA = x * x;
            float sqrdB = y * y;
            float sqrdC = sqrdA + sqrdB;
            float magnitude = MathF.Sqrt(sqrdC);
            Console.WriteLine(magnitude);
            //example B
            magnitude = MathF.Sqrt(x*x + y*y);
            Console.WriteLine(magnitude);


            //return MathF.Sqrt(x*x + y*y);
            return magnitude;        
        
        }

        static double calcAVG(int[] numbers)
        {
            int total= 0;
            int size = numbers.Count();

            foreach (int number in numbers) 
            {
            
            
            }



            double average = total / size;




            return average;
        
        }


        static bool isEven(int numb)
        {
            return numb % 2 == 0;
        }
        static string reverseString(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);

            return new string (charArray);
        }
    }
}