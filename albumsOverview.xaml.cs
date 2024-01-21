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
using System.Drawing;
using System.Collections;

namespace tswift_album_ranking
{
    public partial class albumsOverview : Page
    {
        public albumsOverview()
        {
            InitializeComponent();
            
        }

        private void Debut_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Debut());

        }

        private void Fearless_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Fearless());

        }

        private void SpeakNow_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new SpeakNow());

        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Red());

        }

        private void OneNine_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new OneNine());

        }

        private void Reputation_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Reputation());

        }

        private void Lover_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Lover());

        }

        private void Folklore_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Folklore());
            
        }

        private void Evermore_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Evermore());

        }

        private void Midnights_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Midnights());
        }

        private void final_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new final());
            FinalRanking.Visibility = Visibility.Collapsed;

        }
    }
}
