using NetTopologySuite.Geometries;

namespace NewPeliculasEF.Entidades
{
    public class Cine
    {
        public int IdCine { get; set; }
        public string NombreCine { get;}
        public Point Ubicacion { get; set; }
        public decimal Precio { get; set; }
    }
}
