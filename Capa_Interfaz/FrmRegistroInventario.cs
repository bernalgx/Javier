using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Capa_Log_Negocio;   // Asegúrate de usar el namespace donde está LogTienda
using Capa_Entidades;
using Capa_Acceso_Datos;      // Para la clase TiendaEntidad

namespace Capa_Interfaz
{
	public partial class FrmRegistroInventario : Form
	{
		public FrmRegistroInventario()
		{
			InitializeComponent();
			CargarTiendasActivas_CargarVideoJuegos();  // Aquí se llenará el ComboBox
		}

		private void CargarTiendasActivas_CargarVideoJuegos()
		{
			try
			{
				// Instanciar la clase LogTienda
				LogTienda logTienda = new LogTienda();
				LogVideojuego logVideojuego = new LogVideojuego();
				// Obtener todas las tiendas desde la base de datos
				List<TiendaEntidad> tiendas = logTienda.ObtenerTiendasDesdeBD();
				List<VideojuegoEntidad> videojuegos = logVideojuego.ObtenerVideojuegosDesdeBD();
				// Filtrar las tiendas que están activas (Activa == true)
				List<TiendaEntidad> tiendasActivas = tiendas.Where(t => t.Activa).ToList();
				List<VideojuegoEntidad> videojuegosActivos = videojuegos.ToList();
				// Asignar la lista filtrada al ComboBox
				cmbTiendas.DataSource = tiendasActivas;
				cmbVideojuegos.DataSource = videojuegosActivos;
				cmbTiendas.DisplayMember = "Nombre"; // Lo que se mostrará en el ComboBox
				cmbTiendas.ValueMember = "Id";         // El valor único de cada tienda
				cmbVideojuegos.DisplayMember = "Nombre";
				cmbVideojuegos.ValueMember = "Id";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar las tiendas activas: " + ex.Message);
			}
		}


		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			try
			{
				// Validar que todos los datos requeridos estén presentes
				if (cmbTiendas.SelectedItem == null || cmbVideojuegos.SelectedItem == null || string.IsNullOrWhiteSpace(txtExistencias.Text))
				{
					MessageBox.Show("Todos los datos son requeridos. Por favor, selecciona una tienda, un videojuego y escribe la cantidad de existencias.");
					return;
				}

				// Validar que la cantidad (existencias) sea un número entero mayor que cero
				if (!int.TryParse(txtExistencias.Text, out int existencias) || existencias <= 0)
				{
					MessageBox.Show("Ingresa una cantidad válida (número entero mayor que cero) para las existencias.");
					return;
				}

				// Obtener la tienda y el videojuego seleccionados
				TiendaEntidad tiendaSeleccionada = (TiendaEntidad)cmbTiendas.SelectedItem;
				VideojuegoEntidad videojuegoSeleccionado = (VideojuegoEntidad)cmbVideojuegos.SelectedItem;

				// Crear el objeto VideojuegosXTiendaEntidad usando el constructor requerido
				VideojuegosXTiendaEntidad registro = new VideojuegosXTiendaEntidad(tiendaSeleccionada, videojuegoSeleccionado, existencias);

				// Instanciar la lógica de negocio para VideojuegosXTienda
				LogVideojuegosXTienda logVideojuegosXTienda = new LogVideojuegosXTienda();

				// Intentar registrar el nuevo inventario en la tabla VideojuegosXTienda
				bool registrado = logVideojuegosXTienda.RegistrarInventario(registro);

				if (registrado)
				{
					MessageBox.Show("Registro exitoso.");
					// Limpiar el campo de existencias o actualizar la interfaz si es necesario
					txtExistencias.Clear();
				}
				else
				{
					MessageBox.Show("La combinación de tienda y videojuego ya existe o ocurrió un error al registrar el inventario.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}


		private void FrmRegistroInventario_Load(object sender, EventArgs e)
		{

		}
	}
}
