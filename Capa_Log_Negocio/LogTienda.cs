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
    public class LogTienda // Define la clase LogTienda
    {
        private TiendaEntidad[] tiendas = new TiendaEntidad[20]; // Declara un arreglo de TiendaEntidad con capacidad para 20 elementos
        private int indice = 0; // Declara una variable para llevar el indice del arreglo

        public string RegistroTienda(int id, string nombre, string direccion, string telefono, bool activa, int administradorId) // Metodo para registrar una tienda
        {
            // Validacion de campos requeridos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(telefono))
                return "Todos los campos son requeridos."; // Verifica que los campos nombre, direccion y telefono no esten vacios

            // Validar que el Id sea unico
            for (int i = 0; i < indice; i++)
            {
                if (tiendas[i].Id == id)
                    return "El ID ya existe."; // Verifica que el ID no exista en el arreglo
            }

            // Validar espacio en el arreglo
            if (indice >= tiendas.Length)
                return "No se pueden agregar mas tiendas."; // Verifica que haya espacio en el arreglo

            // Registrar la tienda
            tiendas[indice] = new TiendaEntidad
            {
                Id = id,
                Nombre = nombre,
                Direccion = direccion,
                Telefono = telefono,
                Activa = activa,
                Id_Administrador = administradorId
            };
            indice++; // Incrementa el indice

            return "Tienda registrada correctamente."; // Retorna un mensaje de exito
        }

        public List<TiendaEntidad> ObtenerTiendasDesdeBD() // Metodo para obtener todas las tiendas desde la base de datos
        {
            DatosTienda datos = new DatosTienda(); // Crea una instancia de DatosTienda
            return datos.ObtenerTiendas(); // Llama al metodo ObtenerTiendas de DatosTienda y retorna la lista de tiendas
        }

        public string EliminarTienda(int id) // Metodo para eliminar una tienda
        {
            try
            {
                DatosTienda datos = new DatosTienda(); // Crea una instancia de DatosTienda
                bool resultado = datos.Eliminar(id); // Llama al metodo Eliminar de DatosTienda y almacena el resultado
                return resultado ? "Tienda eliminada correctamente." : "No se pudo eliminar la tienda."; // Retorna un mensaje segun el resultado
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return ex.Message; // Retorna el mensaje de la excepcion
            }
        }

        public string EditarTienda(TiendaEntidad tienda) // Metodo para editar una tienda
        {
            try
            {
                DatosTienda datos = new DatosTienda(); // Crea una instancia de DatosTienda
                bool resultado = datos.Actualizar(tienda); // Llama al metodo Actualizar de DatosTienda y almacena el resultado
                return resultado ? "Tienda actualizada correctamente." : "No se pudo actualizar la tienda."; // Retorna un mensaje segun el resultado
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return ex.Message; // Retorna el mensaje de la excepcion
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
