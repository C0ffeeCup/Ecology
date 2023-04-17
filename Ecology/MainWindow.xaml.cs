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
using System.Data.SqlClient;
using System.Data;
namespace Ecology
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainAcount main = new MainAcount();
        DataBase database = new DataBase();
        GlobalData globalData = new GlobalData();
        public static string ID;
        string log;
        string pass;
        public MainWindow()
        {
            InitializeComponent();         
            this.Closing += WindowClosing;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            log = login.Text;
            pass = password.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select * from Users where Email ='{log}' and Password = '{pass}'";
            SqlCommand command = new SqlCommand(query,database.GetConnection());
            database.openConnection();
            adapter.SelectCommand= command;
            adapter.Fill(table);
            if(table.Rows.Count == 1)
            {                                    
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    GlobalData.ID_Set(Convert.ToInt32(reader[0]));
                    
                }
                reader.Close();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("this acount does not exist", "Error");
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           
        }
        
    }

}
