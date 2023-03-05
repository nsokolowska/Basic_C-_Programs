using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operation_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Please insert your first number");
            string UserNumber = Console.ReadLine();
            int by50 = 50 * Convert.ToInt32(UserNumber);
            Console.WriteLine("Your number mulitiplied by 50 = " + by50);
            Console.ReadLine();

            //Task 2
            Console.WriteLine("Please insert your second number");
            string UserNumber2 = Console.ReadLine();
            int plus25 = 25 + Convert.ToInt32(UserNumber2);
            Console.WriteLine("Your number plus + 25 = " + plus25);
            Console.ReadLine();

            //Task 3
            Console.WriteLine("Please insert your third number");
            string UserNumber3 = Console.ReadLine();
            decimal division = Convert.ToInt32(UserNumber3) / 12.5m;
            Console.WriteLine("Your number divided by 12.5 = " + division);
            Console.ReadLine();

            //Task 4 
            Console.WriteLine("Please insert your fourth number");
            string UserNumber4 = Console.ReadLine();
            bool compare = Convert.ToInt32(UserNumber4) > 50;
            Console.WriteLine("Is your number greater than 50? " + compare);
            Console.ReadLine();

            //Task 5 
            Console.WriteLine("Please insert your fifth number");
            string UserNumber5 = Console.ReadLine();
            int remainder = Convert.ToInt32(UserNumber4) / 7;
            Console.WriteLine("Remainder from your number divided by 7 is " + remainder);
            Console.ReadLine();


        }
    }
}
