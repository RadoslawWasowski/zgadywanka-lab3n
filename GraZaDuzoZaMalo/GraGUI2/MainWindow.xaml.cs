using ModelGry;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace GraGUI2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string playerName;

        public ObservableCollection<GameResult> GameResults { get; set; } = new ObservableCollection<GameResult>();
        public MainWindow()
        {
            InitializeComponent();
            Switcher.Content = new StarterControl(this);
            Results.ItemsSource = GameResults;
            Results.Items.IsLiveSorting = true;
            Results.Items.SortDescriptions.Add(new SortDescription { PropertyName = "Moves", Direction = ListSortDirection.Ascending });
            Results.Items.SortDescriptions.Add(new SortDescription { PropertyName = "PlayerName", Direction = ListSortDirection.Ascending });
        }

        public void StartGame(Gra gra, string playerName)
        {
            this.playerName = playerName;
            Switcher.Content = new GameControl(gra, this);
        }

        public void EndGame(int result)
        {
            GameResults.Add(new GameResult { PlayerName = playerName, Moves = result });
            Switcher.Content = new StarterControl(this);
            Results.Items.Refresh();
            
        }
    }
}
