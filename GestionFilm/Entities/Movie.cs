using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFilm.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Studio { get; set; }

        public Personnality PersonnalityId { get; set; }
    }
}
