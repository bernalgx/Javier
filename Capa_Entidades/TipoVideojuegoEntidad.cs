namespace Capa_Entidades // Espacio para organizar clases que se relacionan con entidades del sistema
{
    public class TipoVideojuegoEntidad // Clase que representa un tipo de videojuego
    {
        public int Id { get; set; } // Identificador unico del tipo de videojuego
        public required string Nombre { get; set; } // Nombre del tipo de videojuego (Accion, Aventura, etc.)
        public required string Descripcion { get; set; } // Breve descripcion
    }
}
