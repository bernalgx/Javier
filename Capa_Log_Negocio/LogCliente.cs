//using System; // Importa el espacio de nombres System
//using Capa_Acceso_Datos; // Importa la capa de acceso a datos
//using Capa_Entidades; // Importa la capa de entidades

//namespace Capa_Log_Negocio // Define el espacio de nombres para la logica de negocio
//{
//    // Clase para manejar la logica de negocio relacionada con los clientes
//    public class LogicaCliente
//    {
//        private DatosCliente datos = new DatosCliente(); // Instancia de la capa de acceso a datos

//        // Metodo para registrar un cliente en el sistema
//        public string RegistrarCliente(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, bool jugadorEnLinea)
//        {
//            // Validacion de datos obligatorios
//            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(primerApellido) || string.IsNullOrWhiteSpace(segundoApellido))
//            {
//                return "Todos los campos son obligatorios."; // Retorna mensaje de error si hay campos vacios
//            }

//            // Validacion de edad (debe ser mayor de 10 años para registrarse)
//            if ((DateTime.Today.Year - fechaNacimiento.Year) < 10)
//            {
//                return "El cliente debe tener al menos 10 años."; // Retorna mensaje de error si es menor de 10 años
//            }

//            // Creacion del objeto ClienteEntidad
//            var cliente = new ClienteEntidad
//            {
//                Identificacion = identificacion, // Asigna identificacion
//                Nombre = nombre, // Asigna nombre
//                PrimerApellido = primerApellido, // Asigna primer apellido
//                SegundoApellido = segundoApellido, // Asigna segundo apellido
//                FechaNacimiento = fechaNacimiento, // Asigna fecha de nacimiento
//                JugadorEnLinea = jugadorEnLinea // Asigna si es jugador en linea
//            };

//            // Llamada a la capa de acceso a datos
//            bool resultado = datos.AgregarCliente(cliente); // Intenta agregar el cliente

//            return resultado ? "Cliente registrado correctamente." : "Error al registrar cliente."; // Retorna mensaje de exito o error
//        }
//    }
//}
