using Capa_Entidades;
using Capa_Log_Negocio;
using System;
using System.Windows.Forms;

namespace Capa_Interfaz
{
    public partial class FrmConsultaTipoVideojuego : Form
    {
        // Instancia para gestionar la lógica de tipos de videojuegos
        private LogTipoVideojuego logicaTipo = new LogTipoVideojuego();

        // Constructor sin parámetros
        public FrmConsultaTipoVideojuego()
        {
            InitializeComponent();
            CargarTiposVideojuego();
        }

        private void CargarTiposVideojuego()
        {
            try
            {
                dgvTiposVideojuego.DataSource = logicaTipo.ObtenerTiposVideojuego();
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de videojuegos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvTiposVideojuego.Columns["Id"].HeaderText = "ID";
            dgvTiposVideojuego.Columns["Nombre"].HeaderText = "Nombre";
            dgvTiposVideojuego.Columns["Descripcion"].HeaderText = "Descripción";
            dgvTiposVideojuego.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTiposVideojuego.SelectedRows.Count > 0)
            {
                // Obtener el tipo de videojuego seleccionado
                TipoVideojuegoEntidad tipoVideojuego = new TipoVideojuegoEntidad
                {
                    Id = Convert.ToInt32(dgvTiposVideojuego.SelectedRows[0].Cells["Id"].Value),
                    Nombre = dgvTiposVideojuego.SelectedRows[0].Cells["Nombre"].Value.ToString(),
                    Descripcion = dgvTiposVideojuego.SelectedRows[0].Cells["Descripcion"].Value.ToString()
                };

                // Abrir formulario de edición
                FrmEditarTipoVideojuego frmEditar = new FrmEditarTipoVideojuego(tipoVideojuego);
                if (frmEditar.ShowDialog() == DialogResult.OK)
                {
                    // Después de la edición, actualizar la lista
                    TipoVideojuegoEntidad tipoEditado = frmEditar.TipoVideojuego;
                    LogTipoVideojuego log = new LogTipoVideojuego();
                    string resultado = log.EditarTipoVideojuego(tipoEditado);
                    MessageBox.Show(resultado);
                    CargarTiposVideojuego();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un tipo de videojuego para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTiposVideojuego.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvTiposVideojuego.SelectedRows[0].Cells["Id"].Value);

                if (MessageBox.Show("¿Estás seguro de eliminar este tipo de videojuego?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LogTipoVideojuego log = new LogTipoVideojuego();
                    string resultado = log.EliminarTipoVideojuego(id);
                    MessageBox.Show(resultado);
                    CargarTiposVideojuego();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un tipo de videojuego para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
