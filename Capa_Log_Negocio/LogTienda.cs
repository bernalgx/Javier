//using System; // Importa el espacio de nombres System
//using Capa_Acceso_Datos; // Importa la capa de acceso a datos
//using Capa_Entidades; // Importa la capa de entidades

//namespace Capa_Log_Negocio // Define el espacio de nombres para la logica de negocio
//{
//    // Clase para manejar la logica de negocio relacionada con las tiendas
//    public class LogicaTienda
//    {
//        private DatosTienda datos = new DatosTienda(); // Instancia de la capa de acceso a datos

//        // Metodo para registrar una tienda en el sistema
//        public string RegistrarTienda(int id, string nombre, AdministradorEntidad administrador, string direccion, string telefono, bool activa)
//        {
//            // Validacion de datos obligatorios
//            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(telefono))
//            {
//                return "Todos los campos son obligatorios."; // Retorna mensaje de error si hay campos vacios
//            }

//            // Validacion del administrador (debe ser proporcionado)
//            if (administrador == null)
//            {
//                return "Debe seleccionar un administrador para la tienda."; // Retorna mensaje de error si no hay administrador
//            }

//            // Creacion del objeto TiendaEntidad
//            var tienda = new TiendaEntidad
//            {
//                Id = id, // Asigna el ID de la tienda
//                Nombre = nombre, // Asigna el nombre de la tienda
//                Administrador = administrador, // Asigna el administrador
//                Direccion = direccion, // Asigna la direccion
//                Telefono = telefono, // Asigna el telefono
//                Activa = activa // Asigna el estado de la tienda (activa o no)
//            };

//            // Llamada a la capa de acceso a datos
//            bool resultado = datos.AgregarTienda(tienda); // Intenta agregar la tienda

//            return resultado ? "Tienda registrada correctamente." : "Error al registrar tienda."; // Retorna mensaje de exito o error
//        }
//    }
//}
