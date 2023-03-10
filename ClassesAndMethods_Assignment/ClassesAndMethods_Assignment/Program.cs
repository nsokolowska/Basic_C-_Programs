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

            //int uNumber = 10;
            decimal uNumber = 15.5m;
            // uNumber = "100";

            MathMethods math1 = new MathMethods();
            math1.Method1(uNumber);
            

        }
    }
}