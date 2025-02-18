using System;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Capa_Acceso_Datos // Espacio para organizar clases que tienen relacion con acceso a datos
{
	// Clase para gestionar la conexión con la base de datos
	public class ConexionBD
	{
		// Cadena de conexión a SQL Server (modificar según configuración local)
		private readonly string connectionString = "Server=MAU;Database=BD_45GAMES4UJAVIERRC;Trusted_Connection=True;TrustServerCertificate=True;";

		// Método para obtener una conexión a la base de datos
		public SqlConnection ObtenerConexion()
		{
			// Retorna una nueva instancia de SqlConnection utilizando la cadena de conexión especificada
			return new SqlConnection(connectionString);
		}
	}
}
