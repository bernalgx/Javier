// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Entidades
{
    public class InventarioConsultaEntidad // Define la clase InventarioConsultaEntidad
    {
        public int Id_Tienda { get; set; } // Propiedad para almacenar el ID de la tienda
        public string TiendaNombre { get; set; } // Propiedad para almacenar el nombre de la tienda
        public string TiendaDireccion { get; set; } // Propiedad para almacenar la direccion de la tienda
        public decimal Id_VideoJuego { get; set; } // Propiedad para almacenar el ID del videojuego
        public string VideojuegoNombre { get; set; } // Propiedad para almacenar el nombre del videojuego
        public string TipoVideojuegoNombre { get; set; } // Propiedad para almacenar el nombre del tipo de videojuego
        public int Existencias { get; set; } // Propiedad para almacenar la cantidad de existencias del videojuego en la tienda
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)

