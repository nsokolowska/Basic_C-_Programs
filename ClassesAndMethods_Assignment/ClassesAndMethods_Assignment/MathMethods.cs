using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods_Assignment
{
    public class MathMethods
    {
        public static int Method1(int uNumber)
        {
            int myNumber = 345;
            int changedNumber = Convert.ToInt32(uNumber);
            int result = myNumber + uNumber;
            Console.WriteLine(result);
            Console.ReadLine();
            return result;
        }

        public static decimal Method1(decimal uNumber)
        {
            int myNumber1 = 2000;
            decimal decimalNumber = Convert.ToDecimal(uNumber);
            int result1 = (int)(myNumber1 - uNumber);
            Console.WriteLine(result1);
            return result1;
        }
    }
}
