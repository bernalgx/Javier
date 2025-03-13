using Capa_Log_Negocio;
using System;
using System.Windows.Forms;

namespace Capa_Interfaz
{
	public partial class FrmVideoJuegos : Form
	{
		// Instancia compartida para gestionar los tipos de videojuegos
		private LogTipoVideojuego logicaTipo = new LogTipoVideojuego();

		// Constructor sin parámetros
		public FrmVideoJuegos()
		{
			InitializeComponent();
		}

		// Evento que se ejecuta al hacer clic en el botón para registrar tipos de videojuego
		private void button1_Click(object sender, EventArgs e)
		{
			// Abrir el formulario para registrar tipos de videojuego
			// Se pasa la instancia logicaTipo al constructor del formulario
			FrmRegistroTipoVideojuego form = new FrmRegistroTipoVideojuego(logicaTipo);
			form.ShowDialog();
		}

		// Evento que se ejecuta al hacer clic en el botón para registrar videojuegos
		private void button2_Click(object sender, EventArgs e)
		{
			// Abrir el formulario para registrar videojuegos
			// Se pasa la instancia logicaTipo al constructor del formulario
			FrmRegistroVideojuego form = new FrmRegistroVideojuego(logicaTipo);
			form.ShowDialog();
		}
	}
}
