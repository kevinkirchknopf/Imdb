using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imdb_Libary
{
    public class FilmMufaj
    {
        public int filmid {  get; set; }
        public Film Film { get; set; }
        
        public int mufajid { get; set; }
        public Mufaj? mufaj { get; set; }
    }
}
