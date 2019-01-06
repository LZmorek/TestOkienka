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
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        
        public Window2()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckPassword_Click(object sender, RoutedEventArgs e)
        {
            String passWritten;
            passWritten = TextBox.Text;
            while (true)
            {
                
                if (passWritten.Contains("tajemnica"))
                {
                    MessageBox.Show("Dobra robota");
                    break;
                }
                else
                {
                    MessageBox.Show("wpisz ponownie haslo");
                    break;

                }
            }
        }

        private void MenuGlowne_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
