//using System; // Importa el espacio de nombres System
//using Capa_Acceso_Datos; // Importa la capa de acceso a datos
//using Capa_Entidades; // Importa la capa de entidades

//namespace Capa_Log_Negocio // Define el espacio de nombres para la logica de negocio
//{
    // Clase para manejar la logica de negocio relacionada con las tiendas
//    public class LogTienda
//    {
//        private DatosTienda datos = new DatosTienda();

        // Metodo para registrar una tienda en el sistema
//        public string RegistroTienda(int id, string nombre, AdministradorEntidad administrador, string direccion, string telefono, bool activa)
//        {
            // Validacion de datos obligatorios
//            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(telefono))
//            {
//                return "Todos los campos son obligatorios.";
//            }

            // Validacion del administrador (debe ser proporcionado)
//            if (administrador == null)
//            {
//                return "Debe seleccionar un administrador para la tienda.";
//            }

            // Creacion del objeto TiendaEntidad
 //           var tienda = new TiendaEntidad
 //           {
 //               Id = id,
 //               Nombre = nombre,
 //               Administrador = administrador,
 //               Direccion = direccion,
 //               Telefono = telefono,
 //               Activa = activa
 //           };

            // Llamada a la capa de acceso a datos
 //           bool resultado = datos.AgregarTienda(tienda);

 //           return resultado ? "Tienda registrada correctamente." : "Error al registrar tienda.";
 //       }
//    }
//}
