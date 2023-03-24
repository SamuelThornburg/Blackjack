using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Cards.Models;

namespace Cards
{
    public partial class CardControl : UserControl
    {
        public CardControl()
        {
            InitializeComponent();
        }

        public void SetCard(Card card)
        {
            string suitName = card.CardSuit.ToString().ToLower();
            string rankName = card.CardRank.ToString().ToLower();

            if (card.CardRank >= Card.Rank.Two && card.CardRank <= Card.Rank.Ten)
            {
                rankName = ((int)card.CardRank).ToString();
            }

            string cardImage = $"CardImages/{rankName}_of_{suitName}.png";
            CardImage.Source = new BitmapImage(new Uri(cardImage, UriKind.Relative));
        }
        public void SetHidden(bool hidden)
        {
            HiddenCardCover.Visibility = hidden ? System.Windows.Visibility.Visible : System.Windows.Visibility.Collapsed;
        }

    }
}
