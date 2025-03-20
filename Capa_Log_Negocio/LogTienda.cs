//TODO NUEVO/////////////

//using Capa_Entidades;


//namespace Capa_Log_Negocio
//{
//    public class LogTienda
//    {
//        private TiendaEntidad[] tiendas = new TiendaEntidad[5]; // Arreglo con 5 espacios
//        private int indice = 0;

//        public string RegistroTienda(int id, string nombre, AdministradorEntidad administrador, string direccion, string telefono, bool activa)
//        {
//            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(telefono))
//                return "Todos los campos son requeridos.";

//            if (administrador == null)
//                return "Debe seleccionar un administrador.";

//            for (int i = 0; i < indice; i++)
//            {
//                if (tiendas[i].Id == id)
//                    return "El ID ya existe.";
//            }

//            if (indice >= tiendas.Length)
//                return "No se pueden agregar más tiendas.";

//            tiendas[indice] = new TiendaEntidad
//            {
//                Id = id,
//                Nombre = nombre,
//                Administrador = administrador,
//                Direccion = direccion,
//                Telefono = telefono,
//                Activa = activa
//            };
//            indice++;

//            return "Tienda registrada correctamente.";
//        }

//        public TiendaEntidad[] ObtenerTiendas()
//        {
//            return tiendas.Take(indice).ToArray();
//        }
//    }
//}
