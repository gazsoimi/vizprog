using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orsimu
{
   public class Player : Leny
    {
        int penz;
       public Fegyver fegyvere;

        public int Penz
        {
            get { return penz; }
            set { penz = value; }
        }
        public Player()
        {

        }
    }
}
