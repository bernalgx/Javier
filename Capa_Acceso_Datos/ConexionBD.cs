using System;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Capa_Acceso_Datos // Espacio para organizar clases que tienen relacion con acceso a datos
{
	// Clase para gestionar la conexion con la base de datos
	public class ConexionBD
	{
		// Cadena de conexion a SQL Server (modificar segun configuracion local)
		private readonly string connectionString = "Server=localhost\\MSSQLSERVER01;Database=BD_45GAMES4UJAVIERRC;Trusted_Connection=True;";

		// Metodo para obtener una conexion a la base de datos
		public SqlConnection ObtenerConexion()
		{
			return new SqlConnection(connectionString);
		}
	}
}
