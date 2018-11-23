using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orsimu
{
     class PlayerContext : DbContext
    {
        public DbSet<Player> Jatekosok { get; set; }
        public DbSet<Fegyver> Fegyverek { get; set; }
        public DbSet<Leny> Lenyek { get; set; }

        
    }
}
