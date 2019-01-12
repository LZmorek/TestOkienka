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
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Equal_Method(object sender, RoutedEventArgs e)
        {
            Window1 EM = new Window1();
            EM.Show();
            this.Close();
        }

        private void Contains_Method(object sender, RoutedEventArgs e)
        {
            Window2 MC = new Window2();
            MC.Show();
            this.Close();

        }

        private void Array_Method(object sender, RoutedEventArgs e)
        {
            Window3 AM = new Window3();
            AM.Show();
            this.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
      
        }
    }

}


 

