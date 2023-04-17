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

namespace Ecology
{
    /// <summary>
    /// Логика взаимодействия для MainAcount.xaml
    /// </summary>
    public partial class MainAcount : Window
    {
        Welcome welcome = new Welcome();
        public MainAcount()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)//acount
        {
            AcountPreferences acountPreferences= new AcountPreferences();
            acountPreferences.Show();           
        }
        private void Battery_Click(object sender, RoutedEventArgs e)
        {
            Battery battery= new Battery();
            battery.Show();
        }
        private void Bottle_Click(object sender, RoutedEventArgs e)
        {
            Bottle bottle = new Bottle();
            bottle.Show();
        }
        private void Game_Click(object sender, RoutedEventArgs e)
        {
            MenuGame game = new MenuGame();
            game.Show();
            this.Close();
        }
        private void Map_Click(object sender, RoutedEventArgs e)
        {
            Map map = new Map();
            map.Show();
        }
        private void Settings(object sender, RoutedEventArgs e)
        {
            Settings settings= new Settings();
            settings.Show();
        }
        private void AboutUs(object sender, RoutedEventArgs e)
        {
            AboutUs about= new AboutUs();
            about.Show();
            this.Close();
        }
        private void ActualTasks(object sender, RoutedEventArgs e)
        {
            FastTasks fastTasks= new FastTasks();           
            fastTasks.Show();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            welcome.Show();
            this.Close();
        }
        private void Report(object sender, RoutedEventArgs e)
        {

        }
        private void CompletedTasks(object sender, RoutedEventArgs e) 
        { 
            Completed completed = new Completed();
            completed.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
