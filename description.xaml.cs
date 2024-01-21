using System;
using System.Collections;
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

namespace tswift_album_ranking
{
    /// <summary>
    /// Interaction logic for description.xaml
    /// </summary>
    public partial class description : Page
    {
        public description()
        {
            InitializeComponent();

        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Description.Content = new albumsOverview();
            Continue.Visibility = Visibility.Collapsed;

        }

        private void ContinueEnter(object sender, MouseEventArgs e)
        {
            Continue.Background = new SolidColorBrush(Color.FromRgb(128, 94, 41));
        }

        private void ContinueLeave(object sender, MouseEventArgs e)
        {
            Continue.Background = new SolidColorBrush(Color.FromRgb(152, 114, 76));
        }

    }
}
