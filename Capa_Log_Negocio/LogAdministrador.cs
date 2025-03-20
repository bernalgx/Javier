//TODO NUEVO///////////////////


//using Capa_Entidades;
//namespace Capa_Log_Negocio
//{
//    public class LogAdministrador
//    {
//        private AdministradorEntidad[] administradores = new AdministradorEntidad[20]; // Arreglo con 20 espacios
//        private int indice = 0;

//       public string RegistroAdministrador(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, DateTime fechaContratacion)
//       {
//            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(primerApellido) || string.IsNullOrWhiteSpace(segundoApellido))
//                return "Todos los campos son requeridos.";

//           if (DateTime.Today.Year - fechaNacimiento.Year < 18)
//                return "El administrador debe ser mayor de edad.";

//            if (fechaContratacion > DateTime.Today)
//                return "La fecha de contratación no puede ser futura.";

//            for (int i = 0; i < indice; i++)
//            {
//                if (administradores[i].Identificacion == identificacion)
//                   return "El ID ya existe.";
//            }

//            if (indice >= administradores.Length)
//                return "No se pueden agregar más administradores.";

//            administradores[indice] = new AdministradorEntidad
//            {
//                Identificacion = identificacion,
//                Nombre = nombre,
//                PrimerApellido = primerApellido,
//                SegundoApellido = segundoApellido,
//                FechaNacimiento = fechaNacimiento,
//                FechaContratacion = fechaContratacion
//            };
//            indice++;

//            return "Administrador registrado correctamente.";
//        }

//        public AdministradorEntidad[] ObtenerAdministradores()
//        {
//            return administradores.Take(indice).ToArray();
//        }
//    }
//}