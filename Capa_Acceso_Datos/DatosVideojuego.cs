using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;




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
					(Nombre, Desarrollador, Lanzamiento, Fisico, TipoVideojuegoId)
					VALUES 
					(@Nombre, @Desarrollador, @Lanzamiento, @Fisico, @TipoVideojuegoId)";

					using (var cmd = new SqlCommand(sql, conn))
					{

						//cmd.Parameters.AddWithValue("@Nombre", "metalgear");
						//cmd.Parameters.AddWithValue("@Desarrollador", "Konami");
						//cmd.Parameters.AddWithValue("@Lanzamiento", 1995);
						//cmd.Parameters.AddWithValue("@Fisico", 1);
						//cmd.Parameters.AddWithValue("@TipoVideojuegoId", 1);

						cmd.Parameters.AddWithValue("@Nombre", videojuego.Nombre);
						cmd.Parameters.AddWithValue("@Desarrollador", videojuego.Desarrollador);
						cmd.Parameters.AddWithValue("@Lanzamiento", videojuego.Lanzamiento);
						cmd.Parameters.AddWithValue("@Fisico", videojuego.Fisico);
						cmd.Parameters.AddWithValue("@TipoVideojuegoId", videojuego.TipoVideojuegoId);

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



		//// Ejemplo: Crear un videojuego en la base de datos
		//public string Crear(VideojuegoEntidad videojuego)
		//{
		//	try
		//	{
		//		using (SqlConnection conn = _conexion.ObtenerConexion())
		//		{
		//			conn.Open();

		//			string sql = "INSERT INTO Videojuego (Id, Titulo, Genero, Precio) " +
		//						 "VALUES (@Id, @Titulo, @Genero, @Precio)";

		//			using (SqlCommand cmd = new SqlCommand(sql, conn))
		//			{
		//				// Parámetros para evitar inyección SQL
		//				cmd.Parameters.AddWithValue("@Id", videojuego.Id);
		//				cmd.Parameters.AddWithValue("@Titulo", videojuego.Titulo);
		//				cmd.Parameters.AddWithValue("@Genero", videojuego.Genero);
		//				cmd.Parameters.AddWithValue("@Precio", videojuego.Precio);

		//				cmd.ExecuteNonQuery();
		//			}
		//		}

		//		return "El videojuego se ha registrado correctamente.";
		//	}
		//	catch (Exception ex)
		//	{
		//		// Manejar la excepción de forma apropiada
		//		return $"Error al registrar el videojuego: {ex.Message}";
		//	}
		//}

		//// Ejemplo: Obtener todos los videojuegos
		//public List<VideojuegoEntidad> ObtenerTodos()
		//{
		//	List<VideojuegoEntidad> lista = new List<VideojuegoEntidad>();

		//	try
		//	{
		//		using (SqlConnection conn = _conexion.ObtenerConexion())
		//		{
		//			conn.Open();
		//			string sql = "SELECT Id, Titulo, Genero, Precio FROM Videojuego";

		//			using (SqlCommand cmd = new SqlCommand(sql, conn))
		//			{
		//				using (SqlDataReader reader = cmd.ExecuteReader())
		//				{
		//					while (reader.Read())
		//					{
		//						VideojuegoEntidad v = new VideojuegoEntidad
		//						{
		//							Id = reader.GetInt32(reader.GetOrdinal("Id")),
		//							Titulo = reader.GetString(reader.GetOrdinal("Titulo")),
		//							Genero = reader.GetString(reader.GetOrdinal("Genero")),
		//							Precio = reader.GetDecimal(reader.GetOrdinal("Precio"))
		//						};
		//						lista.Add(v);
		//					}
		//				}
		//			}
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		// Manejar la excepción de forma apropiada
		//		Console.WriteLine("Error al obtener videojuegos: " + ex.Message);
		//	}

		//	return lista;
		//}

		//// Ejemplo: Actualizar un videojuego
		//public bool Actualizar(VideojuegoEntidad videojuego)
		//{
		//	try
		//	{
		//		using (SqlConnection conn = _conexion.ObtenerConexion())
		//		{
		//			conn.Open();
		//			string sql = "UPDATE Videojuego SET Titulo=@Titulo, Genero=@Genero, Precio=@Precio " +
		//						 "WHERE Id=@Id";

		//			using (SqlCommand cmd = new SqlCommand(sql, conn))
		//			{
		//				cmd.Parameters.AddWithValue("@Id", videojuego.Id);
		//				cmd.Parameters.AddWithValue("@Titulo", videojuego.Titulo);
		//				cmd.Parameters.AddWithValue("@Genero", videojuego.Genero);
		//				cmd.Parameters.AddWithValue("@Precio", videojuego.Precio);

		//				int rowsAffected = cmd.ExecuteNonQuery();
		//				return rowsAffected > 0;
		//			}
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		// Manejar la excepción de forma apropiada
		//		Console.WriteLine("Error al actualizar videojuego: " + ex.Message);
		//		return false;
		//	}
		//}

		//// Ejemplo: Eliminar un videojuego
		//public bool Eliminar(int id)
		//{
		//	try
		//	{
		//		using (SqlConnection conn = _conexion.ObtenerConexion())
		//		{
		//			conn.Open();
		//			string sql = "DELETE FROM Videojuego WHERE Id=@Id";

		//			using (SqlCommand cmd = new SqlCommand(sql, conn))
		//			{
		//				cmd.Parameters.AddWithValue("@Id", id);
		//				int rowsAffected = cmd.ExecuteNonQuery();
		//				return rowsAffected > 0;
		//			}
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		// Manejar la excepción de forma apropiada
		//		Console.WriteLine("Error al eliminar videojuego: " + ex.Message);
		//		return false;
		//	}
		//}
	}
}






