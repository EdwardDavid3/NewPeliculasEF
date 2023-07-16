namespace NewPeliculasEF.Entidades
{
    public class Pelicula
    {
        public int IdPelicula { get; set; }
        public string NombrePelicula { get; }
        public bool EnCartelera { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string PosterURL { get; set; }
        public CineOferta CineOferta { get;}
    }
}
