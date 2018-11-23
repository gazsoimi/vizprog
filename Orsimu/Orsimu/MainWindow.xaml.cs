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
        Leny enemy = new Leny();
        


        public MainWindow()
        {
            InitializeComponent();
            lajos.Nev = "lajos";
            pnev.Content = lajos.Nev;
            
            lajos.fegyvere = kard;
            lajos.fegyvere = fejsze;
            pseb.Content = lajos.fegyvere.Maxseb;
            lajos.Aktelet = 100;
            lajos.Maxelet = 100;
            paktelet.Content = lajos.Aktelet;
            pmelet.Content = lajos.Maxelet;

        }

        private void Jarorb_Click(object sender, RoutedEventArgs e)
        {
            //Leny enemy = new Leny();
            enemy.Nev = "voálá";
            enemy.Aktelet = 1000;
            enemy.Maxelet = 100;
            enemy.Vedes = 10;
            enemy.Tamad = 5;
            Enev.Content = enemy.Nev;
            Enev.Content = enemy.Nev;
            Eaktelet.Content = enemy.Aktelet;
            Eelet.Content = enemy.Maxelet;

            Jarorb.Visibility = Visibility.Hidden;
            Harcg.Visibility = Visibility.Visible;
        }

        private void Harcg_Click(object sender, RoutedEventArgs e)
        {
            enemy.Aktelet=enemy.Aktelet - lajos.fegyvere.Maxseb;
            Eaktelet.Content = enemy.Aktelet;
            lajos.Aktelet = lajos.Aktelet - enemy.Tamad;
            paktelet.Content = lajos.Aktelet;
        }
    }
}
