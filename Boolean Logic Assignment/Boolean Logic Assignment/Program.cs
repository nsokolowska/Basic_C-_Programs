using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Questions
            Console.WriteLine("What is your age?");
            string Age = Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI violation?   [i.e., for driving under the influence of alcohol]");
            string DUIstring = Console.ReadLine();
            bool DUI = bool.Parse(DUIstring);



            Console.WriteLine("How many speeding tickets have you had?");
            string Tickets = Console.ReadLine();

            //Boolen

            bool Qualified = (Convert.ToInt32(Age) > 15 && Convert.ToInt32(Tickets) < 3 != DUI);
            Console.WriteLine("Qualified?");
            Console.WriteLine(Qualified);
            Console.ReadLine();

        }
    }
}
