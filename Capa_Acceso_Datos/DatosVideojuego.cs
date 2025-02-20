using System.Data;
using System.Text;
using Capa_Entidades;
using Microsoft.Data.SqlClient;

namespace Capa_Acceso_Datos
{
    public static class DatosVideojuego
    {
        private static VideojuegoEntidad[] videojuegos = new VideojuegoEntidad[20];
        private static int contador = 0;

        // Crear un nuevo videojuego
        public static bool Crear(VideojuegoEntidad videojuego)
        {
            if (contador >= 20) return false; // Limite alcanzado
            
            // Validar que el ID no exista
            foreach (var v in videojuegos)
            {
                if (v != null && v.Id == videojuego.Id)
                    throw new Exception("El ID ya existe.");
            }

            videojuegos[contador] = videojuego;
            contador++;
            return true;
        }

        // Obtener todos los videojuegos
        public static VideojuegoEntidad[] ObtenerTodos()
        {
            return videojuegos;
        }

        // Actualizar un videojuego
        public static bool Actualizar(VideojuegoEntidad videojuego)
        {
            for (int i = 0; i < contador; i++)
            {
                if (videojuegos[i] != null && videojuegos[i].Id == videojuego.Id)
                {
                    videojuegos[i] = videojuego;
                    return true;
                }
            }
            return false;
        }

        // Eliminar un videojuego por ID
        public static bool Eliminar(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (videojuegos[i] != null && videojuegos[i].Id == id)
                {
                    videojuegos[i] = null;
                    return true;
                }
            }
            return false;
        }
    }
}
