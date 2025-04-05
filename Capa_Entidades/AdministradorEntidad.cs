// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================
public class AdministradorEntidad // Define la clase AdministradorEntidad
{
    public decimal Identificacion { get; set; } // Propiedad para almacenar la identificacion del administrador
    public string Nombre { get; set; } // Propiedad para almacenar el nombre del administrador
    public string PrimerApellido { get; set; } // Propiedad para almacenar el primer apellido del administrador
    public string SegundoApellido { get; set; } // Propiedad para almacenar el segundo apellido del administrador
    public DateTime FechaNacimiento { get; set; } // Propiedad para almacenar la fecha de nacimiento del administrador
    public DateTime FechaContratacion { get; set; } // Propiedad para almacenar la fecha de contratacion del administrador

    // Propiedad adicional para mostrar en ComboBox
    public string NombreCompleto => $"{Nombre} {PrimerApellido} {SegundoApellido}"; // Propiedad calculada para obtener el nombre completo del administrador
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
