using Capa_Entidades;

namespace Capa_Log_Negocio
{
	public class LogVideojuego
	{
		private VideojuegoEntidad[] videojuegos = new VideojuegoEntidad[20];
		private int indice = 0;

		public string RegistrarVideojuego(int id, string nombre, TipoVideojuegoEntidad tipo, string desarrollador, int lanzamiento, bool fisico)
		{
			// Validación de campos requeridos
			if (string.IsNullOrWhiteSpace(nombre) || tipo == null || string.IsNullOrWhiteSpace(desarrollador))
				return "Todos los campos son requeridos.";

			// Validar que el Id sea único
			for (int i = 0; i < indice; i++)
			{
				if (videojuegos[i].Id == id)
					return "El ID ya existe.";
			}

			// Validar espacio en el arreglo
			if (indice >= videojuegos.Length)
				return "No se pueden agregar más videojuegos.";

			// Registrar el videojuego
			videojuegos[indice] = new VideojuegoEntidad
			{
				Id = id,
				Nombre = nombre,
				TipoVideojuego = tipo,
				Desarrollador = desarrollador,
				Lanzamiento = lanzamiento,
				Fisico = fisico
			};
			indice++;

			return "Videojuego registrado correctamente.";
		}

		// Método para obtener la lista de videojuegos registrados, si fuera necesario
		public VideojuegoEntidad[] ObtenerVideojuegos()
		{
			return videojuegos.Take(indice).ToArray();
		}
	}
}
