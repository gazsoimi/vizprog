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

namespace Vaorsi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void keszit_Click(object sender, RoutedEventArgs e)
        {
            Leny Jatekos = new Leny(100, 100, 10, 5, 10);
            Jatekos.nev = tnev.Text;
            nevcimke.Content = Jatekos.nev;
            eletcimke.Content = Jatekos.Aktelet;
            Maxecimke.Content = Jatekos.Maxelet;
            tamcimke.Content = Jatekos.Tamadas;
            vedcimke.Content = Jatekos.Vededs;
            gyorscimke.Content = Jatekos.Gyorsasag;
        }
    }
}
