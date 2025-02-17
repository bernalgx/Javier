//using System; // Importa el espacio de nombres System
//using Capa_Acceso_Datos; // Importa la capa de acceso a datos
//using Capa_Entidades; // Importa la capa de entidades

//namespace Capa_Log_Negocio // Define el espacio de nombres para la logica de negocio
//{
//    // Clase para manejar la logica de negocio relacionada con los videojuegos
//    public class LogicaVideojuego
//    {
//        private DatosVideojuego datos = new DatosVideojuego(); // Instancia de la capa de acceso a datos

//        // Metodo para registrar un videojuego en el sistema
//        public string RegistrarVideojuego(string nombre, TipoVideojuegoEntidad tipo, string desarrollador, int lanzamiento, bool fisico)
//        {
//            // Validacion de datos obligatorios
//            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(desarrollador))
//            {
//                return "Todos los campos son obligatorios."; // Retorna mensaje de error si hay campos vacios
//            }

//            // Validacion del año de lanzamiento (no puede ser mayor al actual)
//            if (lanzamiento > DateTime.Today.Year)
//            {
//                return "El año de lanzamiento no puede ser mayor al actual."; // Retorna mensaje de error si el año es invalido
//            }

//            // Validacion del tipo de videojuego (debe ser proporcionado)
//            if (tipo == null)
//            {
//                return "Debe seleccionar un tipo de videojuego."; // Retorna mensaje de error si no hay tipo de videojuego
//            }

//            // Creacion del objeto VideojuegoEntidad
//            var videojuego = new VideojuegoEntidad
//            {
//                Nombre = nombre, // Asigna el nombre del videojuego
//                TipoVideojuego = tipo, // Asigna el tipo de videojuego
//                Desarrollador = desarrollador, // Asigna el desarrollador
//                Lanzamiento = lanzamiento, // Asigna el año de lanzamiento
//                Fisico = fisico // Asigna si es fisico o no
//            };

//            // Llamada a la capa de acceso a datos
//            bool resultado = datos.AgregarVideojuego(videojuego); // Intenta agregar el videojuego

//            return resultado ? "Videojuego registrado correctamente." : "Error al registrar videojuego."; // Retorna mensaje de exito o error
//        }
//    }
//}
