namespace Capa_Entidades // Espacio para organizar clases que se relacionan con entidades del sistema
{
    public class VideojuegosXTiendaEntidad  // Clase que representa una videojuego por tienda en el sistema, con acceso interno
    {
        public TiendaEntidad Tienda { get; set; } // Tienda donde esta disponible el videojuego (relacion con TiendaEntidad)
        public VideojuegoEntidad Videojuego { get; set; } // Videojuego disponible en la tienda (relacion con VideojuegoEntidad)
        public int Existencias { get; set; } // Cantidad de existencias del videojuego en la tienda





    }
}
