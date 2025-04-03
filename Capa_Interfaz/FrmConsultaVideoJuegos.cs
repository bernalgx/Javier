using Capa_Entidades;
using Capa_Log_Negocio;
using System;
using System.Windows.Forms;

namespace Capa_Interfaz
{
	public partial class FrmConsultaVideoJuegos : Form
	{
		// Instancia compartida para gestionar los tipos de videojuegos
		private LogTipoVideojuego logicaTipo = new LogTipoVideojuego();

		// Constructor sin parámetros
		public FrmConsultaVideoJuegos()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			if (dataGridView1.SelectedRows.Count > 0)
			{
				// Obtener el videojuego seleccionado
				VideojuegoEntidad videojuego = new VideojuegoEntidad
				{
					Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value),
					Nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString(),
					Desarrollador = dataGridView1.SelectedRows[0].Cells["Desarrollador"].Value.ToString(),
					Lanzamiento = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Lanzamiento"].Value),
					Fisico = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Fisico"].Value),
					Id_TipoVideojuego = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id_TipoVideojuego"].Value)
				};

				// Abrir un formulario de edicion, pasandole el objeto
				FrmEditarVideojuego frmEditar = new FrmEditarVideojuego(videojuego);
				if (frmEditar.ShowDialog() == DialogResult.OK)
				{
					// Después de la edición, se obtiene el objeto modificado del formulario
					VideojuegoEntidad videojuegoEditado = frmEditar.Videojuego;
					LogVideojuego log = new LogVideojuego();
					string resultado = log.EditarVideojuego(videojuegoEditado);
					MessageBox.Show(resultado);
					CargarVideojuegos();
				}
			}
			else
			{
				MessageBox.Show("Selecciona un videojuego para editar.");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				// Supongamos que la columna "Id" es la primera columna del DataGridView
				int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

				LogVideojuego log = new LogVideojuego();
				string resultado = log.EliminarVideojuego(id);
				MessageBox.Show(resultado);
				// Recargar la grilla
				CargarVideojuegos();
			}
			else
			{
				MessageBox.Show("Selecciona un videojuego para eliminar.");
			}
		}
	}
}

