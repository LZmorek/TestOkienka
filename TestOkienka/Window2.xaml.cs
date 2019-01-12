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
        int count = 0;
        private void CheckPassword_Click(object sender, RoutedEventArgs e)
        {       
            string passWrittenCM = TextBox.Text;     
            bool condition = true;   
            PasswordChecker Contains = new PasswordChecker();
            condition = Contains.ContainsMethod(passWrittenCM);
            while(true)
                if (condition)
                {
                    break;
                }
                else
                {
                    count++;
                    TextBox2.Text = count.ToString(); 
                    break;
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

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
