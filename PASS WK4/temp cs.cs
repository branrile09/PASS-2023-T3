using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASS_WK4
{
    enum Months
    {
        January,    // 0
        February,   // 1
        March,      // 2
        April,      // 3
        May,        // 4
        June,       // 5
        July        // 6
    }
    enum intys 
    {
        January = 1,    // 0
        February,   // 1
        March,      // 2
        April,      // 3
        May,        // 4
        June,       // 5
        July        // 6
    }



    internal class temp_cs
    {
        temp_cs() { }

        
        void randomshiz()
        {

            int temp = 2;
            string bluh = "";

            switch (temp)
            {
                case 1:
                    bluh = "BLUH!";
                    break;

                case 2:
                    bluh = "bluh1";
                    break;
            }

            bool isAlphanum = true;
            bool hasDigit = false;
            bool hasLetter = false;
            foreach (char c in bluh)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    isAlphanum = false;
                    break;
                }
                else
                {

                    if (char.IsLetter(c) && !hasLetter)
                    {
                        hasLetter = true;
                    }
                    else if (char.IsDigit(c) && !hasDigit)
                    {
                        hasDigit = true;
                    }
                    else
                    {
                        continue;
                    }



                    if (hasDigit && hasLetter)
                    { break; }
                }

            }

            if (!isAlphanum) { Console.WriteLine("False"); }
            else { Console.WriteLine("True"); }

        }

    }
}
