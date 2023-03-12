using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Assignment
{
    public class Dismissed : Employee, IQuittable
    {
        public List<Employee> employeesDismissed { get; set; }
        
        public string Reason { get; set; }
        public int LenghtOfService { get; set; }

        
        void Quit()
        {
            foreach (Employee employeeDismissed in employeesDismissed)
            {
                Console.WriteLine("Employee: " + FirstName + " " + LastName + "has left their job because " + Reason + " after " + LenghtOfService + " months of their service.");
                Console.ReadLine();
            }
        }
    }
}
