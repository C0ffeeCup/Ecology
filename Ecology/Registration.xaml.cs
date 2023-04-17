using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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

namespace Ecology
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        DataBase database= new DataBase();
        MainAcount main = new MainAcount();
        public Registration()
        {
            InitializeComponent();
            this.Closing += WindowClosing;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (password.Text == password1.Text)
            {
                var log = login.Text;
                var pass = password.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string query = $"insert into Users (Email,Password) values('{log}','{pass}')";
                SqlCommand command = new SqlCommand(query, database.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                main.Show();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Пароли не совпадают","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            
        }
        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (main.IsActive)
            {

            }
            else
            {
                Welcome welcome = new Welcome();
                welcome.Show();
                
            }
        }

        private void password1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
