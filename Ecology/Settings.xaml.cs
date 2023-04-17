using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Ecology
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        string token;
        char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
        Random rand = new Random();
        DataBase database = new DataBase();
        

        public Settings()
        {
            InitializeComponent();
            linq.Visibility = Visibility.Hidden;
            linq_text.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //changing theme
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            for(int i = 0;i<10;i++)
            {
                int n;
                n = rand.Next(letters.Length);
                token += letters[n];
            }
            token_text.Text += token;            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"update Users Set Token='{token}' where ID = '{GlobalData.ID_Get()}'";
            SqlCommand command = new SqlCommand(query, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            linq.Visibility = Visibility.Visible;
            linq_text.Visibility = Visibility.Visible;
        }
    }
}
