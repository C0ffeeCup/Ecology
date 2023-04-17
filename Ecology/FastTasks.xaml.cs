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
using Microsoft.SqlServer.Server;
using System.Data.Common;

namespace Ecology
{
    /// <summary>
    /// Логика взаимодействия для FastTasks.xaml
    /// </summary>
    public partial class FastTasks : Window
    {
        Random random= new Random();
        DataBase database = new DataBase();
        string query;
        int n;
       
        public FastTasks()
        {
            InitializeComponent();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            
            for (int i = 0; i < 5; i++)
            {                
                n = random.Next(10);
                query = $"select Task from Daily where ID='{n}' ";              
                database.openConnection();
                SqlCommand command = new SqlCommand(query, database.GetConnection());               
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    task_list.Items.Add(reader[0]);
                }
                
                reader.Close();
            }            

           
        }
        

        private void task_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
