//TODO NUEVO/////////////////

//using Capa_Entidades;


//namespace Capa_Log_Negocio
//{
//    public class LogCliente
//    {
//        private ClienteEntidad[] clientes = new ClienteEntidad[20]; // Arreglo con 20 espacios
//        private int indice = 0;

//        public string RegistroCliente(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, bool jugadorEnLinea)
//        {
//            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(primerApellido) || string.IsNullOrWhiteSpace(segundoApellido))
//                return "Todos los campos son requeridos.";

//            if (DateTime.Today.Year - fechaNacimiento.Year < 10)
//                return "El cliente debe tener al menos 10 años.";

//            for (int i = 0; i < indice; i++)
//            {
//                if (clientes[i].Identificacion == identificacion)
//                    return "El ID ya existe.";
//            }

//            if (indice >= clientes.Length)
//                return "No se pueden agregar más clientes.";

//            clientes[indice] = new ClienteEntidad
//            {
//                Identificacion = identificacion,
//                Nombre = nombre,
//                PrimerApellido = primerApellido,
//                SegundoApellido = segundoApellido,
//                FechaNacimiento = fechaNacimiento,
//                JugadorEnLinea = jugadorEnLinea
//            };
//            indice++;

//            return "Cliente registrado correctamente.";
//        }

//        public ClienteEntidad[] ObtenerClientes()
//        {
//            return clientes.Take(indice).ToArray();
//        }
//    }
//}
