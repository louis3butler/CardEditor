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
using System.Windows.Shapes;

namespace CardEditor
{
    /// <summary>
    /// Interaction logic for CardEditWindow.xaml
    /// </summary>
    public partial class CardEditWindow : Window
    {
        public Card CurrentCard;
        public List<CardEffect> CurrentEffects;
        bool bIsNew;
        public CardEditWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //System.Windows.Data.CollectionViewSource cardViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("cardViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // cardViewSource.Source = [generic data source]
            if (CurrentCard == null)
            {
                CurrentCard = new Card();
                CurrentCard.CardLevel = 1;
                CurrentCard.Attack = CurrentCard.Defense = CurrentCard.Reach = CurrentCard.Speed = 1;
                SaveButton.IsEnabled = true;
                bIsNew = true;
            }
            else
            {
                //using (ChampionsDB db = new ChampionsDB())
                //{
                //}
                SaveButton.IsEnabled = false;
                bIsNew = false;
            }
            grid1.DataContext = CurrentCard;
            SaveButton.IsEnabled = false;
        }


        private void reachTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
        }

        private void speedTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
        }

        private void notesTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
        }

        private void versionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            ChampionsDB db = new ChampionsDB();
            if (bIsNew)
            {
                db.Entry(CurrentCard).State = System.Data.Entity.EntityState.Added;
            }
            else
            {
                db.Entry(CurrentCard).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void nameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
        }

        private void flavorTextTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
        }

        private void costTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
        }

        private void attackTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
        }

        private void defenseTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
        }

        private void cardLevelComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
        }
    }
}
