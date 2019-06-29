using ModelGry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace GraGUI2
{
    /// <summary>
    /// Interaction logic for StarterControl.xaml
    /// </summary>
    public partial class StarterControl : UserControl
    {
        public MainWindow Main { get; }

        public StarterControl(MainWindow main)
        {
            InitializeComponent();
            MinNumBox.Text = "0";
            MaxNumBox.Text = "100";
            Main = main;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            var playerName = NameBox.Text.Trim();
            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Wprowadz imię gracza", "Błąd rozpoczęcia gry", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!int.TryParse(MinNumBox.Text, out var minNum))
            {
                MessageBox.Show("Wprowadz dolny próg", "Błąd rozpoczęcia gry", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!int.TryParse(MaxNumBox.Text, out var maxNum))
            {
                MessageBox.Show("Wprowadz górny próg", "Błąd rozpoczęcia gry", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var gra = new Gra(minNum, maxNum);
            Main.StartGame(gra, playerName);
        }

        private void NumBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
