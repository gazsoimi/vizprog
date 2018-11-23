using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orsimu
{
    public class Fegyver
    {
        int id;
        string nev;
        int minseb;
        int maxseb;

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
        public int Minseb
        {
            get { return minseb; }
            set { minseb = value; }
        }
        public int Maxseb
        {
            get { return maxseb; }
            set { maxseb = value; }
        }
       /* public Fegyver(int Id,int Maxseb,int Minseb,string Nev){
            this.id = Id;
            this.maxseb = Maxseb;
            this.minseb = Minseb;
            this.nev = Nev;
            }*/
    }
}
