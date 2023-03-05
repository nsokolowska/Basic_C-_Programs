using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main()
        {
            //Welcome message
            Console.WriteLine("Pitman Training");
            Console.ReadLine();

            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            //Question 1 - string
            Console.WriteLine("What course are you in?");
            string Answer1 = Console.ReadLine();
            Console.WriteLine("You are in course " + Answer1);
            Console.ReadLine();

            //Question 2 
            Console.WriteLine("What page number?");
            string Answer2string = Console.ReadLine();
            int Answer2 = Convert.ToInt32(Answer2string);
            Console.WriteLine("You are on the page number: " + Answer2);
            Console.ReadLine();

            //Question 3
            Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false\"");
            string Answer3string = Console.ReadLine();
            bool Answer3 = bool.Parse(Answer3string);
            Console.WriteLine(Answer3 + " :I need help");
            Console.ReadLine();

            //Question 4
            Console.WriteLine("Were there any positive experiences you’d like to share?  Please provide specifics.");
            string Answer4 = Console.ReadLine();
            Console.WriteLine("The positive experiences: " + Answer4);
            Console.ReadLine();

            //Question 5 
            Console.WriteLine("Is there any other feedback you’d like to provide?  Please be specific.");
            string Answer5 = Console.ReadLine();
            Console.WriteLine("Other feedback: " + Answer5);
            Console.ReadLine();

            //Question 6
            Console.WriteLine("How many hours did you study today?");
            string Answer6string = Console.ReadLine();
            int Answer6 = Convert.ToInt32(Answer6string);
            Console.WriteLine("I studied for " + Answer6 + " hour/s");
            Console.ReadLine();

            //Goodbye Message

            Console.WriteLine("Thank you for your responses.  An Instructor will respond shortly.  Have a great day!");
            Console.ReadLine();
         }
    }
}
