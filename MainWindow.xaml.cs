using Cards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cards
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Deck _deck;
        private CardControl _playerCard1;
        private CardControl _playerCard2;
        private CardControl _dealerCard1;
        private CardControl _dealerCard2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Initialize deck and shuffle
            _deck = new Deck();
            _deck.Shuffle();

            // Create card controls
            _playerCard1 = new CardControl();
            _playerCard2 = new CardControl();
            _dealerCard1 = new CardControl();
            _dealerCard2 = new CardControl();

            // Set card images
            _playerCard1.SetCard(_deck.Draw());
            _playerCard2.SetCard(_deck.Draw());
            _dealerCard1.SetCard(_deck.Draw());
            _dealerCard2.SetCard(_deck.Draw());
            _dealerCard2.SetHidden(true);

            // Add card controls to the layout
            PlayerCards.Children.Add(_playerCard1);
            PlayerCards.Children.Add(_playerCard2);
            DealerCards.Children.Add(_dealerCard1);
            DealerCards.Children.Add(_dealerCard2);

            // Add stand and hit buttons once start button is clicked
            HitButton.Visibility = Visibility.Visible;
            StandButton.Visibility = Visibility.Visible;
        }

        private void HitButton_Click(object sender, RoutedEventArgs e)
        {
            // draw a card for the player from the deck
            Card drawnCard = _deck.Draw();

            

        }

        private void StandButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
