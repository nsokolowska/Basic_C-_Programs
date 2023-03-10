using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods_Assignment
{
    public class MathMethods
    {
        public int Method1(int uNumber)
        {
            int myNumber = 345;
            int result = myNumber + Convert.ToInt32(uNumber);
            Console.WriteLine(result);
            Console.ReadLine();
            return result;
        }

        public decimal Method1(decimal uNumber)
        {
            int myNumber1 = 2000;
            int result = (int)(myNumber1 - Convert.ToDecimal(uNumber));
            Console.WriteLine(result);
            Console.ReadLine();
            return result;
        }

        public string Method1(string uNumber)
        {
            int myNumber = 25;
            int newNumber = Convert.ToInt32(uNumber);
            int firstresult = myNumber * newNumber;
            string result = firstresult.ToString();
            Console.WriteLine(result);
            Console.ReadLine();
            return result;
        }
    }
}
