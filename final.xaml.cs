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
using Microsoft.Win32;

namespace tswift_album_ranking
{
    public partial class final : Page
    {
        public string filePath = "C:/Users/mirja/Desktop/averages.txt";

        public final()
        {
            InitializeComponent();

            string[] lines = File.ReadAllLines(filePath);

            List <Tuple<string, double>> albumRanking = new List <Tuple<string, double>>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                string albumName = parts[0].Trim();
                double ranking;

                if (double.TryParse(parts[1],out ranking))
                {
                    albumRanking.Add(new Tuple<string, double>(albumName, ranking));
                } 
                else
                {
                    Console.WriteLine($"Error parsing score for line: {line}");
                }
            }

            albumRanking = albumRanking.OrderByDescending(x => x.Item2).ToList();

            for (int i = 0; i < Math.Min(3, albumRanking.Count); i++)
            {
                var tuple = albumRanking[i];
                resultTextBlock.AppendText($"{i+1}. {tuple.Item1} : {tuple.Item2}\r\n");
            }

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

            File.WriteAllText(filePath, string.Empty);

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Length == 0)
            {
                MessageBox.Show("Form cleared successfully!");
            }
            else
            {
                MessageBox.Show("An Error occurred while deleting!");
            }
            
        }

    }
}
