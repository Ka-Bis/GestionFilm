using GestionFilm.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFilm
{
    public class BDDContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Personnality> Personnalities { get; set; }
    }
}
