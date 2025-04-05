// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

namespace Capa_Entidades
{
    public class VideojuegoEntidad // Define la clase VideojuegoEntidad
    {
        public int Id { get; set; } // Propiedad para almacenar el ID del videojuego
        public string Nombre { get; set; } // Propiedad para almacenar el nombre del videojuego
        public string Desarrollador { get; set; } // Propiedad para almacenar el desarrollador del videojuego
        public int Lanzamiento { get; set; } // Propiedad para almacenar el año de lanzamiento del videojuego
        public bool Fisico { get; set; } // Propiedad para indicar si el videojuego es fisico
        public int Id_TipoVideojuego { get; set; } // Propiedad para almacenar el ID del tipo de videojuego
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
