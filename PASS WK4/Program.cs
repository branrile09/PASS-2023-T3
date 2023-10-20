namespace PASS_WK4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ISE PASS wk4");

            /*TODO LIST:
             *
             *  ----- 5min intro/setup -----
             *
             *  recap kahoot (variables and basic loops)
             *  no kahoot this week, just get everyone to spam chat with different examples of variables. 
             *  query students for quick revision
             *
             *  ----- 25min to go through this -----
             *
             *  Loop Types (10min)
             *  Arrays (10min)
             *  Lists (5min)
             *  
             *  ----- 5 min Break -----
             *
             *  Go make a coffee and get some biscuits maybe??
             *
             *  ----- 25min to go through this -----
             *
             *  Switch (5min)
             *  Enums   (5min)
             *  
             *  Nested Loops (10-15min)
             * 
             *  ----- 5-10 min Q&A -----
             * 
             * ask anything
             *               
             *  ----- Form/Survey(anon) -----
             *  
             *  https://forms.office.com/r/Y30Gf5ZDVF
             *  
             *  ----- Next week -----
             *  
             *  Functions/Methods
             *      Explanation
             *      Structure
             *      Building
             *      
             * 
            */

            //first things first, everyone say Hello and share an unpopular opinion. 
            Console.WriteLine("RB was here, DISCOS BACK BABY!!!!");
            Console.WriteLine("Rainier here, what up fam!");;
            Console.WriteLine("CP was here, Ready To Rock!!!");
            Console.WriteLine("Hello Titus here, I like pouring my morning coffee on my desk!");




            // ----- Loops ----
            //1. while loop
            //a) explanation: a loop, that continues during a condition is met, checks the condition before starting            
            //b) example code (loop while meaning of life is != 42 )

            int meaningOfLife = 0;
            while (meaningOfLife != 42)             
            {
                meaningOfLife++;
            }



            //2. Do While 
            /**a) explanation the do while, the do while loop is going to complete at least once the loop and then is going to chech if the condition 
            is still true, otherwise is going to stop.
            */
            //b) example code (loop while meaning of life is != 42 )
            meaningOfLife = 0;

            do
            {
                Console.WriteLine("The meaning of life is not" + meaningOfLife);
                meaningOfLife++;
                
            } while (meaningOfLife != 42);
            Console.WriteLine("We have found the meaning of life!!!!!! is 42. ");


            //3. For loop
            //a) explanation : When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop:
            //b) example code (100 iterations, number starts at 1, triple it, then half it) (titusz)
            float number = 1;
            for (int i = 1; i <= 100; i++)
            {
                number *= 3;
                number /= 2;
                Console.WriteLine(i);
            }

            //4, Foreach
            //a) explanation
            // Allows you to go through the elements of a collection. (taner)
            //b) example code (iterate through each char in "HiPpoPlatyroo", then output how many vowels in the word  )
            string letters  = "HiPpoPlatyrOo";
            string vowels =  "aeiou";
            string tempLetters = letters.ToLower();
            int vowelQuantity = 0;

            foreach(char c in tempLetters)
            {
                foreach (char c2 in vowels)
                {
                    if (c2 == c)
                    {
                        vowelQuantity++;
                        continue;                    
                    }  
                }
            }

            Console.WriteLine(vowelQuantity);



            // resource -> https://www.w3schools.com/cs/cs_arrays.php
            // resource -> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays (i like this one a little better)
            // ----- Arrays ----
            //1. Create an Array of intigers            
            
            int [] myNum = {10, 20, 30, 40};
            int[] myNum2 = new int[10];
            
            

            //2. Create an Array of strings
            string[] letterS = { "a", "b" ,"c" };
            string[] cars = {"volvo","bmw","Holden"};

            //3. Create a 2d Array of intigers size 20x20
            int[,] twoDarray = new int[2 ,1];

            int[,] DDArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //a jagged array is like having an array of arrays, for each element we are using another array inside.
            int[][] dDJaggedArray = new int[6][];
            dDJaggedArray[0]= new int[4] { 1, 2, 3, 4 };

            //4. Create a list of boolean

            List<int> list = new List<int>();
      

            //5. explain the difference between list and array
            //



            // ----- Nested Loops ----
            //1.
            // from the 2d array from earlier, assign random values between 1 and 100

            //example code for random
            Random rnd = new Random();
            int month = rnd.Next(1, 13); // creates a number between 1 and 12
            int dice = rnd.Next(1, 7); // creates a number between 1 and 6
            int card = rnd.Next(52); // creates a number between 0 and 51


            //
            //2.
            //from the 2d array from earlier, find the average.


            //using multidensional arrays can be used for all sorts of things, such as AI, Data Science, Game matrix tables, Path finding, etc
 




        }
    }
}