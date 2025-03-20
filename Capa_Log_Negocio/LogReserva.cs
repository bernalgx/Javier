//TODO NUEVO /////////////////


//using Capa_Entidades;

//namespace Capa_Log_Negocio
//{
//    public class LogReserva
//    {
//        private ReservaEntidad[] reservas = new ReservaEntidad[50]; // Arreglo con 50 espacios para reservas
//        private int indice = 0;

//        public string RegistroReserva(int id, ClienteEntidad cliente, VideojuegoEntidad videojuego, TiendaEntidad tienda, DateTime fechaReserva, DateTime fechaRetiro)
//        {
//            if (cliente == null || videojuego == null || tienda == null)
//                return "Debe seleccionar un cliente, un videojuego y una tienda.";

//            if (fechaReserva > fechaRetiro)
//                return "La fecha de reserva no puede ser posterior a la fecha de retiro.";

//            for (int i = 0; i < indice; i++)
//            {
//                if (reservas[i].Id == id)
//                    return "El ID de reserva ya existe.";
//            }

//            if (indice >= reservas.Length)
//                return "No se pueden agregar más reservas.";

//           reservas[indice] = new ReservaEntidad
//           {
//                Id = id,
//                Cliente = cliente,
//                Videojuego = videojuego,
//                Tienda = tienda,
//                FechaReserva = fechaReserva,
//                FechaRetiro = fechaRetiro
//            };
//            indice++;

//            return "Reserva registrada correctamente.";
//        }

//        public ReservaEntidad[] ObtenerReservas()
//        {
//            return reservas.Take(indice).ToArray();
//        }
//    }
//}
