using System;
using System.Windows.Forms;
using Capa_Acceso_Datos;
using Capa_Entidades;
using Capa_Log_Negocio;

namespace Capa_Interfaz
{
	public partial class FrmRegistroTienda : Form
	{
		private LogTienda logicaTienda = new LogTienda();
		private LogAdministrador logicaAdministrador = new LogAdministrador();

		public FrmRegistroTienda()
		{
			InitializeComponent();
			CargarAdministradores();
			ConfigurarComboboxActiva();
		}

		private void CargarAdministradores()
		{
			try
			{
				var administradores = logicaAdministrador.ObtenerAdministradoresDesdeBD();
				cmbAdministrador.DataSource = administradores;
				cmbAdministrador.DisplayMember = "NombreCompleto";
				cmbAdministrador.ValueMember = "Identificacion";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar administradores: " + ex.Message);
			}
		}

		private void ConfigurarComboboxActiva()
		{
			cmbActiva.Items.Clear();
			cmbActiva.Items.Add("Si");
			cmbActiva.Items.Add("No");
			cmbActiva.SelectedIndex = 0;
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			try
			{
				// Validar campos requeridos
				if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
					string.IsNullOrWhiteSpace(txtDireccion.Text) ||
					string.IsNullOrWhiteSpace(txtTelefono.Text) ||
					cmbAdministrador.SelectedItem == null)
				{
					MessageBox.Show("Todos los campos son requeridos.");
					return;
				}

				// Crear objeto TiendaEntidad
				TiendaEntidad nuevaTienda = new TiendaEntidad
				{
					Nombre = txtNombre.Text,
					Direccion = txtDireccion.Text,
					Telefono = txtTelefono.Text,
					Activa = cmbActiva.SelectedItem.ToString() == "Si",
					Id_Administrador = Convert.ToDecimal(cmbAdministrador.SelectedValue)
				};

				// Registrar en la base de datos
				DatosTienda datos = new DatosTienda();
				string mensaje = datos.Crear(nuevaTienda);
				MessageBox.Show(mensaje);

				// Limpiar campos
				LimpiarFormulario();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void LimpiarFormulario()
		{
			txtNombre.Clear();
			txtDireccion.Clear();
			txtTelefono.Clear();
			cmbAdministrador.SelectedIndex = -1;
			cmbActiva.SelectedIndex = 0;
		}
	}
}


