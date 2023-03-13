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
            Console.WriteLine("Please enter the whole number which system will you to its calculation");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the decimal number which system will you to its calculation");
            decimal decimalNumber = Convert.ToDecimal(Console.ReadLine());

            //Calculation result = new Calculation();
            Calculation.Division(number);
            Calculation.Division(decimalNumber);
            
            Console.WriteLine("As remainder you entered: " + number);
            Calculation.NewOperation(out number);
            Console.WriteLine("The output number is: " + number);
            Console.ReadLine();

            Console.WriteLine("As remainder you entered: " + decimalNumber);
            Calculation.NewOperation(out decimalNumber);
            Console.WriteLine("The output number is: " + decimalNumber);
            Console.ReadLine();



        }
        
    }
}
