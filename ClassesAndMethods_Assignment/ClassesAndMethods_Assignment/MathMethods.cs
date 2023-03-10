using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods_Assignment
{
    public class MathMethods
    {
        public int Method1(int intNumber)
        {
            int myNumber = 345;
            int result = myNumber + Convert.ToInt32(intNumber);
            Console.WriteLine(result);
            Console.ReadLine();
            return result;
        }

        public decimal Method1(decimal decimalNumber)
        {
            int myNumber1 = 2000;
            int result = (int)(myNumber1 - Convert.ToDecimal(decimalNumber));
            Console.WriteLine(result);
            Console.ReadLine();
            return result;
        }

        public string Method1(string stringNumber)
        {
            int myNumber = 25;
            int newNumber = Convert.ToInt32(stringNumber);
            int firstresult = myNumber * newNumber;
            string result = firstresult.ToString();
            Console.WriteLine(result);
            Console.ReadLine();
            return result;
        }
    }
}
