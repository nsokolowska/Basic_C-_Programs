using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   //string
            //    Console.WriteLine("What is your name?");
            //    string yourname = Console.ReadLine(); 
            //    Console.WriteLine("Your name is " + yourname);
            //    Console.ReadLine();


            //Plus 5

            //Console.WriteLine("What is your favourite number?");
            //string favouriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favouriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favourite numeber plus 5 is " + total);
            //Console.ReadLine();

            //BOOL
            bool isStuding = false;
            byte hoursWroked = 42;
            sbyte currentTemperature = -23;
            char questionmark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.30202093;

            float secondsLeft = 2.63f;

            short temperatureOnMars = -341;

            string myName = "Natalia";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();


            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();


            Console.WriteLine(questionmark);
            Console.ReadLine();

                
        }
    }       
}
