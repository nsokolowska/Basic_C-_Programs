using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods_Assignment
{
    class Program
    {
        public static void Main()
        {

            int intNumber = 25;
            decimal decimalNumber = 15.5m;
            string stringNumber = "100";

            MathMethods math1 = new MathMethods();
            math1.Method1(intNumber);
            math1.Method1(decimalNumber);
            math1.Method1(stringNumber);


        }
    }
}