// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using Capa_Acceso_Datos;
using Capa_Entidades;

namespace Capa_Log_Negocio
{
    public class LogVideojuego // Define la clase LogVideojuego
    {
        // Metodo anterior que usaba el arreglo en memoria se puede mantener para otros usos.
        private VideojuegoEntidad[] videojuegos = new VideojuegoEntidad[20]; // Declara un arreglo de VideojuegoEntidad con capacidad para 20 elementos
        private int indice = 0; // Declara una variable para llevar el indice del arreglo

        public string RegistroVideojuego(int id, string nombre, int tipo, string desarrollador, int lanzamiento, bool fisico) // Metodo para registrar un videojuego
        {
            // Validacion de campos requeridos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(desarrollador))
                return "Todos los campos son requeridos."; // Verifica que los campos nombre y desarrollador no esten vacios

            // Validar que el Id sea unico
            for (int i = 0; i < indice; i++)
            {
                if (videojuegos[i].Id == id)
                    return "El ID ya existe."; // Verifica que el ID no exista en el arreglo
            }

            // Validar espacio en el arreglo
            if (indice >= videojuegos.Length)
                return "No se pueden agregar mas videojuegos."; // Verifica que haya espacio en el arreglo

            // Registrar el videojuego
            videojuegos[indice] = new VideojuegoEntidad
            {
                Id = id,
                Nombre = nombre,
                Id_TipoVideojuego = tipo,
                Desarrollador = desarrollador,
                Lanzamiento = lanzamiento,
                Fisico = fisico
            };
            indice++; // Incrementa el indice

            return "Videojuego registrado correctamente."; // Retorna un mensaje de exito
        }

        // Nuevo metodo para obtener los videojuegos desde la base de datos
        public List<VideojuegoEntidad> ObtenerVideojuegosDesdeBD() // Metodo para obtener todos los videojuegos desde la base de datos
        {
            DatosVideojuego datos = new DatosVideojuego(); // Crea una instancia de DatosVideojuego
            return datos.ObtenerVideojuegos(); // Llama al metodo ObtenerVideojuegos de DatosVideojuego y retorna la lista de videojuegos
        }

        public string EliminarVideojuego(int id) // Metodo para eliminar un videojuego
        {
            try
            {
                DatosVideojuego datos = new DatosVideojuego(); // Crea una instancia de DatosVideojuego
                bool resultado = datos.Eliminar(id); // Llama al metodo Eliminar de DatosVideojuego y almacena el resultado
                return resultado ? "Videojuego eliminado correctamente." : "No se pudo eliminar el videojuego."; // Retorna un mensaje segun el resultado
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return ex.Message; // Retorna el mensaje de la excepcion
            }
        }

        public string EditarVideojuego(VideojuegoEntidad videojuego) // Metodo para editar un videojuego
        {
            try
            {
                DatosVideojuego datos = new DatosVideojuego(); // Crea una instancia de DatosVideojuego
                bool resultado = datos.Actualizar(videojuego); // Llama al metodo Actualizar de DatosVideojuego y almacena el resultado
                return resultado ? "Videojuego actualizado correctamente." : "No se pudo actualizar el videojuego."; // Retorna un mensaje segun el resultado
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return ex.Message; // Retorna el mensaje de la excepcion
            }
        }
    }
}


//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
