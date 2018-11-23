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

namespace Orsimu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player lajos = new Player();
        Fegyver kard = new Fegyver(1,10,2,"kard");
        Fegyver fejsze = new Fegyver(2, 20, 30,"fejsze");
        
        
        public MainWindow()
        {
            InitializeComponent();
            lajos.Nev = "lajos";
            pnev.Content = lajos.Nev;
            lajos.fegyvere = kard;
            lajos.fegyvere = fejsze;
            pseb.Content = lajos.fegyvere.Maxseb;

            
        }
    }
}
