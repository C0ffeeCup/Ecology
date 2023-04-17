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
    /// Логика взаимодействия для MenuGame.xaml
    /// </summary>
    public partial class MenuGame : Window
    {
        public MenuGame()
        {
            InitializeComponent();
            this.Closing += WindowClosing;
        }
        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {            
            MainAcount mainAcount = new MainAcount();
            mainAcount.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            game.Show();
        }
    }
}
