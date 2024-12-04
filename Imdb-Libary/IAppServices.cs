using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imdb_Libary
{
    public interface IAppServices
    {
        public void AddFilm(Film film);
        public Film GetFilm(int id);
        public void RemoveFilm(int id);
        public void UpdateFilm(Film film);
        public ObservableCollection<Film> GetAllFilm();

    }
}
