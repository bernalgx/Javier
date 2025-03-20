//TODO NUEVO////////

//using Capa_Entidades;


//namespace Capa_Log_Negocio
//{
//    public class LogInventario
//    {
//        private VideojuegosXTiendaEntidad[] inventario = new VideojuegosXTiendaEntidad[100]; // Arreglo con 100 espacios
//        private int indice = 0;

//        public string RegistroInventario(TiendaEntidad tienda, VideojuegoEntidad videojuego, int existencias)
//        {
//            if (tienda == null || videojuego == null)
//                return "Debe seleccionar una tienda y un videojuego.";

//            if (existencias <= 0)
//                return "Las existencias deben ser mayores a 0.";

//            if (indice >= inventario.Length)
//                return "No se pueden agregar más registros.";

//            inventario[indice] = new VideojuegosXTiendaEntidad
//            {
//                Tienda = tienda,
//                Videojuego = videojuego,
//                Existencias = existencias
//            };
//            indice++;

//            return "Inventario registrado correctamente.";
//        }

//        public VideojuegosXTiendaEntidad[] ObtenerInventario()
//        {
//            return inventario.Take(indice).ToArray();
//        }
//    }
//}
