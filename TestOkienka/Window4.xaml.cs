﻿using System;
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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window5 baza = new Window5();
            String login = "Noraz", login2 = "Gemi";
            String password = "Noraz", password2 = "Gemi";
            string log = Login.Text;
            string pass = Password.Text;
            if (log.Equals(login) && pass.Equals(password)||log.Equals(login2)&& pass.Equals(password2))
            {
                baza.Show();
                this.Close();
            }
            else
                MessageBox.Show("nie prawidlowe login lub haslo, sprobuj ponownie");
           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();

        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
