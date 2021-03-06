﻿using HouseOfCards.Models;

namespace HouseOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            Player dude = new Player("Dude");

            newDeck.Shuffle();

            dude.Draw(newDeck);
            dude.Draw(newDeck);

            dude.Draw(newDeck);

            dude.Discard(0);

            dude.DisplayHand();
        }
    }
}
