// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using Capa_Acceso_Datos;
using Capa_Entidades;
using System;
using System.Collections.Generic;

namespace Capa_Log_Negocio
{
    public class LogTipoVideojuego // Define la clase LogTipoVideojuego
    {
        public string RegistrarTipoVideojuego(string nombre, string descripcion) // Metodo para registrar un tipo de videojuego
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion))
                return "Todos los campos son requeridos."; // Verifica que los campos nombre y descripcion no esten vacios

            try
            {
                var tipo = new TipoVideojuegoEntidad { Nombre = nombre, Descripcion = descripcion }; // Crea una nueva instancia de TipoVideojuegoEntidad
                DatosTipoVideojuego datos = new DatosTipoVideojuego(); // Crea una instancia de DatosTipoVideojuego
                return datos.Crear(tipo); // Llama al metodo Crear de DatosTipoVideojuego y retorna el resultado
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return "Error: " + ex.Message; // Retorna el mensaje de la excepcion
            }
        }

        public List<TipoVideojuegoEntidad> ObtenerTiposVideojuego() // Metodo para obtener todos los tipos de videojuegos
        {
            try
            {
                DatosTipoVideojuego datos = new DatosTipoVideojuego(); // Crea una instancia de DatosTipoVideojuego
                return datos.ObtenerTodos(); // Llama al metodo ObtenerTodos de DatosTipoVideojuego y retorna la lista de tipos de videojuegos
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                throw new Exception("Error al obtener tipos de videojuegos: " + ex.Message); // Lanza una nueva excepcion con un mensaje de error
            }
        }

        public string EliminarTipoVideojuego(int id) // Metodo para eliminar un tipo de videojuego
        {
            try
            {
                DatosTipoVideojuego datos = new DatosTipoVideojuego(); // Crea una instancia de DatosTipoVideojuego
                bool resultado = datos.Eliminar(id); // Llama al metodo Eliminar de DatosTipoVideojuego y almacena el resultado
                return resultado ? "Tipo eliminado correctamente." : "No se pudo eliminar el tipo."; // Retorna un mensaje segun el resultado
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return "Error: " + ex.Message; // Retorna el mensaje de la excepcion
            }
        }

        public string EditarTipoVideojuego(TipoVideojuegoEntidad tipoVideojuego) // Metodo para editar un tipo de videojuego
        {
            try
            {
                DatosTipoVideojuego datos = new DatosTipoVideojuego(); // Crea una instancia de DatosTipoVideojuego
                bool resultado = datos.Actualizar(tipoVideojuego); // Llama al metodo Actualizar de DatosTipoVideojuego y almacena el resultado
                return resultado ? "Tipo actualizado correctamente." : "No se pudo actualizar el tipo."; // Retorna un mensaje segun el resultado
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return "Error: " + ex.Message; // Retorna el mensaje de la excepcion
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)





