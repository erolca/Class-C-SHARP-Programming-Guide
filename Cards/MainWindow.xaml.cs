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
        public const int NumHands = 4;
        private Pack pack = null;
        private Hand[] hands = new Hand[NumHands];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void dealClick(object sender, RoutedEventArgs e)
        {
            try
            {
                pack = new Pack();

                for (int handNum = 0; handNum < NumHands; handNum++)
                {
                    hands[handNum] = new Hand();
                    for (int numCards = 0; numCards < Hand.HandSize; numCards++)
                    {
                        PlayingCard cardDealt = pack.DealCardFromPack();
                        hands[handNum].AddCardToHand(cardDealt);
                    }
                }

                north.Text = hands[0].ToString();
                south.Text = hands[1].ToString();
                east.Text = hands[2].ToString();
                west.Text = hands[3].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
