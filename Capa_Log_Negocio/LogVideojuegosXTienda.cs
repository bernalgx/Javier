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
using Capa_Acceso_Datos;
using Capa_Entidades;

namespace Capa_Log_Negocio
{
    public class LogVideojuegosXTienda // Define la clase LogVideojuegosXTienda
    {
        // Lista en memoria para validar la union durante la sesion actual.
        private List<VideojuegosXTiendaEntidad> registros = new List<VideojuegosXTiendaEntidad>(); // Declara una lista de VideojuegosXTiendaEntidad

        public bool RegistrarInventario(VideojuegosXTiendaEntidad nuevoRegistro) // Metodo para registrar un inventario
        {
            // Validar que la combinacion tienda-videojuego no exista en la lista en memoria.
            bool existe = registros.Any(r =>
                r.Tienda.Id == nuevoRegistro.Tienda.Id &&
                r.Videojuego.Id == nuevoRegistro.Videojuego.Id); // Verifica si la combinacion tienda-videojuego ya existe en la lista

            if (existe)
            {
                // La combinacion ya existe; no se permite duplicado.
                return false; // Retorna false si la combinacion ya existe
            }
            else
            {
                // Llamar a la capa de acceso a datos para insertar el registro.
                DatosInventario datos = new DatosInventario(); // Crea una instancia de DatosInventario
                string resultado = datos.Crear(nuevoRegistro); // Llama al metodo Crear de DatosInventario y almacena el resultado

                // Se asume que si el resultado contiene "correctamente", la insercion fue exitosa.
                if (resultado.Contains("correctamente"))
                {
                    // Agregar a la lista en memoria (opcional) para mantener el estado durante la sesion.
                    registros.Add(nuevoRegistro); // Agrega el nuevo registro a la lista en memoria
                    return true; // Retorna true si la insercion fue exitosa
                }
                else
                {
                    // Hubo un error en la insercion.
                    return false; // Retorna false si hubo un error en la insercion
                }
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
