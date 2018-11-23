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

namespace Ejszakaiorseg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using(var db = new PlayerContext())
            {
                var valaki = new Player() { Nev = "valaki", Id = 1, Maxelet = 100, Aktelet = 100, Tamadas = 10, Vedes = 5 };
                var arny = new Enemy() { Nev = "gonosz", Id = 1, Maxelet = 100, Aktelet = 100, Tamadas = 10, Vedes = 5 };

                db.Jatekos.Add(valaki);
                db.Ellenfel.Add(arny);
                db.SaveChanges();
            }
        }
    }
}
