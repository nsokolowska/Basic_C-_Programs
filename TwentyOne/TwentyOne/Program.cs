﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        
        public void Main(string[] args)
        {
            Player<Card> player = new Player<Card>();
            
            Deck deck = new Deck(); 
            deck.Shuffle(3);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
           
        }
    }
}
