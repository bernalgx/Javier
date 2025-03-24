using Capa_Entidades;
using Capa_Log_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Interfaz
{
	public partial class FrmConsultaTipoVideoJuegos : Form
	{
		public FrmConsultaTipoVideoJuegos()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				// Suponiendo que la columna "Id", "Nombre" y "Descripcion" existen en el DataGridView
				TipoVideojuegoEntidad tipo = new TipoVideojuegoEntidad
				{
					Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value),
					Nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString(),
					Descripcion = dataGridView1.SelectedRows[0].Cells["Descripcion"].Value.ToString()
				};

				LogTipoVideojuego log = new LogTipoVideojuego();
				string resultado = log.EditarTipoVideojuego(tipo);
				MessageBox.Show(resultado);
				// Recargar la grilla
				CargarTipoVideojuegos();
			}
			else
			{
				MessageBox.Show("Selecciona un tipo de videojuego para editar.");
			}

		}


		private void button2_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				// Supongamos que la columna "Id" es la primera columna del DataGridView
				int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

				LogTipoVideojuego log = new LogTipoVideojuego();
				string resultado = log.EliminarTipoVideojuego(id);
				MessageBox.Show(resultado);
				// Recargar la grilla
				CargarTipoVideojuegos();
			}
			else
			{
				MessageBox.Show("Selecciona un videojuego para eliminar.");
			}
		}
	}
}
