using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment__Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, this is a little calucation game \n Please enter your numer and wait to see what happen");
            try
            {
                int UserInput = Convert.ToInt32(Console.ReadLine());
                Calculation.MathMulti(UserInput);
                Calculation.CalculationWithDate(UserInput);
                Calculation.RemainderMath(UserInput);
            }
            catch (FormatException)
            {
               Console.WriteLine("You have to enter the number");
                Console.ReadLine();
                return;
            }
            catch (DivideByZeroException)
            {
               Console.WriteLine("You cannot enter zero value");
                Console.ReadLine();
                return;
            }
            
        }   

       
    }
}
