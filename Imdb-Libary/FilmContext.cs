using Microsoft.EntityFrameworkCore;

namespace Imdb_Libary
{
    public class FilmContext : DbContext
    {
        public DbSet<Film> Film { get; set; }
        public DbSet<Mufaj> Mufajok { get; set; }
        public DbSet<FilmMufaj> FilmMufajok { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cs = "server=localhost;userid=root;password=;database=13imdb";
            optionsBuilder.UseMySql(cs, ServerVersion.AutoDetect(cs));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmMufaj>()
                .HasKey(bc => new { bc.mufajid, bc.filmid });

           

            
        }
    }
}
