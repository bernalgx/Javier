namespace Capa_Entidades // Espacio para organizar clases que se relacionan con entidades del sistema
{
    public class VideojuegoEntidad // Clase que representa una videojuego en el sistema, con acceso interno
    {
        public int Id { get; set; } // Identificador unico del videojuego
        public string Nombre { get; set; } = string.Empty;// Nombre del videojuego
        public TipoVideojuegoEntidad TipoVideojuego { get; set; }// Tipo de videojuego (relacion con TipoVideojuegoEntidad)
        public string Desarrollador { get; set; } = string.Empty;// Nombre de la empresa desarrolladora del videojuego
        public int Lanzamiento { get; set; }  // Año de lanzamiento del videojuego
        public bool Fisico { get; set; } // Indica si el videojuego es fisico (true) o digital (false)
    }
}
