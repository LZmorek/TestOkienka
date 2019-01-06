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

namespace TestOkienka
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

        String passWritten;
        String passConst = "Zupa Pomidorowa";
        String[] passArray = new String[3]
               {"kupa" , "gowno" , "sraka"};

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                string passWritten = Pass.Text;
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                passWritten = Pass.Text;

                if (passWritten.Equals(passConst))
                {
                    MessageBox.Show("jestes super odgadles haslo");
                    break;
                }
                else
                {
                    MessageBox.Show("jestes Baran spróbuj ponownie:");
                    break;

                }
            }
        }

                private void Button_Click_2(object sender, RoutedEventArgs e)

                {
                    while (true)
                    {
                        passWritten = Pass.Text; 

                        if (passArray.Contains(passWritten))
                        {
                            MessageBox.Show("Swietnie! Kupa radosci!");
                            break;
                        }

                        else
                        {
                            MessageBox.Show("Wez sie do kupy chopie!");
                            break;

                        }

                    }
                }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 win2 = new Window1();
            win2.Show();
            this.Close();
        }
    }

}


 

