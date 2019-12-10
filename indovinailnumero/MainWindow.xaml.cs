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

namespace indovinailnumero
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
        Random random = new Random();
        int numeroCasuale;
        int tentativi = 0;

        private void btn_genera_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int nd = int.Parse(txt_difficolta.Text);
                if (nd < 0 || nd > 100)
                    MessageBox.Show("il livello di difficolta non è valido", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Hand);
                numeroCasuale = random.Next(0, nd);
            }
            catch
            {
                MessageBox.Show("Non puoi inserire una lettera", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }

        private void btn_reset_Click(object sender, RoutedEventArgs e)
        {
            lbl_ris.Content = "";
            txt_numero.Clear();
            txt_difficolta.Clear();
            tentativi = 0;

        }

        private void btn_indovina_Click(object sender, RoutedEventArgs e)
        {
            tentativi++;
            int n = int.Parse(txt_numero.Text);

            if (numeroCasuale > n)
            {
                lbl_ris.Content = "il numero è troppo basso";
            }
            else if (numeroCasuale < n)
            {
                lbl_ris.Content = "il numero è troppo alto";
            }
            else
            {
                lbl_ris.Content = $"Hai indovinato con {tentativi}";
            }
        }
    }
}
