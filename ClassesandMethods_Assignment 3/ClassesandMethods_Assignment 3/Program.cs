using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandMethods_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Class1 newClass = new Class1();
            newClass.MathOperation(num1, num2);

            //calling parameters by name:
            newClass.MathOperation(num1: 23, num2: 342);

        }
    }
}
