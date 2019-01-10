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

        int counterCM = 0;
        public void CheckPassword_Click(object sender, RoutedEventArgs e)
        {

            
             wynik.Text = counterCM.ToString();
            
            string passWrittenCM = TextBox.Text;
            PasswordChecker conatin = new PasswordChecker();
            conatin.ContainsMethod(passWrittenCM,counterCM);

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

        private void Wynik_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
