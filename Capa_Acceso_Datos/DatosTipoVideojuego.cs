using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient; // O System.Data.SqlClient, según tu proyecto
using Capa_Entidades;

namespace Capa_Acceso_Datos
{
	public class DatosTipoVideojuego
	{
		private ConexionBD _conexion = new ConexionBD();

		public List<TipoVideojuegoEntidad> ObtenerTodos()
		{
			var lista = new List<TipoVideojuegoEntidad>();
			using (var conn = _conexion.ObtenerConexion())
			{
				conn.Open();
				string sql = "SELECT Id, Nombre, Descripcion FROM TipoVideojuego";

				using (var cmd = new SqlCommand(sql, conn))
				{
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							lista.Add(new TipoVideojuegoEntidad
							{
								Id = reader.GetInt32(reader.GetOrdinal("Id")),
								Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
								Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"))
							});
						}
					}
				}
			}
			return lista;
		}

		public string Crear(TipoVideojuegoEntidad tipo)
		{
			try
			{
				using (var conn = _conexion.ObtenerConexion())
				{
					conn.Open();

					// NO incluimos la columna Id porque es autoincremental
					string sql = @"INSERT INTO TipoVideojuego (Nombre, Descripcion)
                           VALUES (@Nombre, @Descripcion)";

					using (var cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@Nombre", tipo.Nombre);
						cmd.Parameters.AddWithValue("@Descripcion", tipo.Descripcion);

						cmd.ExecuteNonQuery();
					}
				}
				return "Tipo de videojuego registrado correctamente.";
			}
			catch (Exception ex)
			{
				return "Error al registrar el tipo de videojuego: " + ex.Message;
			}
		}

		public bool Eliminar(int id)
		{
			try
			{
				using (var conn = _conexion.ObtenerConexion())
				{
					conn.Open();
					string sql = "DELETE FROM TipoVideojuego WHERE Id=@Id";

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
				throw new Exception("Error al eliminar tipo de videojuego: " + ex.Message);
			}
		}

		public bool Actualizar(TipoVideojuegoEntidad Tipovideojuego)
		{
			try
			{
				using (var conn = _conexion.ObtenerConexion())
				{
					conn.Open();
					string sql = @"
              UPDATE TipoVideojuego
                 SET Nombre=@Nombre,
                     Descripcion=@Descripcion
               WHERE Id=@Id";

					using (var cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@Id", Tipovideojuego.Id);
						cmd.Parameters.AddWithValue("@Nombre", Tipovideojuego.Nombre);
						cmd.Parameters.AddWithValue("@Descripcion", Tipovideojuego.Descripcion);

						int rowsAffected = cmd.ExecuteNonQuery();
						return rowsAffected > 0;
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al actualizar tipo de videojuego: " + ex.Message);
			}
		}


	}
}
