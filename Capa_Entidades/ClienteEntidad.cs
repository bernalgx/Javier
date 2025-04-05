// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================


using System;

namespace Capa_Entidades
{
    public class ClienteEntidad // Define la clase ClienteEntidad
    {
        public int Identificacion { get; set; } // Propiedad para almacenar la identificacion del cliente
        public string Nombre { get; set; } // Propiedad para almacenar el nombre del cliente
        public string PrimerApellido { get; set; } // Propiedad para almacenar el primer apellido del cliente
        public string SegundoApellido { get; set; } // Propiedad para almacenar el segundo apellido del cliente
        public DateTime FechaNacimiento { get; set; } // Propiedad para almacenar la fecha de nacimiento del cliente
        public bool JugadorEnLinea { get; set; } // Propiedad para indicar si el cliente es un jugador en linea

        // Propiedad para mostrar nombre completo
        public string NombreCompleto => $"{Nombre} {PrimerApellido} {SegundoApellido}"; // Propiedad calculada para obtener el nombre completo del cliente
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
