using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandMethods_Assignment2
{
    class Class1
    {
        public static int Add(int num1, params string[] num2)
        {
            int total = num1;
            foreach (string number in num2)
            {
                int i = Convert.ToInt32(number);
                total +=i ;
            };
            
            Console.WriteLine("This is " + total + " in total");
            Console.ReadLine();
            return total;
        }
    }
}
