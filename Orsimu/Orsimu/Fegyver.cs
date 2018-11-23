using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaorsi
{
   public class Fegyver
    {
        int fid;
        string nev;
        int maxseb;
        int minseb;

        public int Fid {
            get { return fid; }
            set { fid = value; }
        }
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        public int Maxseb
        {
            get { return maxseb; }
            set { maxseb = value; }
        }
        public int Minseb
        {
            get { return minseb; }
            set { minseb = value; }
        }


    }
}
