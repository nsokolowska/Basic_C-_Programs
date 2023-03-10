using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandMethods_Assignment2
{
    class Class1
    {
        public static int Add(int num1, int num2=1)
        {
            int total = num1 + num2;
                       
            Console.WriteLine("This is " + total + " in total");
            Console.ReadLine();
            return total;
        }
    }
}
