using System.Data;
using System.Text;
using Capa_Entidades;
using Microsoft.Data.SqlClient;

namespace Capa_Acceso_Datos
{
	// Clase que gestiona las operaciones de base de datos para los videojuegos
	public class DatosVideojuego
	{
		// Instancia de la clase ConexionBD para gestionar la conexión a la base de datos
		private ConexionBD conexion = new ConexionBD();

		// Método para obtener todos los videojuegos
		public List<VideojuegoEntidad> TenerVideojuegos()
		{
			// Lista para almacenar los videojuegos obtenidos de la base de datos
			List<VideojuegoEntidad> lista = new List<VideojuegoEntidad>();

			// Usando la conexión a la base de datos
			using (SqlConnection con = conexion.ObtenerConexion())
			{
				// Consulta SQL para obtener los videojuegos
				string query = "SELECT Id, Nombre, Desarrollador, Lanzamiento, Fisico FROM Videojuego";

				// Usando el comando SQL para ejecutar la consulta
				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					// Abriendo la conexión
					con.Open();
					// Ejecutando la consulta y obteniendo los resultados
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						// Verifica si hay filas antes de leer
						if (reader.HasRows)
						{
							// Lee cada fila del resultado
							while (reader.Read())
							{
								// Crea una nueva instancia de VideojuegoEntidad y asigna los valores de la fila
								VideojuegoEntidad v = new VideojuegoEntidad
								{
									Id = reader.GetInt32(0),
									Nombre = reader.IsDBNull(1) ? "Desconocido" : reader.GetString(1),
									Desarrollador = reader.IsDBNull(2) ? "Desconocido" : reader.GetString(2),
									Lanzamiento = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
									Fisico = reader.IsDBNull(4) ? false : reader.GetBoolean(4)
								};
								// Agrega el videojuego a la lista
								lista.Add(v);
							}
						}
					}
				}
			}
			// Retorna la lista de videojuegos
			return lista;
		}

		// Método para agregar un videojuego
		public bool AgregarVideojuego(VideojuegoEntidad videojuego)
		{
			// Verifica que el objeto videojuego no sea nulo
			ArgumentNullException.ThrowIfNull(videojuego);

			// Usando la conexión a la base de datos
			using (SqlConnection con = conexion.ObtenerConexion())
			{
				// Consulta SQL para insertar un nuevo videojuego
				string query = "INSERT INTO Videojuego (Nombre, Desarrollador, Lanzamiento, Fisico, TipoVideojuegoId) " +
							   "VALUES (@Nombre, @Desarrollador, @Lanzamiento, @Fisico, @TipoVideojuegoId)";

				// Usando el comando SQL para ejecutar la consulta
				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					// Asignando los valores de los parámetros de la consulta
					cmd.Parameters.AddWithValue("@Nombre", videojuego.Nombre);
					cmd.Parameters.AddWithValue("@Desarrollador", videojuego.Desarrollador);
					cmd.Parameters.AddWithValue("@Lanzamiento", videojuego.Lanzamiento);
					cmd.Parameters.AddWithValue("@Fisico", videojuego.Fisico);
					cmd.Parameters.AddWithValue("@TipoVideojuegoId", videojuego.TipoVideojuego); // Corregido para usar TipoVideojuego

					// Abriendo la conexión
					con.Open();
					// Ejecutando la consulta y retornando true si se insertó al menos una fila
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}
	}
}
