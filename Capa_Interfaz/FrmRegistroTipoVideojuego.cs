using System;
using System.Drawing;
using System.Windows.Forms;
using Capa_Log_Negocio;

namespace Capa_Interfaz
{
	public partial class FrmRegistroTipoVideojuego : Form
	{
		// Instancia para gestionar la lógica de negocio de los tipos de videojuegos
		private LogTipoVideojuego TipoVideoJuego;

		// Constructor que recibe la instancia compartida de LogTipoVideojuego
		public FrmRegistroTipoVideojuego(LogTipoVideojuego TipoVideoJuegoCompartida)
		{
			InitializeComponent();
			TipoVideoJuego = TipoVideoJuegoCompartida;
			// Puedes agregar botones u otros controles aquí
		}

		// Evento que se ejecuta al hacer clic en el botón de registrar
		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			try
			{
				// Obtiene los valores ingresados por el usuario
				int id = int.Parse(txtId.Text);
				string nombre = txtNombre.Text;
				string descripcion = txtDescripcion.Text;

				// Llama al método RegistrarTipo para registrar el nuevo tipo de videojuego
				string mensaje = TipoVideoJuego.RegistroTipo(id, nombre, descripcion);

				// Muestra un mensaje con el resultado de la operación
				MessageBox.Show(mensaje);

				// Limpia los campos del formulario
				txtId.Clear();
				txtNombre.Clear();
				txtDescripcion.Clear();
			}
			catch (Exception ex)
			{
				// Muestra un mensaje de error en caso de excepción
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}
