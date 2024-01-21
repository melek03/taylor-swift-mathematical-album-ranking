using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

namespace tswift_album_ranking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {
            Close.Fill = Brushes.DarkRed;
        }

        private void Minimize_MouseEnter(object sender, MouseEventArgs e)
        {
            Minimize.Fill = new SolidColorBrush(Color.FromRgb(221, 184, 14));
        }

        private void Close_MouseLeave(object sender, MouseEventArgs e)
        {
            Close.Fill = Brushes.Red;
        }

        private void Minimize_MouseLeave(object sender, MouseEventArgs e)
        { 
            Minimize.Fill = new SolidColorBrush(Color.FromRgb(255, 210, 0));
        }

        private void closeApp(object sender, MouseButtonEventArgs e)
        {
            try 
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void minimizeApp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new description();
            Start.Visibility = Visibility.Collapsed;
        }

        private void StartEnter(object sender, MouseEventArgs e)
        {
            Start.Background = new SolidColorBrush(Color.FromRgb(128, 94, 41));
        }

        private void StartLeave(object sender, MouseEventArgs e)
        {
            Start.Background = new SolidColorBrush(Color.FromRgb(152, 114, 76));
        }

        
    }   
}
