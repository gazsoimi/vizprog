using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejszakaiorseg
{
    class PlayerContext : DbContext
    {
        public DbSet<Player> Jatekos {get;set;}
        public DbSet<Enemy> Ellenfel { get; set;}
    }
}
