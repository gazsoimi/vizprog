using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orsimu
{
    public class Leny
    {
        int id;
        string nev;
        int maxelet;
        int aktelet;
        int ved;
        int tamad;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        public int Maxelet
        {
            get { return maxelet; }
            set { maxelet = value; }
        }
        public int Aktelet
        {
            get { return aktelet; }
            set { aktelet = value; }
        }
        public int Vedes
        {
            get { return ved; }
            set { ved = value; }
        }
        public int Tamad
        {
            get { return tamad; }
            set { tamad = value; }
        }
    }
}
