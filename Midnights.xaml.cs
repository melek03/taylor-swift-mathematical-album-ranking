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
using System.IO;
using System.Collections.ObjectModel;

namespace tswift_album_ranking
{
    public partial class Midnights : Page
    {
        public class Song
        {
            public string SongTitle { get; set; }
            public int Ranking { get; set; }
        }

        public ObservableCollection<Song> songs { get; set; }

        public Midnights()
        {
            InitializeComponent();
            songs = new ObservableCollection<Song>();
            songDataGrid.ItemsSource = songs;
            LoadSongsFromFile("C:/Users/mirja/Desktop/tswift album ranking/albums/Midnights.txt");
        }

        private void LoadSongsFromFile(string filePath)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    songs.Add(new Song { SongTitle = line.Trim(), Ranking = 0 });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading songs from file: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private double calculateAverage()
        {
            int sum = songs.Sum(song => song.Ranking);
            double average = (double)sum / songs.Count;

            return average;
        }

        private void averageOnEnter(object sender, MouseEventArgs e)
        {
            Average.Background = new SolidColorBrush(Color.FromRgb(48, 3, 24));

        }

        private void averageOnLeave(object sender, MouseEventArgs e)
        {
            Average.Background = new SolidColorBrush(Color.FromRgb(73, 26, 48));

        }

        private void saveOnEnter(object sender, MouseEventArgs e)
        {
            Save.Background = new SolidColorBrush(Color.FromRgb(105, 66, 78));
        }

        private void saveOnLeave(object sender, MouseEventArgs e)
        {
            Save.Background = new SolidColorBrush(Color.FromRgb(131, 106, 114));
        }

        private void average_Click(object sender, RoutedEventArgs e)
        {
            double average = calculateAverage();

            AverageDisplay.Text = $"Album Average: {average:F2}";
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            string filepath = "C:/Users/mirja/Desktop/averages.txt";
            double ranking = calculateAverage();
            string newData = $"Midnights: {ranking:F2}";

            // Read all lines from the file
            List<string> lines = File.ReadAllLines(filepath).ToList();

            // Find the line that you want to replace (if it exists)
            int lineIndex = lines.FindIndex(line => line.Contains("Midnights:"));

            // Replace the line if found, or add a new line if not found
            if (lineIndex != -1)
            {
                lines.RemoveAt(lineIndex);
                lines.Add(newData);
            }
            else
            {
                // Add the new data to the end of the file if the line is not found
                lines.Add(newData);
            }

            // Write the updated lines back to the file
            File.WriteAllLines(filepath, lines);

            MessageBox.Show("Ranking saved successfully!");
        }

        private void Back_MouseEnter(object sender, MouseEventArgs e)
        {
            Back.Fill = new SolidColorBrush(Color.FromRgb(48, 3, 24));
        }

        private void Back_MouseLeave(object sender, MouseEventArgs e)
        {
            Back.Fill = new SolidColorBrush(Color.FromRgb(73, 26, 48));
        }

        private void Back_Click(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new albumsOverview());

        }
    }
}
