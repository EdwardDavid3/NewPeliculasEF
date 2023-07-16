namespace NewPeliculasEF.Entidades
{
    public class Actor
    {
        public int IdActor { get; set; }
        public string ActorNombre { get; set; }
        public string Biografia { get; set; }
        public DateTime? FechaNacimiento { get; set; }
    }
}
