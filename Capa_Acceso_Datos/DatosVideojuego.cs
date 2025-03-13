using System.Data;
using System.Text;
//using Capa_Entidades;
using Microsoft.Data.SqlClient;

namespace Capa_Acceso_Datos
{

	/// <summary>
	/// Clase estática que simula la persistencia de datos en memoria (arreglo).
	/// </summary>
	//public static class DatosVideojuego
	//{
	//	private static VideojuegoEntidad[] videojuegos = new VideojuegoEntidad[20];
	//	private static int contador = 0;

	//	/// <summary>
	//	/// Agrega un nuevo videojuego al arreglo si no excede la capacidad y no hay un ID repetido.
	//	/// </summary>
	//	/// <param name="v">Instancia de VideojuegoEntidad a agregar.</param>
	//	/// <returns>Mensaje de éxito o error.</returns>
	//	public static string Crear(VideojuegoEntidad v)
	//	{
	//		// Validar ID duplicado
	//		for (int i = 0; i < contador; i++)
	//		{
	//			if (videojuegos[i].Id == v.Id)
	//			{
	//				return "Error: Ya existe un videojuego con el mismo ID.";
	//			}
	//		}

	//		// Validar espacio disponible
	//		if (contador >= videojuegos.Length)
	//		{
	//			return "No se pueden ingresar más registros (límite alcanzado).";
	//		}

	//		// Agregar al arreglo
	//		videojuegos[contador] = v;
	//		contador++;
	//		return "El videojuego se ha registrado correctamente.";
	//	}

	//	/// <summary>
	//	/// Retorna todos los videojuegos actualmente en el arreglo (sin espacios vacíos).
	//	/// </summary>
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
}

