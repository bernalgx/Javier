//using System; // Importa el espacio de nombres System
//using Capa_Acceso_Datos; // Importa la capa de acceso a datos
//using Capa_Entidades; // Importa la capa de entidades

//namespace Capa_Log_Negocio // Define el espacio de nombres para la logica de negocio
//{
    // Clase para manejar la logica de negocio relacionada con los videojuegos
//    public class LogicaVideojuego
//    {
//        private DatosVideojuego datos = new DatosVideojuego();

        // Metodo para registrar un videojuego en el sistema
//        public string RegistrarVideojuego(string nombre, TipoVideojuegoEntidad tipo, string desarrollador, int lanzamiento, bool fisico)
//       {
            // Validacion de datos obligatorios
 //           if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(desarrollador))
//            {
//                return "Todos los campos son obligatorios.";
//            }

            // Validacion del año de lanzamiento (no puede ser mayor al actual)
//            if (lanzamiento > DateTime.Today.Year)
//            {
//                return "El año de lanzamiento no puede ser mayor al actual.";
//            }

            // Validacion del tipo de videojuego (debe ser proporcionado)
//            if (tipo == null)
//            {
//                return "Debe seleccionar un tipo de videojuego.";
//            }

            // Creacion del objeto VideojuegoEntidad
 //           var videojuego = new VideojuegoEntidad
 //           {
 //               Nombre = nombre,
 //               TipoVideojuego = tipo,
//                Desarrollador = desarrollador,
 //               Lanzamiento = lanzamiento,
 //               Fisico = fisico
 //           };

            // Llamada a la capa de acceso a datos
 //           bool resultado = datos.AgregarVideojuego(videojuego);

 //           return resultado ? "Videojuego registrado correctamente." : "Error al registrar videojuego.";
//        }
//    }
//}
