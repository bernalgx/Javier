// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using System;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient; // Asegurar que se está usando Microsoft.Data.SqlClient

namespace Capa_Acceso_Datos
{
	// Clase para gestionar la conexion con la base de datos
	public class ConexionBD
	{
		//Cadena de conexion corregida con el nombre correcto de la base de datos
		//private readonly string connectionString = "Server=GOSVE\\SQLEXPRESS;Database=GAMES4U2;Trusted_Connection=True;TrustServerCertificate=True;";
		private readonly string connectionString = "Server=MAU;Database=GAMES4U2;Trusted_Connection=True;TrustServerCertificate=True;";

		// Metodo para obtener una conexion a la base de datos
		public SqlConnection ObtenerConexion()
		{
			return new SqlConnection(connectionString); // Retorna una nueva instancia de SqlConnection usando la cadena de conexion
		}
	}
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
