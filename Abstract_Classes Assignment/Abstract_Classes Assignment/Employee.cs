using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    public class Employee : Person
    {
        public override void SayName()
        {
            base.SayName();
            Console.ReadLine();
        }
    }
}
