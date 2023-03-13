using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        public void Quit()
        {
            Console.Write("The person " + FirstName + " " + LastName + " left job.");
        }

    }

    
}