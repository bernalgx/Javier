

using Capa_Acceso_Datos;

namespace WinFormsApp
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Console.WriteLine("Hello world!");
			Console.WriteLine("Hola ");
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}

		private static ConexionBD conexion = new ConexionBD(); // Instancia de la clase ConexionBD para manejar la conexion a la BD
	}
}
