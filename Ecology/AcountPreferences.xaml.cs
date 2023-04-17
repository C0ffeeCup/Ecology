using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для AcountPreferences.xaml
    /// </summary>
    public partial class AcountPreferences : Window
    {
        DataBase database = new DataBase();
        GlobalData globalData = new GlobalData();
        MainWindow acount = new MainWindow();
        public AcountPreferences()
        {
            InitializeComponent();
            //if we  have a name and surname - show them
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();//input name and surname
            DataTable table = new DataTable();
            string query = $"update Users Set Name='{name.Text}',Surname='{surname.Text}' where ID = '{GlobalData.ID_Get()}'";
            SqlCommand command = new SqlCommand(query, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
        }
    }
}
