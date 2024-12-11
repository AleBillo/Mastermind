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

namespace lezione7
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] combinazione = new int[4];
        public MainWindow()
        {
            InitializeComponent();
            Random rd = new Random();
            for(int i = 0; i < 4; i++)
            {
                combinazione[i] = rd.Next(0, 9);
            }

        }

        int numeroTent = 6;
        
        
        private void btn_Ceck_Click(object sender, RoutedEventArgs e)
        {
            
            do
            {
                Tentativi(ref numeroTent);
                numTent.Text = numeroTent.ToString();

            } while (numeroTent == -1);

            if (numeroTent == -1 || numeroTent == 0) 
            {
                risultato.Text = "Game Over";
            }
            consigli.Text = null;
            if (input.Text.Length == 4)
            {
                consigli.Text = null;
                for(int i = 0; i < combinazione.Length; i++)
                {
                    if(int.Parse(input.Text.Substring(i,1)) == combinazione[i])
                    {
                        consigli.Text = consigli.Text + "=";
                    }
                    if (int.Parse(input.Text.Substring(i, 1)) > combinazione[i])
                    {
                        consigli.Text = consigli.Text + "-";
                    }
                    if (int.Parse(input.Text.Substring(i, 1)) < combinazione[i])
                    {
                        consigli.Text = consigli.Text + "+";
                    }
                }
            }
            else
            {
                MessageBox.Show("Inserisci 4 numeri", "Errore", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }

        private int Tentativi(ref int numeroTent)
        {
            return numeroTent = numeroTent - 1;
        }
    }
}
