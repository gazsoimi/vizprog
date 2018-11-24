using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace OrSzimulator2000
{
    public static class Valto
    {
        public static MainWindow pageSwitcher;

        public static void Valt(UserControl newPage)
        {
            pageSwitcher.Navigate(newPage);
        }
    }
}
