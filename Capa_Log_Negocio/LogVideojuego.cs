using Capa_Acceso_Datos;
using Capa_Entidades;

namespace Capa_Log_Negocio
{
    public class LogVideojuego
    {


        // Método anterior que usaba el arreglo en memoria se puede mantener para otros usos.
        private VideojuegoEntidad[] videojuegos = new VideojuegoEntidad[20];
        private int indice = 0;


        public string RegistroVideojuego(int id, string nombre, int tipo, string desarrollador, int lanzamiento, bool fisico)
        {
            // Validación de campos requeridos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(desarrollador))
                return "Todos los campos son requeridos.";

            // Validar que el Id sea unico
            for (int i = 0; i < indice; i++)
            {
                if (videojuegos[i].Id == id)
                    return "El ID ya existe.";
            }

            // Validar espacio en el arreglo
            if (indice >= videojuegos.Length)
                return "No se pueden agregar más videojuegos.";

            // Registrar el videojuego
            videojuegos[indice] = new VideojuegoEntidad
            {
                Id = id,
                Nombre = nombre,
                TipoVideojuegoId = tipo,
                Desarrollador = desarrollador,
                Lanzamiento = lanzamiento,
                Fisico = fisico
            };
            indice++;

            return "Videojuego registrado correctamente.";
        }



        // Nuevo método para obtener los videojuegos desde la base de datos
        public List<VideojuegoEntidad> ObtenerVideojuegosDesdeBD()
        {
            DatosVideojuego datos = new DatosVideojuego();
            return datos.ObtenerVideojuegos();
        }

        public string EliminarVideojuego(int id)
        {
            try
            {
                DatosVideojuego datos = new DatosVideojuego();
                bool resultado = datos.Eliminar(id);
                return resultado ? "Videojuego eliminado correctamente." : "No se pudo eliminar el videojuego.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EditarVideojuego(VideojuegoEntidad videojuego)
        {
            try
            {
                DatosVideojuego datos = new DatosVideojuego();
                bool resultado = datos.Actualizar(videojuego);
                return resultado ? "Videojuego actualizado correctamente." : "No se pudo actualizar el videojuego.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}


