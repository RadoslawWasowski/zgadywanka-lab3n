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
    /// Interaction logic for GameControl.xaml
    /// </summary>
    public partial class GameControl : UserControl
    {
        public Gra Gra { get; }
        public MainWindow Main { get; }

        public GameControl(Gra gra, MainWindow main)
        {
            InitializeComponent();
            Gra = gra;
            Main = main;
        }

        private void ZgadujButton_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Number.Text, out var propozycja))
            {
                MessageBox.Show("Wprowadz propozycję", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var ocena = Gra.Ocena(propozycja);

            switch (ocena)
            {
                case Gra.Odpowiedz.Trafiono:
                    Main.EndGame(Gra.LicznikRuchow);
                    break;
                case Gra.Odpowiedz.ZaDuzo:
                    Wynik.Content = "Za duża liczba";
                    break;
                case Gra.Odpowiedz.ZaMalo:
                    Wynik.Content = "Za mała liczba";
                    break;
            }
        }

        private void NumBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
