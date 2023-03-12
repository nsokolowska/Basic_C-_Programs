using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.ID = 100;
            employee.SayName();

            Employee empolyee = new Employee();
            employee.FirstName = "Studnet";
            employee.LastName = "Sample";
            empolyee.ID = 100;
            employee.SayName();

            if (employee.ID == employee.ID)
            {
                Console.WriteLine("This is the same employee, please contact with HR.");
            }
            Console.ReadLine();

            // Dismissed employeesDismissed = new Dismissed();
            //employeesDismissed.Quit();

            Console.ReadLine();
        }
    }
}
