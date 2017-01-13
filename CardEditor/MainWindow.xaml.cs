using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CardEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChampionsDB db;
        Card CurrentCard;
        public MainWindow()
        {
            db = new ChampionsDB();
            Application.Current.Properties["db"] = db;
//            ObservableCollection<Card> CardsList = new ObservableCollection<Card>(db.Cards);
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource cardViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("cardViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            cardViewSource.Source = new ObservableCollection<Card>(db.Cards);
        }

        private void cardDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            CurrentCard = ((DataGrid)sender).SelectedItem as Card;
            CardEditWindow cew = new CardEditWindow();
            cew.CurrentCard = CurrentCard;
            cew.Owner = this;
            cew.ShowDialog();
        }

        private void AddButton_Click_1(object sender, RoutedEventArgs e)
        {
            CardEditWindow cew = new CardEditWindow();
            cew.CurrentCard = null;
            cew.Owner = this;
            cew.ShowDialog();
            System.Windows.Data.CollectionViewSource cardViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("cardViewSource")));
            cardViewSource.Source = new ObservableCollection<Card>(db.Cards);
            cardDataGrid.InvalidateVisual();
        }
    }
}
