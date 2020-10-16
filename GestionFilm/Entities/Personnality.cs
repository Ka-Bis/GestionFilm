using System;
using System.Collections.Generic;
using WinFormswithEFSample;

namespace GestionFilm.Entities
{
    public class Personnality
    {
        public int PersonnalityId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime Birth { get; set; }
        public string Nationnality { get; set; }
        public bool Actor { get; set; }
        public bool Real { get; set; }
        public bool Producer { get; set; }

        public virtual List<Movie> Movie { get; set; }
    }
}