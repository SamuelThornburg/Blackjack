using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Models
{
    public class Player
    {
        public List<Card> Hand { get; set; }

        public Player()
        {
            Hand = new List<Card>();
        }

        public int CalculateScore()
        {
            int value = 0;
            int aces = 0;
            

            foreach (Card card in Hand)
            {
                int cardValue = (int)card.CardRank;

                if (cardValue >= 10)
                {
                    cardValue = 10;
                }
                else if (cardValue == 1)
                {
                    cardValue = 11;
                    aces++;
                }   
                value += cardValue;
            }

            while (value > 21 && aces > 0)
            {
                value -= 10;
                aces--;
            }
            return value;
        }
    }
}
