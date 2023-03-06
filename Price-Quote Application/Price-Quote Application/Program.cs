using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Quote_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            // Weight 

            Console.WriteLine("Please enter the package weight");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day. ");
                Console.ReadLine();
                return;
            }
            


            // Height, Width, Length

            Console.WriteLine("Please enter the package width");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package width");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            if (packageWidth > 50 || packageHeight > 50 || packageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. ");
                Console.ReadLine();
                return;
            }
            

            //Calculation 
            decimal total = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + total);
            Console.WriteLine("Thank you");
            Console.ReadLine();
        }
    }
}
