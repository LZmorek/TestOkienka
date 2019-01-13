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
using System.Data.SQLite;

namespace TestOkienka
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //SQLiteConnection.CreateFile("Database.db"); w tej wersji jest juz baza danych.
            SQLiteConnection DbCon = new SQLiteConnection("Data Source=Database.db;Version=3");
            DbCon.Open();
            MessageBox.Show("nawiazano polaczenie z nowa baza danych");
            string sql = ("CREATE TABLE Passwords (password string))");
            SQLiteCommand command = new SQLiteCommand(sql, DbCon);
            command.ExecuteNonQuery();
            DbCon.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SQLiteConnection DbCon = new SQLiteConnection("Data Source=Database.db;Version=3;");
            DbCon.Open();
            string sql = ("INSERT into Passwords (password) VAlUES ('" + Textbox2.Text + "')");
            SQLiteCommand command = new SQLiteCommand(sql, DbCon);
            command.ExecuteNonQuery();
            DbCon.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow wroc = new MainWindow();
            wroc.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SQLiteConnection DbCon = new SQLiteConnection("Data Source=Database.db;Version=3;");
            DbCon.Open();
            string sql = "SELECT * from Passwords";
            SQLiteCommand command = new SQLiteCommand(sql, DbCon);
            SQLiteDataReader reader = command.ExecuteReader();
            Textbox.Text = (reader["Password"]).ToString();
            DbCon.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
