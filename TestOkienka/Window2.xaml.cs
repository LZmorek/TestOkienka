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

namespace TestOkienka
{
  
    public partial class Window2 : Window
    {
        
        public Window2()
        {
            InitializeComponent();
        }

        private void CheckPassword_Click(object sender, RoutedEventArgs e)
        {
            string TexBox1 = TextBox.Text;
            int count = 0;
            while (true)
            {

                if (TexBox1.Contains("tajemnica"))
                {
                    MessageBox.Show("Dobra robota");
                    break;
                }
                else
                {
                    MessageBox.Show("wpisz ponownie haslo");
                    count++;

                    wynik.Text = count.ToString();
                    break;

                }
            }

        }

        private void MenuGlowne_Click(object sender, RoutedEventArgs e)
        {
            MainWindow back = new MainWindow();
            back.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
