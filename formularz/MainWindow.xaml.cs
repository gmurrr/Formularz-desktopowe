using System;
using System.Windows;

namespace formularz
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnZatwierdz_Click(object sender, RoutedEventArgs e)
        {
            bool imieWypelnione = !string.IsNullOrWhiteSpace(txtImie.Text);

            bool plecZaznaczona = (rbKobieta.IsChecked == true || rbMezczyzna.IsChecked == true);

            bool dataWybrana = dpDataUrodzenia.SelectedDate.HasValue;

            bool infoWypelnione = !string.IsNullOrWhiteSpace(txtInformacje.Text);

            if (imieWypelnione && plecZaznaczona && dataWybrana && infoWypelnione)
            {
                MessageBox.Show("Formularz został poprawnie wypełniony i zatwierdzony!", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola (w tym wybrać płeć i datę urodzenia).", "Błąd walidacji", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnAnuluj_Click(object sender, RoutedEventArgs e)
        {
            txtImie.Clear();
            rbKobieta.IsChecked = false;
            rbMezczyzna.IsChecked = false;
            dpDataUrodzenia.SelectedDate = null;
            txtInformacje.Clear();
        }
    }
}