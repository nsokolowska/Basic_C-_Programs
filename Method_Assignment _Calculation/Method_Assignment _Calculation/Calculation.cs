using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment__Calculation
{
    public class Calculation
    {
        public static int MathMulti(int UserInput)
        {
            Random random = new Random();
            int ComputerChoice = random.Next(1, 100);
            int result = (ComputerChoice * UserInput) + 10;
            Console.WriteLine("The result of random number which is "+ ComputerChoice +" multiply by " + UserInput + " is " + result);
            Console.ReadLine();
            return result;
        }

        public static int CalculationWithDate(int UserInput)
        {
            int myBirthday = 12011996;
            int result_2 = myBirthday / 2 + UserInput *2 +123;
            Console.WriteLine("Number consists my date of birth divided by 2 plus " + UserInput + " multiply by 2 plus 123 equals " + result_2);
            Console.ReadLine();
            return result_2;
        }
        public static int RemainderMath(int UserInput)
        {
            Random random2 = new Random();
            int SecondComputerChoice = random2.Next(1, 100);
            int result_3 = SecondComputerChoice % UserInput;
            Console.WriteLine("The remainder of " + SecondComputerChoice + " divided by " + UserInput + " is " + result_3);
            Console.ReadLine();
            return result_3;
        }
    }
}
