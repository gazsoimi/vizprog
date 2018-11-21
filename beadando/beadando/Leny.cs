using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaorsi
{
    public class Leny
    {
        public string nev;
        int maxelet;
        int aktelet;

        int tamadas;
        int vedes;
        int gyorsasag;

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
        public int Tamadas
        {
            get { return tamadas; }
            set { tamadas = value; }
        }
        public int Vededs
        {
            get { return vedes; }
            set { vedes = value; }
        }
        public int Gyorsasag
        {
            get { return gyorsasag; }
            set { gyorsasag = value; }
        }
        public Leny(int Maxelet, int Aktelet, int Tamadas, int Vedes, int Gyorsasag)
        {
            this.maxelet = Maxelet;
            this.aktelet = Aktelet;
            this.tamadas = Tamadas;
            this.vedes = Vedes;
            this.gyorsasag = Gyorsasag;

        }
    }
}

