using Capa_Entidades;
using Capa_Log_Negocio;
using System;
using System.Windows.Forms;

namespace Capa_Interfaz
{
	public partial class FrmConsultaTiendas : Form
	{
		private LogTienda logicaTienda = new LogTienda();

		public FrmConsultaTiendas()
		{
			InitializeComponent();
			CargarTiendas();
			ConfigurarDataGridView();
		}

		private void CargarTiendas()
		{
			try
			{
				var tiendas = logicaTienda.ObtenerTiendasDesdeBD();
				dataGridView1.DataSource = tiendas;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar tiendas: " + ex.Message);
			}
		}

		private void ConfigurarDataGridView()
		{
			// Configurar columnas
			dataGridView1.Columns["Id"].HeaderText = "ID";
			dataGridView1.Columns["Nombre"].HeaderText = "Nombre";
			dataGridView1.Columns["Direccion"].HeaderText = "Dirección";
			dataGridView1.Columns["Telefono"].HeaderText = "Teléfono";
			dataGridView1.Columns["NombreAdministrador"].HeaderText = "Administrador";

			// Configurar columna Activa
			dataGridView1.Columns["Activa"].HeaderText = "Activa";
			dataGridView1.Columns["Activa"].DefaultCellStyle.Format = "Si;No";

			// Ocultar columnas no necesarias
			dataGridView1.Columns["AdministradorId"].Visible = false;
		}
		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				var tiendaSeleccionada = ObtenerTiendaSeleccionada();
				var frmEditar = new FrmEditarTienda(tiendaSeleccionada);

				if (frmEditar.ShowDialog() == DialogResult.OK)
				{
					string resultado = logicaTienda.EditarTienda(frmEditar.Tienda);
					MessageBox.Show(resultado);
					CargarTiendas();
				}
			}
			else
			{
				MessageBox.Show("Selecciona una tienda para editar.");
			}
		}

		private TiendaEntidad ObtenerTiendaSeleccionada()
		{
			return new TiendaEntidad
			{
				Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value),
				Nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString(),
				Direccion = dataGridView1.SelectedRows[0].Cells["Direccion"].Value.ToString(),
				Telefono = dataGridView1.SelectedRows[0].Cells["Telefono"].Value.ToString(),
				Activa = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Activa"].Value),
				AdministradorId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AdministradorId"].Value)
			};
		}


		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
				string resultado = logicaTienda.EliminarTienda(id);
				MessageBox.Show(resultado);
				CargarTiendas();
			}
			else
			{
				MessageBox.Show("Selecciona una tienda para eliminar.");
			}
		}

		private void FrmConsultaTiendas_Load(object sender, EventArgs e)
		{

		}
	}
}
