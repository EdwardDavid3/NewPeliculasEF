namespace NewPeliculasEF.Entidades
{
    public class CineOferta
    {
        public int IdCineOferta { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal PorcentajeDesc { get; set; }
        public int CineId { get; set; }
    }
}
