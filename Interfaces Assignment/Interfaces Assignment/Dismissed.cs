using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    public class Dismissed : Employee, IQuittable
    {
        public string Reason { get; set; }
        public int LenghtOfService { get; set; }
        public List<string> employeesDismissed { get; set; }
        
        void Quit()
        {
            foreach (string employeeDismissed in employeesDismissed) {
                Console.WriteLine("Employee: " + FirstName + " " + LastName + "has left their job because " + Reason + " after " + LenghtOfService + " months of their service.");
                Console.ReadLine();
            }
        }
        

    }
}
