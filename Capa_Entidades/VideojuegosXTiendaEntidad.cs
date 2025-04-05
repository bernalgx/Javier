// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using Capa_Entidades;

public class VideojuegosXTiendaEntidad // Define la clase VideojuegosXTiendaEntidad
{
    public TiendaEntidad Tienda { get; set; } // Propiedad para almacenar la entidad Tienda
    public VideojuegoEntidad Videojuego { get; set; } // Propiedad para almacenar la entidad Videojuego
    public decimal Existencias { get; set; } // Propiedad para almacenar la cantidad de existencias del videojuego en la tienda

    // Constructor de la clase VideojuegosXTiendaEntidad
    public VideojuegosXTiendaEntidad(TiendaEntidad tienda, VideojuegoEntidad videojuego, decimal existencias)
    {
        Tienda = tienda; // Inicializa la propiedad Tienda
        Videojuego = videojuego; // Inicializa la propiedad Videojuego
        Existencias = existencias; // Inicializa la propiedad Existencias
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
