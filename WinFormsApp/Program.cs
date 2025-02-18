

using Capa_Acceso_Datos;
using Capa_Entidades;


//Github test  

namespace WinFormsApp
{
	internal static class Program
	{
		/// Punto de entrada principal para la aplicación.
		[STAThread]
		static void Main()
		{
			// Para personalizar la configuración de la aplicación, como establecer configuraciones de DPI alto o fuente predeterminada,
			// ver https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			// Crear una instancia de la clase DatosVideojuego para gestionar operaciones de base de datos
			Capa_Acceso_Datos.DatosVideojuego datos = new Capa_Acceso_Datos.DatosVideojuego();

			// Crear una nueva instancia de VideojuegoEntidad con los datos del nuevo videojuego
			VideojuegoEntidad nuevoJuego = new VideojuegoEntidad
			{
				Id = 2,
				Nombre = "The Witcher 3",
				Desarrollador = "CD Projekt Red",
				Lanzamiento = 2015,
				Fisico = true,
				TipoVideojuego = 2
			};

			// Agregar el nuevo videojuego a la base de datos
			datos.AgregarVideojuego(nuevoJuego);

			// Obtener la lista de todos los videojuegos de la base de datos
			List<VideojuegoEntidad> listaJuegos = datos.TenerVideojuegos();
		}
	}
}
