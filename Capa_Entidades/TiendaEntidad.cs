// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================


public class TiendaEntidad // Define la clase TiendaEntidad
{
    public int Id { get; set; } // Propiedad para almacenar el ID de la tienda
    public string Nombre { get; set; } // Propiedad para almacenar el nombre de la tienda
    public string Direccion { get; set; } // Propiedad para almacenar la direccion de la tienda
    public string Telefono { get; set; } // Propiedad para almacenar el telefono de la tienda
    public bool Activa { get; set; } // Propiedad para indicar si la tienda esta activa
    public decimal Id_Administrador { get; set; } // Propiedad para almacenar el ID del administrador de la tienda

    // Propiedad adicional para mostrar el nombre completo del administrador
    public string NombreAdministrador { get; set; } // Propiedad para almacenar el nombre completo del administrador
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
