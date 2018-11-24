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
using System.Windows.Controls;



namespace OrSzimulator2000
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Valto.pageSwitcher = this;
         

        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        private void Belepes(object sender, RoutedEventArgs e)
        {

            String FelhasznaloNev = felhasznalonev.Text;
            String Jelszo = jelszo.Password.ToString();


            using (AdatbazisEntities adat = new AdatbazisEntities())
            {

                var Felhasznalo =adat.Felhasznalok.FirstOrDefault(F => F.Felhasznalonev == FelhasznaloNev);


                if (Felhasznalo != null)
                {
                    if (Felhasznalo.Jelszo == Jelszo)
                    {
                        Valto.Valt(new Jateknezet());
                    }
                    else
                    {
                        LoginHibauzenet.Text = "A megadott jelszó nem egyezik.";
                    }
                }
                else
                {
                    LoginHibauzenet.Text = "Nincs Ilyen felhasználó";
                }






            }

        }



        }
}
