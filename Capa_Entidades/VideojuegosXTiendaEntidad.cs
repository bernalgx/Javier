namespace Capa_Entidades // Espacio para organizar clases que se relacionan con entidades del sistema
{
    // Clase que representa la asociacion entre videojuegos y tiendas
    public class VideojuegosXTiendaEntidad
    {
        public required TiendaEntidad Tienda { get; set; } // Tienda donde se encuentra el videojuego
        public required VideojuegoEntidad Videojuego { get; set; } // Videojuego disponible en la tienda
        public int Existencias { get; set; } // Cantidad de copias disponibles en la tienda
    }
}