//namespace Capa_Acceso_Datos
//{
//<summary>
//Clase estática que simula la persistencia de datos en memoria(arreglo).
//</summary>
//public static class DatosVideojuego
//{
//	private static VideojuegoEntidad[] videojuegos = new VideojuegoEntidad[20];
//	private static int contador = 0;

/// <summary>
/// Agrega un nuevo videojuego al arreglo si no excede la capacidad y no hay un ID repetido.
/// </summary>
/// <param name="v">Instancia de VideojuegoEntidad a agregar.</param>
/// <returns>Mensaje de éxito o error.</returns>
//public static string Crear(VideojuegoEntidad v)
//{
//	// Validar ID duplicado
//	for (int i = 0; i < contador; i++)
//	{
//		if (videojuegos[i].Id == v.Id)
//		{
//			return "Error: Ya existe un videojuego con el mismo ID.";
//		}
//	}

//	// Validar espacio disponible
//	if (contador >= videojuegos.Length)
//	{
//		return "No se pueden ingresar más registros (límite alcanzado).";
//	}

//	// Agregar al arreglo
//	videojuegos[contador] = v;
//	contador++;
//	return "El videojuego se ha registrado correctamente.";
//}

/// <summary>
/// Retorna todos los videojuegos actualmente en el arreglo (sin espacios vacíos).
/// </summary>
//	public static VideojuegoEntidad[] ObtenerTodos()
//	{
//		// Retornamos una copia exacta de los registros existentes
//		VideojuegoEntidad[] copia = new VideojuegoEntidad[contador];
//		for (int i = 0; i < contador; i++)
//		{
//			copia[i] = videojuegos[i];
//		}
//		return copia;
//	}
//}


//public static class DatosVideojuego
//{



//private static VideojuegoEntidad[] videojuegos = new VideojuegoEntidad[20];
//private static int contador = 0;

//// Crear un nuevo videojuego
//public static bool Crear(VideojuegoEntidad videojuego)
//{
//	if (contador >= 20) return false; // Limite alcanzado

//	// Validar que el ID no exista
//	foreach (var v in videojuegos)
//	{
//		if (v != null && v.Id == videojuego.Id)
//			throw new Exception("El ID ya existe.");
//	}

//	videojuegos[contador] = videojuego;
//	contador++;
//	return true;
//}

//// Obtener todos los videojuegos
//public static VideojuegoEntidad[] ObtenerTodos()
//{
//	return videojuegos;
//}

//// Actualizar un videojuego
//public static bool Actualizar(VideojuegoEntidad videojuego)
//{
//	for (int i = 0; i < contador; i++)
//	{
//		if (videojuegos[i] != null && videojuegos[i].Id == videojuego.Id)
//		{
//			videojuegos[i] = videojuego;
//			return true;
//		}
//	}
//	return false;
//}

//// Eliminar un videojuego por ID
//public static bool Eliminar(int id)
//{
//	for (int i = 0; i < contador; i++)
//	{
//		if (videojuegos[i] != null && videojuegos[i].Id == id)
//		{
//			videojuegos[i] = null;
//			return true;
//		}
//	}
//	return false;
//}
//}
//}

