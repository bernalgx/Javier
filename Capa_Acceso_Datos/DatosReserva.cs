////TODO NUEVO//////////////

using Capa_Acceso_Datos;
using Capa_Entidades;
using Microsoft.Data.SqlClient;

public class DatosReserva
{
	private readonly ConexionBD _conexion;

	public DatosReserva()
	{
		_conexion = new ConexionBD();
	}

	public string CrearReserva(ReservaEntidad reserva)
	{
		// Validar que ninguno de los objetos críticos sea nulo
		if (reserva == null)
			throw new ArgumentNullException(nameof(reserva));
		if (reserva.Cliente == null)
			throw new Exception("El cliente en la reserva es nulo.");
		if (reserva.VideojuegoTienda == null)
			throw new Exception("El objeto VideojuegoTienda en la reserva es nulo.");
		if (reserva.VideojuegoTienda.Videojuego == null)
			throw new Exception("El videojuego en la reserva es nulo.");
		if (reserva.VideojuegoTienda.Tienda == null)
			throw new Exception("La tienda en la reserva es nula.");

		using (var conn = _conexion.ObtenerConexion())
		{
			conn.Open();
			using (var transaction = conn.BeginTransaction())
			{
				try
				{
					// 1. Insertar reserva usando los nombres de columna correctos según el esquema
					string sqlReserva = @"
        INSERT INTO Reserva (Id_Cliente, Id_Videojuego, Id_Tienda, FechaReserva, Cantidad)
        VALUES (@ClienteId, @VideojuegoId, @TiendaId, @Fecha, @Cantidad)";

					using (var cmd = new SqlCommand(sqlReserva, conn, transaction))
					{
						cmd.Parameters.AddWithValue("@ClienteId", reserva.Cliente.Identificacion);
						cmd.Parameters.AddWithValue("@VideojuegoId", reserva.VideojuegoTienda.Videojuego.Id);
						cmd.Parameters.AddWithValue("@TiendaId", reserva.VideojuegoTienda.Tienda.Id);
						cmd.Parameters.AddWithValue("@Fecha", reserva.FechaReserva);
						cmd.Parameters.AddWithValue("@Cantidad", reserva.Cantidad);
						cmd.ExecuteNonQuery();
					}

					// 2. Actualizar existencias en la tabla VideojuegosXTienda
					string sqlInventario = @"
        UPDATE VideojuegosXTienda 
        SET Existencias = Existencias - @Cantidad 
        WHERE Id_Tienda = @TiendaId AND Id_Videojuego = @VideojuegoId";

					using (var cmd = new SqlCommand(sqlInventario, conn, transaction))
					{
						cmd.Parameters.AddWithValue("@Cantidad", reserva.Cantidad);
						cmd.Parameters.AddWithValue("@TiendaId", reserva.VideojuegoTienda.Tienda.Id);
						cmd.Parameters.AddWithValue("@VideojuegoId", reserva.VideojuegoTienda.Videojuego.Id);
						cmd.ExecuteNonQuery();
					}

					transaction.Commit();
					return "Reserva realizada exitosamente";
				}
				catch (Exception ex)
				{
					transaction.Rollback();
					return "Error al procesar reserva: " + ex.Message;
				}


			}
		}
	}

}


////using System;
////using Microsoft.Data.SqlClient;
////using Capa_Acceso_Datos;

////namespace Capa_Acceso_Datos
////{
////    public class DatosReserva
////    {
////        private readonly ConexionBD _conexion;

////        public DatosReserva()
////       {
////            _conexion = new ConexionBD();
////        }

////        public string Crear(ReservaEntidad reserva)
////        {
////            try
////            {
////                using (var conn = _conexion.ObtenerConexion())
////                {
////                    conn.Open();

////                    string sql = @"
////                    INSERT INTO Reserva 
////                    (Id, ClienteId, VideojuegoId, TiendaId, FechaReserva, FechaRetiro)
////                    VALUES 
////                    (@Id, @ClienteId, @VideojuegoId, @TiendaId, @FechaReserva, @FechaRetiro)";

////                    using (var cmd = new SqlCommand(sql, conn))
////                    {
////                        cmd.Parameters.AddWithValue("@Id", reserva.Id);
////                        cmd.Parameters.AddWithValue("@ClienteId", reserva.Cliente.Identificacion);
////                        cmd.Parameters.AddWithValue("@VideojuegoId", reserva.Videojuego.Id);
////                        cmd.Parameters.AddWithValue("@TiendaId", reserva.Tienda.Id);
////                        cmd.Parameters.AddWithValue("@FechaReserva", reserva.FechaReserva);
////                        cmd.Parameters.AddWithValue("@FechaRetiro", reserva.FechaRetiro);

////                        cmd.ExecuteNonQuery();
////                    }
////               }
////                return "Reserva registrada correctamente.";
////            }
////            catch (Exception ex)
////            {
////                return "Error al insertar reserva: " + ex.Message;
////            }
////        }
////    }
////}
