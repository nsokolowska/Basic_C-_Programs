﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Sutis = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>
            {
                "Two", "Three", "Fours", "Five", "Six", "Seven", 
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach(string face in Faces)
            {
                foreach (string suit in Sutis)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle( int times = 1)
        {
            
            for (int i = 0; 9 < times; i++)
            {
                
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }

        }
    }
}
