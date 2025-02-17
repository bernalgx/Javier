using System.Data;
using System.Text;
using Capa_Entidades;
using Capa_Acceso_Datos;
using Microsoft.Data.SqlClient;


namespace Capa_Acceso_Datos // Espacio para organizar clases que tienen relacion con acceso a datos
{
	public class DatosVideojuego // Clase que gestiona las operaciones de base de datos para los videojuegos
	{
		private ConexionBD conexion = new ConexionBD(); // Instancia de la clase ConexionBD para manejar la conexion a la BD

		public ConexionBD GetCon() // Metodo para tener una conexion a la base de datos
		{

			ConexionBD conexion = new ConexionBD();
			using (SqlConnection con = conexion.ObtenerConexion())
			{
				con.Open();
				Console.WriteLine("Conexion exitosa");
				con.Close();
			}
			return conexion;
			//return conexion.ObtenerConexion(); // Retorna una nueva conexion
		}


		//	//using (ConexionBD con = conexion.ObtenerConexion()) // Esto no existe en C#
		//	{
		//		string query = "SELECT V.Id, V.Nombre, T.Id AS TipoId, T.Nombre AS TipoNombre, V.Desarrollador, V.Lanzamiento, V.Fisico " +
		//					   "FROM Videojuego V INNER JOIN TipoVideojuego T ON V.TipoVideojuegoId = T.Id"; // Query SQL para insertar los videojuegos con su tipo

		//		SqlCommand cmd = new SqlCommand(query, con); // Crea un comando SQL con la query y la conexion
		//		con.Open(); // Abre la conexion a la base de datos
		//		SqlDataReader reader = cmd.ExecuteReader(); // Ejecuta la query y consigue un lector de datos

		//		while (reader.Read()) // While para ver sobre los resultados de la consulta
		//		{
		//			lista.Add(new Capa_Entidades.TipoVideojuegoEntidad
		//			{
		//				Id = reader.GetInt32(0), // Consigue el ID del videojuego
		//				Nombre = reader.GetString(1), // Consigue el nombre del videojuego
		//				TipoVideojuego = new TipoVideojuegoEntidad { Id = reader.GetInt32(2), Nombre = reader.GetString(3) },// Consigue el tipo de videojuego
		//				Desarrollador = reader.GetString(4), // Consigue el desarrollador
		//				Lanzamiento = reader.GetInt32(5), // Consigue el año de lanzamiento
		//				Fisico = reader.GetBoolean(6) // Consigue si es fisico o no
		//			});
		//		}
		//	}

		//	return lista; // Retorna la lista de videojuegos
		//}


		// Metodo para agregar un videojuego
		//public bool AgregarVideojuego(VideojuegoEntidad videojuego, ConexionBD con)
		//{
		//	if (videojuego is null) // Verifica si el objeto videojuego es nulo
		//	{
		//		throw new ArgumentNullException(nameof(videojuego)); // Lanza una excepción si es nulo
		//	}

		//	string query = "INSERT INTO Videojuego (Nombre, TipoVideojuegoId, Desarrollador, Lanzamiento, Fisico) " +
		//				   "VALUES (@Nombre, @TipoVideojuegoId, @Desarrollador, @Lanzamiento, @Fisico)"; // Query SQL para insertar un videojuego

		//	SqlCommand cmd = new SqlCommand(query, con); // Crea un comando SQL con la query y la conexion
		//	cmd.Parameters.AddWithValue("@Nombre", videojuego.Nombre); // Asigna el valor del parametro @Nombre
		//	cmd.Parameters.AddWithValue("@TipoVideojuegoId", videojuego.TipoVideojuego.Id); // Asigna el valor del parametro @TipoVideojuegoId
		//	cmd.Parameters.AddWithValue("@Desarrollador", videojuego.Desarrollador); // Asigna el valor del parametro @Desarrollador
		//	cmd.Parameters.AddWithValue("@Lanzamiento", videojuego.Lanzamiento); // Asigna el valor del parametro @Lanzamiento
		//	cmd.Parameters.AddWithValue("@Fisico", videojuego.Fisico); // Asigna el valor del parametro @Fisico

		//	con.Open(); // Abre la conexion a la base de datos
		//	int filasAfectadas = cmd.ExecuteNonQuery(); // Ejecuta la query y consigue el numero de filas afectadas
		//	return filasAfectadas > 0; // Retorna true si se inserto una fila
		//}

		// Metodo para tener todos los videojuegos
		//public List<VideojuegoEntidad> TenerVideojuegos()
		//{
		//	List<VideojuegoEntidad> lista = new List<VideojuegoEntidad>(); // Lista para almacenar los videojuegos

	}

}