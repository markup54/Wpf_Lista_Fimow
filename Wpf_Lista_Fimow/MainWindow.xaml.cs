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

namespace Wpf_Lista_Fimow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Film> Filmy { get; set; } = new ObservableCollection<Film>();
        public List<string> Kategorie{get;set; } = new List<string> { "Animowany", "Sci-Fi", "Dramat", "Fantasy", "Komedia", "Horror" };
        public MainWindow()
        {
            InitializeComponent();
            przygotujFilmy();
            DataContext = this;
            DataGridComboBoxKategoria.ItemsSource = Kategorie;
        }

        private void przygotujFilmy()
        {
            Filmy.Add(new Film("Chłopi", "Animowany", 2023, true));
            Filmy.Add(new Film("Zwierzogród", "Animowany", 2016, false));
            Filmy.Add(new Film("Shrek", "Animowany", 2001, false));
            Filmy.Add(new Film("Interstellar", "Sci-Fi", 2014, false));
            Filmy.Add(new Film("Matrix", "Sci-Fi", 1999, true));
            Filmy.Add(new Film("Titanic", "Dramat", 1997, false));
            Filmy.Add(new Film("Hobbit", "Fantasy", 2012, false));


        }

        private void Button_Click_Dodaj_film(object sender, RoutedEventArgs e)
        {
            string tytul = tytulTextBox.Text;
            string kategoria = kategoriaComboBox.Text;
            int rok = int.Parse(RokTextBox.Text);
            bool czyDlaDoroslych = DlaDorosluychCheckBox.IsChecked == true ? true : false;
            Filmy.Add(new Film(tytul,kategoria, rok, czyDlaDoroslych));
                }
    }
}
