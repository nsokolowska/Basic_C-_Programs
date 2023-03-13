using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    public static class Calculation
    {
        public static void Division(int number)
        {
            int total = number / 2;
            Console.WriteLine("The number: " + number + " divied by 2 equals " + total);
            Console.ReadLine();
            
            
        }
        public static void Division(decimal decimalNumber)
        {
            decimal total = decimalNumber / 2;
            Console.WriteLine("The number: " + decimalNumber + " divied by 2 equals " + total);
            Console.ReadLine();
            

        }
        public static void NewOperation(out int number)
        {
            int newNumber = 10;
            number = newNumber;
            number += number * 2;
                                  
        }
        public static void NewOperation(out decimal decimalNumber)
        {
            decimal NewNumber = 10.5m;
            decimalNumber = NewNumber;
            decimalNumber += decimalNumber / 2;
        }
    }
}
