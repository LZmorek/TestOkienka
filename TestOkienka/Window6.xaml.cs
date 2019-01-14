﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string pass =TextBox.Text;

            SQLiteConnection DbCon = new SQLiteConnection("Data Source=Database.db;Version=3;FailIfMissing=True;");
            DbCon.Open();
            string sql = ("SELECT FROM Passwords WHERE Password= @password");
            SQLiteCommand command = new SQLiteCommand(sql, DbCon);

            command.CommandText = ("SELECT count (*) FROM Passwords WHERE password= ('"+TextBox.Text+"')");
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count == 0)
            {
                MessageBox.Show("to nie jest poprawne haslo");
                DbCon.Close();
            }
            else
            {
                MessageBox.Show("gratulacje");
                DbCon.Close();
            }

            /*string check = TextBox.Text;
            SQLiteConnection DbCon = new SQLiteConnection("Data Source=Database.db;Version=3;FailIfMissing=True;");
            DbCon.Open();
            string sql = ("SELECT FROM Passwords WHERE Password= @password");
            SQLiteCommand command = new SQLiteCommand(sql, DbCon);
            command.Parameters.AddWithValue("@password", check);
            command.ExecuteNonQuery();
            DbCon.Close();
            SQLiteDataReader read = command.ExecuteReader();
            if (read.HasRows)
            {
                MessageBox.Show("Brawo! odgadles haslo!");
            }
            else
            {
                MessageBox.Show("niestety:( Sprobuj ponownie");
            }*/
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow wroc = new MainWindow();
            wroc.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
