using System;
using System.Collections.Generic;
using System.Data;
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
   
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string del = TextBox.Text;
            SQLiteConnection DbCon = new SQLiteConnection("Data Source=Database.db;Version=3;FailIfMissing=True;");
            DbCon.Open();
            string sql = ("DELETE FROM Passwords WHERE Password= @password");
            SQLiteCommand command = new SQLiteCommand(sql, DbCon);
            command.Parameters.AddWithValue("@password", del);
            command.ExecuteNonQuery();
            DbCon.Close();
            MessageBox.Show("Usunieto wybrane haslo");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string pass = Textbox2.Text;
            SQLiteConnection DbCon = new SQLiteConnection("Data Source=Database.db;Version=3;FailIfMissing=True;");
            DbCon.Open();
            string sql = ("INSERT INTO Passwords (password) VAlUES (@password)");  
            SQLiteCommand command = new SQLiteCommand(sql, DbCon);
            command.Parameters.AddWithValue("@password", pass);
            command.ExecuteNonQuery();
            DbCon.Close();
            MessageBox.Show("Udane utworzenie nowego hasła");
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
            string sql = "SELECT * from Passwords ";
            SQLiteCommand command = new SQLiteCommand(sql, DbCon);
            command.ExecuteNonQuery();
            SQLiteDataAdapter dataadp = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable("Passwords");
            dataadp.Fill(dt);
            DataGrid.ItemsSource = dt.DefaultView;
            dataadp.Update(dt);
            DbCon.Close();
        }

        private void Textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Menu6_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void Menu6_Click(object sender, RoutedEventArgs e)
        {
            Window6 db = new Window6();
            db.Show();
            this.Close();
        }
    }
}
