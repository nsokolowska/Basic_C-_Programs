using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Assignment
{
    class Program
    {
        static void Main()
        {
            //string task 
            string[] Sentence = new string[7];
            Sentence[0] = "Never give up";
            Sentence[1] = "The life is beautiful";
            Sentence[2] = "You are good enough";
            Sentence[3] = "It's going to be okey";
            Sentence[4] = "You are pretty";
            Sentence[5] = "I like your smile";
            Sentence[6] = "Think about yourself";

            Console.WriteLine("Please insert the number to get your sentence for today");
            Console.ReadLine();
            int UserInput = Convert.ToInt32(Console.ReadLine());

           
            if (UserInput < 7)
            {
                Console.WriteLine(Sentence[UserInput]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("I would like to say something nice to you, but you need to insert number from 0 to 6");
                Console.ReadLine();
                Console.WriteLine("Please insert the number to get your sentence for today");
                Console.ReadLine();
                UserInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Sentence[UserInput]);
                Console.ReadLine();
            }
            

            //int task
            int[] LuckyNumbers = new int[]{7,13,67,2000,9,2,8};

            Console.WriteLine("Ok. You got your sentece. It's time for lukcy number for today!");
            Console.ReadLine();
            int UserNumber = Convert.ToInt32(Console.ReadLine());

            if (UserNumber < 7)
            {
                Console.WriteLine("Your lukcy number is: "+ LuckyNumbers[UserNumber] +".Check the meaning!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("I would like to tell you the lucky number, but you need to insert number from 0 to 6");
                Console.ReadLine();
                Console.WriteLine("Please insert the number to get your sentence for today");
                Console.ReadLine();
                UserNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your lukcy number is: " + LuckyNumbers[UserNumber] + "!");
                Console.ReadLine();
            }

            //string list
            List<string> Goodbye = new List<string>();
            Goodbye.Add("Thank you. See you soon");
            Goodbye.Add("Thank you. Goodbye");
            Goodbye.Add("Thank you. Have a nice day!");
            Goodbye.Add("Thank you. See you tomorrow");
            Goodbye.Add("Thank you. Bye");

            Console.WriteLine("To close the program insert number from 0 to 4 to get you goodbye meesage.");
            Console.ReadLine();
            int GoodbyeNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Goodbye[GoodbyeNumber]);
            Console.ReadLine();

        }
    }
}
