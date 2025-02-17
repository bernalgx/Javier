namespace Capa_Entidades // Espacio para organizar clases que se relacionan con entidades del sistema
{
    public class TipoVideojuegoEntidad // Clase que representa un tipo de videojuego
    {
        public int Id { get; set; } // Identificador unico del tipo de videojuego
        public string Nombre { get; set; } = string.Empty; // Nombre del tipo de videojuego (puede ser nulo)
        public string Descripcion { get; set; } = string.Empty; // Descripcion del tipo de videojuego

    }  

}
