using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imdb_Libary
{
    public class AppServices : IAppServices
    {

        public readonly FilmContext FilmContext;
        public AppServices()
        {
            FilmContext = new FilmContext();
        }

        public void AddFilm(Film film)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Film> GetAllFilm()
        {
            return new ObservableCollection<Film>((from f in FilmContext.film.Include(c => c.FilmMufajok).ThenInclude(c => c.mufaj) select f));
        }

        public Film GetFilm(int id)
        {
            return (from f in FilmContext.film.Include(c => c.FilmMufajok).ThenInclude(c => c.mufaj) where f.id == id select f).FirstOrDefault();
        }

        public void RemoveFilm(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateFilm(Film film)
        {
            throw new NotImplementedException();
        }
    }
}
