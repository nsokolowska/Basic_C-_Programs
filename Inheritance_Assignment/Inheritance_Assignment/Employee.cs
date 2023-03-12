using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public class Employee : Person
    {
        public int ID { get; set; }
        public void Quit()
        {
            Console.Write("The person " + FirstName + " " + LastName + " left job.");
            Console.ReadLine();
        }
    }
}
