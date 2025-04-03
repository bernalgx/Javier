using System;
using System.Windows.Forms;
using Capa_Acceso_Datos;
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
			try
			{
				var datos = new DatosTipoVideojuego();

				// Obtener los tipos de videojuegos desde la base de datos
				var listaTipos = datos.ObtenerTodos();

				// Configurar el ComboBox de tipos de videojuegos
				cmbTipoVideojuego.DataSource = listaTipos;
				cmbTipoVideojuego.DisplayMember = "Nombre";  // Nombre de la propiedad a mostrar
				cmbTipoVideojuego.ValueMember = "Id";       // Propiedad para el valor (si es necesario)

				// Seleccionar primer item (opcional)
				if (cmbTipoVideojuego.Items.Count > 0)
					cmbTipoVideojuego.SelectedIndex = 0;

				// Configurar ComboBox de formato físico/virtual (se mantiene igual)
				cmbFisico.Items.Clear();
				cmbFisico.Items.Add("Físico");
				cmbFisico.Items.Add("Virtual");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error cargando datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		// Evento que se ejecuta al hacer clic en el botón de registrar
		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			try
			{
				// Obtiene los valores ingresados por el usuario
				string nombre = txtNombre.Text;

				// Verifica que se haya seleccionado un tipo de videojuego
				if (cmbTipoVideojuego.SelectedItem == null)
				{
					MessageBox.Show("Seleccione un tipo de videojuego.");
					return;
				}

				// Toma el valor (int) que se configuró en ValueMember del ComboBox
				int tipo = Convert.ToInt32(cmbTipoVideojuego.SelectedValue);

				string desarrollador = txtDesarrollador.Text;
				int lanzamiento = int.Parse(txtLanzamiento.Text);
				bool fisico = (cmbFisico.SelectedItem?.ToString() == "Físico");

				// Crea el objeto VideojuegoEntidad
				VideojuegoEntidad nuevoVideojuego = new VideojuegoEntidad
				{
					// Asumiendo que la columna Id es autoincremental en la base de datos
					//Id = 0,
					Nombre = nombre,
					Desarrollador = desarrollador,
					Lanzamiento = lanzamiento,
					Fisico = fisico,
					Id_TipoVideojuego = tipo
				};

				// Llama al método Crear de la clase de acceso a datos
				DatosVideojuego datos = new DatosVideojuego();
				string mensaje = datos.Crear(nuevoVideojuego);
				MessageBox.Show(mensaje);

				// Limpia los campos del formulario
				txtNombre.Clear();
				txtDesarrollador.Clear();
				txtLanzamiento.Clear();
				cmbTipoVideojuego.SelectedIndex = -1;
				cmbFisico.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FrmRegistroTipoVideojuego frmRegistroTipoVideojuego = new FrmRegistroTipoVideojuego(TipoVideoJuego);
			frmRegistroTipoVideojuego.ShowDialog();
		}
	}
}
