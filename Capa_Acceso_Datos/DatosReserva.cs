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

	// Consulta todas las reservas de un cliente
	public List<ReservaEntidad> ConsultarReservasPorCliente(int clienteId)
	{
		List<ReservaEntidad> reservas = new List<ReservaEntidad>();

		using (var conn = _conexion.ObtenerConexion())
		{
			conn.Open();
			string sql = @"
            SELECT 
                r.Id AS IdReserva, 
                t.Nombre AS Tienda, 
                v.Nombre AS Videojuego, 
                r.FechaReserva, 
                r.Cantidad 
            FROM Reserva r 
            INNER JOIN Tienda t ON r.Id_Tienda = t.Id 
            INNER JOIN Videojuego v ON r.Id_Videojuego = v.Id 
            WHERE r.Id_Cliente = @clienteId";

			using (var cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@clienteId", clienteId);
				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						var reserva = new ReservaEntidad(
							Convert.ToInt32(reader["IdReserva"]), // Convertir de decimal a int
							new VideojuegosXTiendaEntidad(
								new TiendaEntidad { Nombre = reader.GetString(reader.GetOrdinal("Tienda")) },
								new VideojuegoEntidad { Nombre = reader.GetString(reader.GetOrdinal("Videojuego")) },
								0 // Existencias no se usa aquí
							),
							null, // ClienteEntidad no es necesario aquí
							reader.GetDateTime(reader.GetOrdinal("FechaReserva")),
							Convert.ToInt32(reader["Cantidad"]) // Convertir de decimal a int
						);
						reservas.Add(reserva);
					}
				}
			}
		}
		return reservas;
	}




	// Consulta una reserva específica del cliente por ID
	public List<ReservaEntidad> ConsultarReservaPorId(int clienteId, int idReserva)
	{
		List<ReservaEntidad> reservas = new List<ReservaEntidad>();

		using (var conn = _conexion.ObtenerConexion())
		{
			conn.Open();
			string sql = @"
            SELECT 
                r.Id AS IdReserva, 
                t.Nombre AS Tienda, 
                v.Nombre AS Videojuego, 
                r.FechaReserva, 
                r.Cantidad
            FROM Reserva r
            INNER JOIN Tienda t ON r.Id_Tienda = t.Id
            INNER JOIN Videojuego v ON r.Id_Videojuego = v.Id
            WHERE r.Id_Cliente = @clienteId AND r.Id = @idReserva";

			using (var cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@clienteId", clienteId);
				cmd.Parameters.AddWithValue("@idReserva", idReserva);
				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						var reserva = new ReservaEntidad(
							Convert.ToInt32(reader["IdReserva"]), // Conversión de decimal a int
							new VideojuegosXTiendaEntidad(
								new TiendaEntidad { Nombre = reader.GetString(reader.GetOrdinal("Tienda")) },
								new VideojuegoEntidad { Nombre = reader.GetString(reader.GetOrdinal("Videojuego")) },
								0 // Existencias no es relevante para el display
							),
							null, // ClienteEntidad no es necesario en este contexto
							reader.GetDateTime(reader.GetOrdinal("FechaReserva")),
							Convert.ToInt32(reader["Cantidad"]) // Conversión de decimal a int
						);
						reservas.Add(reserva);
					}
				}
			}
		}
		return reservas;
	}


}
