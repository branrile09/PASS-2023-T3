using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PASS_WK3
{
    internal class Program
    {

        static private string hello = "Hello World";

        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to ISE PASS wk3");

            /*TODO LIST:
             *
             *  ----- 5min intro/setup -----
             *
             *  compare todo list to Assessment
             *
             *  ----- 25min to go through this -----
             *
             *  1. console in/out
             *  2. variable & operations
             *   a. math on numbers
             *   b. string concatination
             *   c. enums (me don't like this one)
             *   d. understanding scope and object permanance
             *  
             *  ----- 5 min Break -----
             *
             *  Go make a coffee and get some biscuits maybe??
             *
             *  ----- 25min to go through this -----
             *
             *  3. LOOPS
             *  4. Conditions / logic (if, else if, else, Switch)
             *  5. show is alpha num??             
             * 
             *  ----- 10 min Q&A -----
             * 
             *  maybe discuss some programming langauges??
             *  
             *  ----- Form/Survey(anon) -----
             *  https://forms.office.com/r/Y30Gf5ZDVF
            */

            Console.WriteLine("Hi, can you put in a number between 1 and 10");
            string textInput = Console.ReadLine();  

            

            //int number = int.Parse(textInput);
            int number;
            int.TryParse(textInput, out number);
            if (number >= 1 && number <= 10)
            {
                //what operators?
                number++;
                number += 2; //numbers other than 1,             
                int tempInt = number + 1;
                number--;
                number = number * 22;
                number += tempInt;
                number = number % 4;
                number = number / 4;
                number /= 4;
                number *= 4;
                number %= 4;

                //tempInt = 10 % ((number * 3) / 4 );

                //different forms of concatination. 
                string output1 = "after all this madness your number is equal to: ";
                string output2 = "after all this madness your number is equal to: " + tempInt;
                string output3 = $"after all this madness your number is equal to: {tempInt + number}";
                string output = $"after all this madness your number is equal to: {tempInt} & {number} ";

                Console.WriteLine(output2 + number);

            }
            else if (number >= 11)
            {
                Console.WriteLine("number is too high");            
            }
            else 
            {
                Console.WriteLine("invalid input");
            }



            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                //we loop for a fixed amount of intervals
            }
            string tempString = "temporary string for lulz";
           
            foreach (char c in tempString)
            { 
                // we loop within the range of a collection
                Console.WriteLine(c);            
            }

            bool tempbool = false;
            do
            {
                //we want it to run atleast once
                // Run the code, then repeat it until a condition is met
                Console.WriteLine("this is a do-while loop");

            } while (tempbool);


            while (tempbool)
            {
                // we check condition before starting, if false, we skip loop
                // Run the code only if the condition is not met, then rerun until met
                Console.WriteLine("this is a while loop");
            }



        }


        
        static void tempFunct()
        {
            Console.WriteLine(hello);
        
        }

    }




}
            

