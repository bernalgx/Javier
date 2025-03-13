using System;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Log_Negocio;

namespace Capa_Interfaz
{
	public partial class FrmRegistroVideojuego : Form
	{
		// Instancia para gestionar la lógica de negocio de los videojuegos
		private LogVideojuego logicaVideojuego = new LogVideojuego();
		// Instancia compartida para gestionar los tipos de videojuegos
		private LogTipoVideojuego TipoVideoJuego;

		// Constructor que recibe la instancia compartida de LogTipoVideojuego
		public FrmRegistroVideojuego(LogTipoVideojuego TipoVideoJuegoCompartida)
		{
			InitializeComponent();
			TipoVideoJuego = TipoVideoJuegoCompartida;
		}

		// Evento que se ejecuta al cargar el formulario
		private void FrmRegistroVideojuego_Load(object sender, EventArgs e)
		{
			// Configura el ComboBox para mostrar el nombre del tipo de videojuego
			cmbTipoVideojuego.DisplayMember = "Nombre";
			cmbTipoVideojuego.ValueMember = "Id";

			// Asigna el DataSource al ComboBox con los tipos de videojuegos obtenidos
			cmbTipoVideojuego.DataSource = TipoVideoJuego.ObtenerTipos();

			// Limpia y agrega opciones al ComboBox de formato físico/virtual
			cmbFisico.Items.Clear();
			cmbFisico.Items.Add("Físico");
			cmbFisico.Items.Add("Virtual");
		}

		// Evento que se ejecuta al hacer clic en el botón de registrar
		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			try
			{
				// Obtiene los valores ingresados por el usuario
				string nombre = txtNombre.Text;
				// Asegúrate de que se haya seleccionado un tipo de videojuego
				if (cmbTipoVideojuego.SelectedItem == null)
				{
					MessageBox.Show("Seleccione un tipo de videojuego.");
					return;
				}
				var tipo = (TipoVideojuegoEntidad)cmbTipoVideojuego.SelectedItem;
				string desarrollador = txtDesarrollador.Text;
				int lanzamiento = int.Parse(txtLanzamiento.Text);
				bool fisico = (cmbFisico.SelectedItem?.ToString() == "Físico");

				// Lógica para registrar el videojuego (ejemplo)
				// string mensaje = logicaVideojuego.RegistrarVideojuego(nombre, tipo, desarrollador, lanzamiento, fisico);
				// MessageBox.Show(mensaje);

				// Muestra un mensaje de éxito
				MessageBox.Show("Videojuego registrado.");

				// Limpia los campos del formulario
				txtNombre.Clear();
				txtDesarrollador.Clear();
				txtLanzamiento.Clear();
				cmbTipoVideojuego.SelectedIndex = -1;
				cmbFisico.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				// Muestra un mensaje de error en caso de excepción
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}
