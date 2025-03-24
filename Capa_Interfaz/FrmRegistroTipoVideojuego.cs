using System;
using System.Drawing;
using System.Windows.Forms;
using Capa_Acceso_Datos;
using Capa_Entidades;
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
				string nombre = txtNombre.Text;
				string descripcion = txtDescripcion.Text;

				// Crea el objeto de tipo de videojuego
				TipoVideojuegoEntidad nuevoTipo = new TipoVideojuegoEntidad
				{

					Nombre = nombre,
					Descripcion = descripcion
				};

				// Llama al método Crear de la clase de acceso a datos
				DatosTipoVideojuego datosTipo = new DatosTipoVideojuego();
				string mensaje = datosTipo.Crear(nuevoTipo);

				// Muestra un mensaje con el resultado de la operación
				MessageBox.Show(mensaje);

				// Limpia los campos del formulario
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
