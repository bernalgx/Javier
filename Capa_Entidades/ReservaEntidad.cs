// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

namespace Capa_Entidades
{
    public class ReservaEntidad // Define la clase ReservaEntidad
    {
        public int IdReserva { get; set; } // Propiedad para almacenar el ID de la reserva
        public VideojuegosXTiendaEntidad VideojuegoTienda { get; set; } // Propiedad para almacenar la entidad VideojuegosXTienda
        public ClienteEntidad Cliente { get; set; } // Propiedad para almacenar la entidad Cliente
        public DateTime FechaReserva { get; set; } // Propiedad para almacenar la fecha de la reserva
        public int Cantidad { get; set; } // Propiedad para almacenar la cantidad de la reserva

        // Constructor de la clase ReservaEntidad
        public ReservaEntidad(int id, VideojuegosXTiendaEntidad videojuego, ClienteEntidad cliente, DateTime fecha, int cantidad)
        {
            IdReserva = id; // Inicializa la propiedad IdReserva
            VideojuegoTienda = videojuego; // Inicializa la propiedad VideojuegoTienda
            Cliente = cliente; // Inicializa la propiedad Cliente
            FechaReserva = fecha; // Inicializa la propiedad FechaReserva
            Cantidad = cantidad; // Inicializa la propiedad Cantidad
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
