using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> NumbersToDivide = new List<int>() { 1,99,37,26,10, 20, 100, 9, 45, 65, 87 };
            Console.WriteLine("Please pick a number.");
            

            try
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());
                for (int attempt = 0; attempt < NumbersToDivide.Count; attempt++)
                {
                    int results = NumbersToDivide[attempt] / userNumber;
                    Console.WriteLine(NumbersToDivide[attempt] + " divided by " + userNumber + " equals " + results);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please pick a number, not word!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }
            Console.ReadLine();
        }
    }
}
