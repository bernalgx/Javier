using System;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient; // Asegurar que se está usando Microsoft.Data.SqlClient

namespace Capa_Acceso_Datos
{
	// Clase para gestionar la conexión con la base de datos
	public class ConexionBD
	{
		// Cadena de conexión corregida con el nombre correcto de la base de datos
		//private readonly string connectionString = "Server=GOSVE\\SQLEXPRESS;Database=GAMES4U2;Trusted_Connection=True;TrustServerCertificate=True;";
		private readonly string connectionString = "Server=MAU;Database=BD_45GAMES4UJAVIERRC;Trusted_Connection=True;TrustServerCertificate=True;";
		// Método para obtener una conexión a la base de datos
		public SqlConnection ObtenerConexion()
		{
			return new SqlConnection(connectionString);
		}
	}
}
