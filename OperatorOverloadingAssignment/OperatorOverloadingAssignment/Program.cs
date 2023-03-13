using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee_1 = new Employee();
            employee_1.FirstName = "Sample";
            employee_1.LastName = "Studnet";
            employee_1.ID = 100;

            Employee employee_2 = new Employee();
            employee_2.FirstName = "Student";
            employee_2.LastName = "Sample";
            employee_2.ID = 100;

            Employee employee_3 = new Employee();
            employee_3.FirstName = "Amanda";
            employee_3.LastName = "Moor";
            employee_3.ID = 101;

            


        }
        public static bool operator ==(Employee employee_1, Employee employee_2)
        {

            if (employee_1.ID==employee_1.ID)
            {
                Console.WriteLine("This is the same employee, please contact with HR");
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee employee_1, Employee employee_2)
        {

            if (employee_1.ID != employee_2.ID)
            {
                Console.WriteLine("This is not the same employee");
                return true;
            }
            else
            {
                return false;
            }
            
        }
           
    }
}
