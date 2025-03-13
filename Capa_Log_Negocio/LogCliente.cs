//using System; // Importa el espacio de nombres System
//using Capa_Acceso_Datos; // Importa la capa de acceso a datos
//using Capa_Entidades; // Importa la capa de entidades
//using Interfaz;
//using Capa_Logica_Negocio;

//namespace Capa_Log_Negocio // Define el espacio de nombres para la logica de negocio
//{
// Clase para manejar la logica de negocio relacionada con los clientes
//    public class LogCliente
//    {
//        private DatosCliente datos = new DatosCliente();

// Metodo para registrar un cliente en el sistema
//        public string RegistroCliente(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, bool jugadorEnLinea)
//        {
// Validacion de datos obligatorios
//            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(primerApellido) || string.IsNullOrWhiteSpace(segundoApellido))
//            {
//                return "Todos los campos son obligatorios.";
//            }

// Validacion de edad (debe ser mayor de 10 años para registrarse)
//            int edad = DateTime.Today.Year - fechaNacimiento.Year;
//            if (edad < 10)
//            {
//                return "El cliente debe minimo 10 años.";
//            }

// Creacion del objeto ClienteEntidad
//            var cliente = new ClienteEntidad
//           {
//                Identificacion = identificacion,
//                Nombre = nombre,
//                PrimerApellido = primerApellido,
//                SegundoApellido = segundoApellido,
//                FechaNacimiento = fechaNacimiento,
//                JugadorEnLinea = jugadorEnLinea
//            };

// Llamada a la capa de acceso a datos
//            bool resultado = datos.AgregarCliente(cliente);

//            return resultado ? "Cliente registrado correctamente." : "Error al registrar cliente.";
//        }
//    }
//}
