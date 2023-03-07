using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            string[] sentencesOfOneself = new string[7];
            sentencesOfOneself[0] = "I love ";
            sentencesOfOneself[1] = "I like ";
            sentencesOfOneself[2] = "I need ";
            sentencesOfOneself[3] = "I desire ";
            sentencesOfOneself[4] = "I think of ";
            sentencesOfOneself[5] = "I dream of ";
            sentencesOfOneself[6] = "I just want ";
            
            //user input
            Console.WriteLine("Hello, tell me first thing that comes to your mind ");
            Console.ReadLine();
            string firstThing = Console.ReadLine();
            
            while(firstThing.Length <= 1)
            {
                Console.WriteLine("Probably you tell me a number, it cannot be a number");
                Console.ReadLine();
                Console.WriteLine("Tell me first thing that comes to your mind ");
                Console.ReadLine();
                firstThing = Console.ReadLine();
            }
            while(firstThing.Length < 3)
            {
                Console.WriteLine("Too short");
                Console.ReadLine();
                Console.WriteLine("Tell me first thing that comes to your mind ");
                Console.ReadLine();
                firstThing = Console.ReadLine();
            }
            
            //adding user's input
            for (int thing = 0; thing < sentencesOfOneself.Length; thing++)
            {
                sentencesOfOneself[thing] = sentencesOfOneself[thing] + firstThing;
            }
            //printing each string
            for (int thing = 0; thing < sentencesOfOneself.Length; thing++)
            {
                Console.WriteLine(sentencesOfOneself[thing]);
            }
            Console.ReadLine();

            //list
            List<string> songsLyrics = new List<string>();
            songsLyrics.Add("I really really like you");
            songsLyrics.Add("You are the best thing, that's ever been mine");
            songsLyrics.Add("I'm looking right at the other half of me");
            songsLyrics.Add("I know some people search the world to find something like what we have");
            songsLyrics.Add("Would you destroy Something perfect in order to make it beautiful?");
            songsLyrics.Add("I get by with a little help from my friends");
            songsLyrics.Add("Where words leave off, music begins");

            //searching
            Console.WriteLine("Let's play a game \n Can you guess what part of the most popular song are here? \n Let's try");
            string Guess = Console.ReadLine();

            for (int i = 0; i < songsLyrics.Count; i++)
            {
                bool match = songsLyrics.Contains(Guess);
                if (match)

                {
                    int index = songsLyrics.FindIndex(a => a.Contains(Guess));
                    Console.WriteLine("List Item  Found at index: " + index);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, you didn't guess. Try again");
                    Guess = Console.ReadLine();
                }
            }
             Console.ReadLine();


            // new list places
            List<string> Places = new List<string>() { "Warsaw", "Berlin", "London", "New York", "Paris", "Berlin", "Moskow" , "London"};
            Console.WriteLine("Please enter the place");
            string place = Console.ReadLine();

            for (int j=0; j < Places.Count; j++)
            {
                bool isMatch = Places.Contains(place);
                if (isMatch)

                {
                    int index = Places.FindIndex(a => a.Contains(place));
                    Console.WriteLine("List Item  Found at index: " + index);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, you didn't guess. Try again");
                    place = Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
            
    }
}
