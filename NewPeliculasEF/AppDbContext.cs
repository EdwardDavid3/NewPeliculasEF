using Microsoft.EntityFrameworkCore;
using NewPeliculasEF.Entidades;

namespace NewPeliculasEF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genero>().HasKey(e => e.IdGenero);
            modelBuilder.Entity<Genero>().Property(e => e.NombreGenero)
                .HasMaxLength(200)
                .IsRequired();

            modelBuilder.Entity<Actor>().HasKey(e => e.IdActor);
            modelBuilder.Entity<Actor>().Property(e => e.ActorNombre)
                .HasMaxLength(200)
                .IsRequired();
            modelBuilder.Entity<Actor>().Property(e => e.FechaNacimiento).HasColumnType("date");

            modelBuilder.Entity<Cine>().HasKey(e => e.IdCine);
            modelBuilder.Entity<Cine>().Property(e => e.NombreCine)
                .HasMaxLength(200)
                .IsRequired();
            modelBuilder.Entity<Cine>().Property(e => e.Precio).HasPrecision(9, 2);

            modelBuilder.Entity<Pelicula>().Property(e => e.PosterURL)
                .HasMaxLength(500)
                .IsUnicode(false);
            modelBuilder.Entity<Pelicula>().HasKey(e => e.IdPelicula);
            modelBuilder.Entity<Pelicula>().Property(e => e.NombrePelicula)
                .HasMaxLength(250)
                .IsRequired();
            modelBuilder.Entity<Pelicula>().Property(e => e.FechaEstreno).HasColumnType("date");

            modelBuilder.Entity<CineOferta>().HasKey(e => e.IdCineOferta);
            modelBuilder.Entity<CineOferta>().Property(e => e.PorcentajeDesc).HasPrecision(5, 2);
            modelBuilder.Entity<CineOferta>().Property(e => e.FechaIni).HasColumnType("date");
            modelBuilder.Entity<CineOferta>().Property(e => e.FechaFin).HasColumnType("date");
            int x = 0;


        }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<CineOferta> CineOfertas { get; set; }



    }
}
