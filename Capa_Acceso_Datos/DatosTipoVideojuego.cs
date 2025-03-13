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
	}
}
