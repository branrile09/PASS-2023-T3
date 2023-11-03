using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PASS_WK7
{
    /// <summary>
    /// <para> this is our first object.</para>
    /// <para> this also lets us show how to comment code for when we hover </para>
    /// <para> fun tip, Ctrl+D duplicates and ctrl+shift+S saves all files in current project </para>
    /// </summary>
    internal class Employee
    {
        protected int _ID;
        public int ID
        {
            get { return _ID; }   // get method
            set { _ID = ValidateID(value); }  // set method
        }

        public string _name { get; protected set;}
        protected DOB _birthDate;
        protected bool _gender; //male = false, female = true

        public Employee()
        {
            _ID = ValidateID(1);
            _name = "Test";
            _birthDate = new DOB(1,09,2001);
            _gender = true;            
        }

        public Employee(int id, string name, bool gender)
        {
            _ID = ValidateID(id);
            this._name = name;
            this._gender = gender;
            _birthDate = userDOB();

        }

        protected int ValidateID(int i)
        {
            Console.WriteLine("ID Valdiated");
            //code some validation process or something
            return i;        
        }


        //need a function that asks user to input DOB
        protected DOB userDOB() 
        
        {
            Console.WriteLine("What year you were born: ");
            int year = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What month you were born: ");
            int month = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What day you were born: ");
            int day = Convert.ToInt32(Console.ReadLine());

            return new DOB(day, month, year);

        }

        /// <summary>
        /// lets supervisors check employees moods
        /// </summary>
        /// <returns> a string </returns>
        public string checkMood()
        {
            return "I hate my job!";        
        }



    }




    internal class Manager : Employee
    {
        //list of employees who we manage
        List<Employee> _employees;
        string dept = "Sales";

        public Manager()
        {
            _ID = ValidateID(1);
            _name = "Test";
            _birthDate = new DOB(1, 09, 2001);
            _gender = true;
        }

        public Manager(int id, string name, bool gender)
        {
            _ID = ValidateID(id);
            this._name = name;
            this._gender = gender;
            _birthDate = userDOB();
            _employees.Add(this);

        }


        public void addStaff(Employee newEmployee)
        {
            _employees.Add(newEmployee);        
        }


        public void checkEmployees()
        {
            foreach (Employee e in _employees)
            { 
                string happyness = e.checkMood();
                Console.WriteLine($"{e._name} said:{happyness}");
            }      
        
        }


        public string checkMood()
        {
            return "I love torturing my subordinates!";
        }


    }

    /// <summary>
    /// Day, Month, Year
    /// </summary>
    internal class DOB
    {
        public int day { get; private set; }
        public int month { get; private set; }
        public int year { get; private set; }
        public DOB(int day, int month, int year)
        { 
            this.day = day;
            this.month = month;
            this.year = year;
        }       
    }




}
