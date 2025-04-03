using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient; // O System.Data.SqlClient
using Capa_Entidades;

namespace Capa_Acceso_Datos
{
	public class DatosVideojuego
	{
		private readonly ConexionBD _conexion;

		// Recibimos la instancia de la conexión en el constructor
		public DatosVideojuego()
		{
			_conexion = new ConexionBD();
		}

		public List<VideojuegosXTiendaEntidad> ObtenerVideojuegosPorTienda(int tiendaId)
		{
			List<VideojuegosXTiendaEntidad> lista = new List<VideojuegosXTiendaEntidad>();

			try
			{
				using (var conn = _conexion.ObtenerConexion())
				{
					conn.Open();
					// Consulta que une la tabla VideojuegosXTienda con Videojuego y Tienda para obtener toda la información necesaria.
					string sql = "SELECT vt.Existencias, v.Id, v.Nombre, v.Desarrollador, v.Lanzamiento, v.Fisico, v.Id_TipoVideojuego, t.Id, t.Nombre, t.Direccion, t.Telefono, t.Activa, t.Id_Administrador FROM VideojuegosXTienda vt INNER JOIN Videojuego v ON vt.Id_VideoJuego = v.Id INNER JOIN Tienda t ON vt.Id_Tienda = t.Id WHERE t.Id = @Id_Tienda";


					using (var cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@Id_Tienda", tiendaId);

						using (var dr = cmd.ExecuteReader())
						{
							while (dr.Read())
							{
								// Leer la cantidad de existencias
								decimal existencias = dr.GetDecimal(0);

								// Crear el objeto VideojuegoEntidad con la información obtenida
								VideojuegoEntidad videojuego = new VideojuegoEntidad
								{
									Id = Convert.ToInt32(dr.GetDecimal(1)),
									Nombre = dr.GetString(2),
									Desarrollador = dr.GetString(3),
									Lanzamiento = Convert.ToInt32(dr.GetDecimal(4)), // Suponiendo que "Lanzamiento" también es numeric
									Fisico = dr.GetBoolean(5),
									Id_TipoVideojuego = Convert.ToInt32(dr.GetDecimal(6)) // Si es numeric, de lo contrario, si es int, usa GetInt32
								};


								// Crear el objeto TiendaEntidad con la información obtenida
								TiendaEntidad tienda = new TiendaEntidad
								{
									Id = Convert.ToInt32(dr.GetDecimal(7)),
									Nombre = dr.GetString(8),
									Direccion = dr.GetString(9),
									Telefono = dr.GetString(10),
									Activa = dr.GetBoolean(11),
									Id_Administrador = Convert.ToInt32(dr.GetDecimal(12))
								};


								// Crear la entidad VideojuegosXTiendaEntidad y agregarla a la lista
								VideojuegosXTiendaEntidad entidad = new VideojuegosXTiendaEntidad(tienda, videojuego, existencias);
								lista.Add(entidad);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al obtener videojuegos por tienda: " + ex.Message);
			}

			return lista;
		}


		public string Crear(VideojuegoEntidad videojuego)
		{
			try
			{
				using (var conn = _conexion.ObtenerConexion())
				{
					conn.Open();
					// Quita la columna Id del INSERT para que el valor se asigne automáticamente

					string sql = @"
					INSERT INTO Videojuego 
					(Nombre, Desarrollador, Lanzamiento, Fisico, Id_TipoVideojuego)
					VALUES 
					(@Nombre, @Desarrollador, @Lanzamiento, @Fisico, @Id_TipoVideojuego)";

					using (var cmd = new SqlCommand(sql, conn))
					{

						cmd.Parameters.AddWithValue("@Nombre", videojuego.Nombre);
						cmd.Parameters.AddWithValue("@Desarrollador", videojuego.Desarrollador);
						cmd.Parameters.AddWithValue("@Lanzamiento", videojuego.Lanzamiento);
						cmd.Parameters.AddWithValue("@Fisico", videojuego.Fisico);
						cmd.Parameters.AddWithValue("@Id_TipoVideojuego", videojuego.Id_TipoVideojuego);

						cmd.ExecuteNonQuery();
					}

				}
				return "Videojuego insertado correctamente.";
			}
			catch (Exception ex)
			{
				return "Error al insertar videojuego: " + ex.Message;
			}
		}
		// Fixing the conversion issue by explicitly casting decimal to int
		public List<VideojuegoEntidad> ObtenerVideojuegos()
		{
			List<VideojuegoEntidad> lista = new List<VideojuegoEntidad>();

			try
			{
				using (var conn = _conexion.ObtenerConexion())
				{
					conn.Open();
					string sql = @"SELECT   Id, 
                    Nombre, 
                    Desarrollador, 
                    Lanzamiento, 
                    Fisico, 
                    Id_TipoVideojuego 
                    FROM Videojuego";

					using (var cmd = new SqlCommand(sql, conn))
					{
						using (var dr = cmd.ExecuteReader())
						{
							while (dr.Read())
							{
								VideojuegoEntidad videojuego = new VideojuegoEntidad
								{
									Id = (int)dr.GetDecimal(0),
									Nombre = dr.GetString(1),
									Desarrollador = dr.GetString(2),
									Lanzamiento = (int)dr.GetDecimal(3),
									Fisico = dr.GetBoolean(4),
									Id_TipoVideojuego = (int)dr.GetDecimal(5)
								};

								lista.Add(videojuego);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				// Puedes registrar el error o manejarlo de otra forma
				throw new Exception("Error al obtener videojuegos: " + ex.Message);
			}

			return lista;
		}


		public bool Eliminar(int id)
		{
			try
			{
				using (var conn = _conexion.ObtenerConexion())
				{
					conn.Open();
					string sql = "DELETE FROM Videojuego WHERE Id=@Id";

					using (var cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@Id", id);
						int rowsAffected = cmd.ExecuteNonQuery();
						return rowsAffected > 0;
					}
				}
			}
			catch (Exception ex)
			{
				// Manejar la excepción según corresponda
				throw new Exception("Error al eliminar videojuego: " + ex.Message);
			}
		}

		public bool Actualizar(VideojuegoEntidad videojuego)
		{
			try
			{
				using (var conn = _conexion.ObtenerConexion())
				{
					conn.Open();
					string sql = @" 
                    UPDATE Videojuego 
                    SET Nombre=@Nombre, Desarrollador=@Desarrollador, 
                    Lanzamiento=@Lanzamiento, Fisico=@Fisico, Id_TipoVideojuego=@Id_TipoVideojuego
                    WHERE Id=@Id";

					using (var cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@Id", videojuego.Id);
						cmd.Parameters.AddWithValue("@Nombre", videojuego.Nombre);
						cmd.Parameters.AddWithValue("@Desarrollador", videojuego.Desarrollador);
						cmd.Parameters.AddWithValue("@Lanzamiento", videojuego.Lanzamiento);
						cmd.Parameters.AddWithValue("@Fisico", videojuego.Fisico);
						cmd.Parameters.AddWithValue("@Id_TipoVideojuego", videojuego.Id_TipoVideojuego);

						int rowsAffected = cmd.ExecuteNonQuery();
						return rowsAffected > 0;
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al actualizar videojuego: " + ex.Message);
			}
		}
	}
}

