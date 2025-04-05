// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

namespace Capa_Entidades
{
    public class PersonaEntidad // Define la clase PersonaEntidad
    {
        public int Identificacion { get; set; } // Propiedad para almacenar la identificacion de la persona
        public string Nombre { get; set; } // Propiedad para almacenar el nombre de la persona
        public string PrimerApellido { get; set; } // Propiedad para almacenar el primer apellido de la persona
        public string SegundoApellido { get; set; } // Propiedad para almacenar el segundo apellido de la persona
        public DateTime FechaNacimiento { get; set; } // Propiedad para almacenar la fecha de nacimiento de la persona

        // Constructor de la clase PersonaEntidad
        public PersonaEntidad(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento)
        {
            Identificacion = identificacion; // Inicializa la propiedad Identificacion
            Nombre = nombre; // Inicializa la propiedad Nombre
            PrimerApellido = primerApellido; // Inicializa la propiedad PrimerApellido
            SegundoApellido = segundoApellido; // Inicializa la propiedad SegundoApellido
            FechaNacimiento = fechaNacimiento; // Inicializa la propiedad FechaNacimiento
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
