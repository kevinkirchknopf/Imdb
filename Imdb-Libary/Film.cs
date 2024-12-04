using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imdb_Libary
{
    public class Film
    { 
        public int Id { get; set; }
        public string? Cim { get; set; }
        public DateOnly? Date { get; set; }
        public int? hossz { get; set; }
        public string? mufaj { get; set; }
        public string ? rendezo { get; set; }
        public string ? kivonat {  get; set; }
        public string? borito { get; set; }
        public float? pontszam { get; set; }
        public int? szavazat { get; set; }
        public string? kiado { get; set; }

        public List<FilmMufaj> FilmMufajok { get; set; }
    }
}
