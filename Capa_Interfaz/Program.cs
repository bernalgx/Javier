using Capa_Entidades;
using Capa_Interfaz;

static class Program
{
	// Propiedad para almacenar el cliente que est� usando la aplicaci�n.
	public static ClienteEntidad ClienteActual { get; set; }

	[STAThread]
	static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);

		// Aqu� se deber�a realizar el proceso de autenticaci�n y asignar el cliente.
		// Por ejemplo, si logueas al usuario y obtienes un objeto ClienteEntidad, lo asignas:
		ClienteActual = new ClienteEntidad { Identificacion = 1, Nombre = "Pepe" };

		//Application.Run(new FrmReserva());
		Application.Run(new MenuPrincipal());
	}
}