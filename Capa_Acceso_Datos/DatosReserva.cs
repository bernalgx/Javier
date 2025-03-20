//TODO NUEVO//////////////

//using System;
//using Microsoft.Data.SqlClient;
//using Capa_Acceso_Datos;

//namespace Capa_Acceso_Datos
//{
//    public class DatosReserva
//    {
//        private readonly ConexionBD _conexion;

//        public DatosReserva()
//       {
//            _conexion = new ConexionBD();
//        }

//        public string Crear(ReservaEntidad reserva)
//        {
//            try
//            {
//                using (var conn = _conexion.ObtenerConexion())
//                {
//                    conn.Open();

//                    string sql = @"
//                    INSERT INTO Reserva 
//                    (Id, ClienteId, VideojuegoId, TiendaId, FechaReserva, FechaRetiro)
//                    VALUES 
//                    (@Id, @ClienteId, @VideojuegoId, @TiendaId, @FechaReserva, @FechaRetiro)";

//                    using (var cmd = new SqlCommand(sql, conn))
//                    {
//                        cmd.Parameters.AddWithValue("@Id", reserva.Id);
//                        cmd.Parameters.AddWithValue("@ClienteId", reserva.Cliente.Identificacion);
//                        cmd.Parameters.AddWithValue("@VideojuegoId", reserva.Videojuego.Id);
//                        cmd.Parameters.AddWithValue("@TiendaId", reserva.Tienda.Id);
//                        cmd.Parameters.AddWithValue("@FechaReserva", reserva.FechaReserva);
//                        cmd.Parameters.AddWithValue("@FechaRetiro", reserva.FechaRetiro);

//                        cmd.ExecuteNonQuery();
//                    }
//               }
//                return "Reserva registrada correctamente.";
//            }
//            catch (Exception ex)
//            {
//                return "Error al insertar reserva: " + ex.Message;
//            }
//        }
//    }
//}
