//using System; // Importa el espacio de nombres System
//using Capa_Acceso_Datos; // Importa la capa de acceso a datos
//using Capa_Entidades; // Importa la capa de entidades
//using System.Collections.Generic; // Importa el espacio de nombres para listas

//namespace Capa_Log_Negocio // Define el espacio de nombres para la logica de negocio
//{
//    // Clase para manejar la logica de negocio relacionada con los administradores
//    public class LogicaAdministrador
//    {
//        private DatosAdministrador datos = new DatosAdministrador(); // Instancia de la capa de acceso a datos

//        // Metodo para registrar un administrador en el sistema
//        public string RegistrarAdministrador(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, DateTime fechaContratacion)
//        {
//            // Validacion de datos obligatorios
//            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(primerApellido) || string.IsNullOrWhiteSpace(segundoApellido))
//            {
//                return "Todos los campos son obligatorios."; // Retorna mensaje de error si hay campos vacios
//            }

//            // Validacion de edad (debe ser mayor de 18 años)
//            if ((DateTime.Today.Year - fechaNacimiento.Year) < 18)
//            {
//                return "El administrador debe ser mayor de edad."; // Retorna mensaje de error si es menor de edad
//            }

//            // Validacion de fecha de contratacion (no puede ser futura)
//            if (fechaContratacion > DateTime.Today)
//            {
//                return "La fecha de contratacion no puede ser mayor a la fecha actual."; // Retorna mensaje de error si la fecha es futura
//            }

//            // Creacion del objeto AdministradorEntidad
//            var administrador = new AdministradorEntidad
//            {
//                Identificacion = identificacion, // Asigna identificacion
//                Nombre = nombre, // Asigna nombre
//                PrimerApellido = primerApellido, // Asigna primer apellido
//                SegundoApellido = segundoApellido, // Asigna segundo apellido
//                FechaNacimiento = fechaNacimiento, // Asigna fecha de nacimiento
//                FechaContratacion = fechaContratacion // Asigna fecha de contratacion
//            };

//            // Llamada a la capa de acceso a datos
//            bool resultado = datos.AgregarAdministrador(administrador); // Intenta agregar el administrador

//            return resultado ? "Administrador registrado correctamente." : "Error al registrar administrador."; // Retorna mensaje de exito o error
//        }
//    }
//}
