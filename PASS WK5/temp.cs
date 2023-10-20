using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASS_WK5
{
    internal class temp
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double CalculateAverage(double[] numbers)
        {
            if (numbers.Length == 0)
                return 0;

            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            return sum / numbers.Length;
        }

        public string GreetUser(string name)
        {
            return "Hello, " + name + "!";
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public int[] GenerateFibonacci(int n)
        {
            if (n <= 0) return new int[0];

            int[] fibonacciSequence = new int[n];
            fibonacciSequence[0] = 0;
            if (n > 1) fibonacciSequence[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
            }

            return fibonacciSequence;
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public Person CreatePerson(string name, int age)
        {
            return new Person { Name = name, Age = age };
        }


        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public string GetGrade(int score)
        {
            if (score >= 90)
                return "A";
            else if (score >= 80)
                return "B";
            else if (score >= 70)
                return "C";
            else if (score >= 60)
                return "D";
            else
                return "F";
        }

        public int SumOfNumbers(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }


        public bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public int GetNumberFromUser()
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);
            return number;
        }

    }
}
