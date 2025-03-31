using Capa_Acceso_Datos;
using Capa_Entidades;
using System;
using System.Collections.Generic;

namespace Capa_Log_Negocio
{
    public class LogTipoVideojuego
    {
        public string RegistrarTipoVideojuego(string nombre, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion))
                return "Todos los campos son requeridos.";

            try
            {
                var tipo = new TipoVideojuegoEntidad { Nombre = nombre, Descripcion = descripcion };
                DatosTipoVideojuego datos = new DatosTipoVideojuego();
                return datos.Crear(tipo);
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public List<TipoVideojuegoEntidad> ObtenerTiposVideojuego()
        {
            try
            {
                DatosTipoVideojuego datos = new DatosTipoVideojuego();
                return datos.ObtenerTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener tipos de videojuegos: " + ex.Message);
            }
        }

        public string EliminarTipoVideojuego(int id)
        {
            try
            {
                DatosTipoVideojuego datos = new DatosTipoVideojuego();
                bool resultado = datos.Eliminar(id);
                return resultado ? "Tipo eliminado correctamente." : "No se pudo eliminar el tipo.";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public string EditarTipoVideojuego(TipoVideojuegoEntidad tipoVideojuego)
        {
            try
            {
                DatosTipoVideojuego datos = new DatosTipoVideojuego();
                bool resultado = datos.Actualizar(tipoVideojuego);
                return resultado ? "Tipo actualizado correctamente." : "No se pudo actualizar el tipo.";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}



