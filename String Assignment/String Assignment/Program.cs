using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string part1 = "My name is ";
            string part2 = "Natalia ";
            string part3 = "and I love math.";

            string sentence = part1 + part2 + part3;
            Console.WriteLine(sentence.ToUpper());
            Console.ReadLine();

            StringBuilder aboutme1 = new StringBuilder("I come from Poland");
            Console.WriteLine(aboutme1);
            Console.ReadLine();
            StringBuilder aboutme2 = new StringBuilder("I have been living in the UK for 3 years");
            Console.WriteLine(aboutme2);
            Console.ReadLine();
            StringBuilder aboutme3 = new StringBuilder("I want to be Full Stack Web Developer and develop myslef");
            Console.WriteLine(aboutme3);
            Console.ReadLine();
            StringBuilder aboutme4 = new StringBuilder("Because I love it. Thankn you");
            Console.WriteLine(aboutme4);
            Console.ReadLine();


        }
    }
}
