﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Models
{
    public class Card
    {
        public enum Suit
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }
        public enum Rank
        {
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }
        public Suit CardSuit { get; private set; }  
        public Rank CardRank { get; private set; }

        public Card(Suit suit, Rank rank)
        {
            CardSuit = suit;
            CardRank = rank;
        }

        public override string ToString()
        {
            return $"{CardRank} of {CardSuit}";
        }
    }
}
