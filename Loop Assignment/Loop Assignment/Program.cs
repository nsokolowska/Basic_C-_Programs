using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting input
            Console.WriteLine("What is the room tempeature in your place?");
            int roomTemperature = Convert.ToInt32(Console.ReadLine());

            bool goodTemperature = roomTemperature == 70;

            //do while roomTemperature
            do
            {
                switch (roomTemperature)
                {
                    case 35:
                        Console.WriteLine("It's too cold! Turn it up.");
                        Console.WriteLine("What is the room tempeature in your place?");
                        roomTemperature = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 50:
                        Console.WriteLine("Not that bad... but could be better. Turn it up.");
                        Console.WriteLine("What is the room tempeature in your place?");
                        roomTemperature = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 75:
                        Console.WriteLine("It's a little elevated! Turn it down.");
                        Console.WriteLine("What is the room tempeature in your place?");
                        roomTemperature = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 100:
                        Console.WriteLine("It's too got here! Turn it down.");
                        Console.WriteLine("What is the room tempeature in your place?");
                        roomTemperature = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 70:
                        Console.WriteLine("It's perfect temperature.");
                        goodTemperature = true;
                        break;

                    default:
                        Console.WriteLine("The recommended temperature is 70. Set your thermostat please");
                        Console.WriteLine("What is the room tempeature in your place?");
                        roomTemperature = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                
            }
            while (!goodTemperature);
            Console.ReadLine();
            
            Console.WriteLine("Ok so we set the room temperature up. So now it's time for a little game");
            Console.ReadLine();

            Console.WriteLine("Please try to guess number from 1 to 100");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isGuessed = false;
            while (!isGuessed)
            {
                switch (number)
                {
                    case 35:
                        Console.WriteLine("Congratulations your guessed correctly. Thank you!");
                        isGuessed = true;
                        break;
                    case 30:
                        Console.WriteLine("You didn't guees but your are close. Try higher!");
                        Console.WriteLine("Please try to guess number from 1 to 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You didn't guees but your are close. Try higher!");
                        Console.WriteLine("Please try to guess number from 1 to 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 28:
                        Console.WriteLine("You didn't guees but your are close. Try higher!");
                        Console.WriteLine("Please try to guess number from 1 to 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 27:
                        Console.WriteLine("You didn't guees but your are close. Try higher!");
                        Console.WriteLine("Please try to guess number from 1 to 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 26:
                        Console.WriteLine("You didn't guees but your are close. Try higher!");
                        Console.WriteLine("Please try to guess number from 1 to 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 40:
                        Console.WriteLine("You didn't guees but your are close. Try lower!");
                        Console.WriteLine("Please try to guess number from 1 to 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 41:
                        Console.WriteLine("You didn't guees but your are close. Try lower!");
                        Console.WriteLine("Please try to guess number from 1 to 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 42:
                        Console.WriteLine("You didn't guees but your are close. Try lower!");
                        Console.WriteLine("Please try to guess number from 1 to 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 43:
                        Console.WriteLine("You didn't guees but your are close. Try lower!");
                        Console.WriteLine("Please try to guess number from 1 to 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 44:
                        Console.WriteLine("You didn't guees but your are close. Try lower!");
                        Console.WriteLine("Please try to guess number from 1 to 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("You didn't guees. Try again");
                        Console.WriteLine("Please try to guess number from 1 to 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
