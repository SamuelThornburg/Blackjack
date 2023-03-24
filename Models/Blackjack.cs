using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Models
{
    public class Blackjack
    {
        private Deck _deck;
        private List<Card> _playerHand;
        private List<Card> _dealerHand;

        public Blackjack()
        {
            _deck = new Deck();
            _playerHand = new List<Card>();
            _dealerHand = new List<Card>();
        }

        public void StartGame()
        {
            _deck.Shuffle();
            _playerHand.Clear();
            _dealerHand.Clear();

            _playerHand.Add(_deck.Draw());
            _dealerHand.Add(_deck.Draw());
            _playerHand.Add(_deck.Draw());
            _dealerHand.Add(_deck.Draw());
        }

        public Card PlayerHit()
        {
            Card drawnCard = _deck.Draw();
            _playerHand.Add(drawnCard);
            return drawnCard;
        }

        public Card DealerHit()
        {
            Card drawnCard = _deck.Draw();
            _dealerHand.Add(drawnCard);
            return drawnCard;
        }

        public int CalculateHandValue(List<Card> hand)
        {
            int value = 0;
            int aces = 0;


            foreach (Card card in hand)
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

        public List<Card> GetPlayerHand()
        {
            return _playerHand;
        }
    }
}
