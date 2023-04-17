using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecology
{
    class Main
    {
        
         void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainAcount main = new MainAcount();
            if (main.IsActive)
            {

            }
            else
            {
                Welcome welcome = new Welcome();
                welcome.Show();

            }
        }
    }
}
