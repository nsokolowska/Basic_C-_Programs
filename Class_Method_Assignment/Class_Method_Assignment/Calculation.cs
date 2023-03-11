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
            Calculation.NextOperation(total);
        }
        public static void NextOperation(int total)
        {
            int result = (total + 34) / 4;
            Console.WriteLine("The result previous calculation plus thirty four and divided by four equals  " + result);
            Console.ReadLine();
            
        }
    }
}
