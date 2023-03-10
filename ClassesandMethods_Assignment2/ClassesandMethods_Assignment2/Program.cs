using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandMethods_Assignment2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, this is simple program. \n Please enter two numbers");
            Console.ReadLine();
            Console.WriteLine("You don't need to enter second number if you don't want to");
            Class1.Add(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
          
        }
    }
}
