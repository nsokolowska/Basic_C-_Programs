using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            //getting input from user
            Console.WriteLine("Please enter the number which system will you to its calculation");
            int number = Convert.ToInt32(Console.ReadLine());

            Calculation.Division(number);
            
        }
        
    }
}
