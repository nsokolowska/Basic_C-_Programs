using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //Person 1 
            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            string Person1HourlyRate = Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            string Person1Hours = Console.ReadLine();

            //Person 2
            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            string Person2HourlyRate = Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            string Person2Hours = Console.ReadLine();

            //Math

            int AnnualPerson1 = Convert.ToInt32(Person1HourlyRate) * Convert.ToInt32(Person1Hours) * 52;
           
            Console.WriteLine("Annual salary of Person 1:");
            Console.ReadLine();
            Console.WriteLine(AnnualPerson1);
            Console.ReadLine();

            int AnnualPerson2 = Convert.ToInt32(Person2HourlyRate) * Convert.ToInt32(Person2Hours) * 52;

            Console.WriteLine("Annual salary of Person 2:");
            Console.ReadLine();
            Console.WriteLine(AnnualPerson2);
            Console.ReadLine();

            //Comparison

            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.ReadLine();

            bool Comparison = AnnualPerson1 > AnnualPerson2;
            Console.WriteLine(Comparison);
            Console.ReadLine();
        }
    }
}
