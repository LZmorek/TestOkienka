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
using System.Windows.Navigation;

namespace TestOkienka
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        String passWritten;
        String[] LoginArray = new String[]
        {
            "GemiRKT","Noraz",
        };

        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow= new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void CreateAccount()
        {
            Window1 NewAccount = new Window1();
            NewAccount.CreateLogin();
          
        }

        private void CreateLogin()
        {
            
            while (true)
            {
                passWritten = pass1.Text;


                if (LoginArray.Contains(passWritten))
                {
                    MessageBox.Show("Wybierz inny Login");
                    break;
                }
                else 
                {
                    LoginArray = new List<string>(LoginArray) { passWritten }.ToArray();
                    MessageBox.Show("Login zostal wprowadzony");
                    break;
                
                }


            }


        }
        private void CreatePassword()
        {

        }

        private void Pass1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CreateLogin();
        }
    }
}
