using System.Windows.Forms;

namespace Capa_Interfaz
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new MenuPrincipal());
			//Application.Run(new FrmVideoJuegos());
		}
	}
}