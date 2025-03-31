using System;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Log_Negocio;

namespace Capa_Interfaz
{
    public partial class FrmConsultaAdministrador : Form
    {
        public FrmConsultaAdministrador()
        {
            InitializeComponent();
        }
        private void FrmConsultaAdministrador_Load(object sender, EventArgs e)
        {
            CargarAdministradores();
        }

        private void CargarAdministradores()
        {
            LogAdministrador log = new LogAdministrador();
            dataGridView1.DataSource = log.ObtenerAdministradoresDesdeBD();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var admin = new AdministradorEntidad
                {
                    Identificacion = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Identificacion"].Value),
                    Nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString(),
                    PrimerApellido = dataGridView1.SelectedRows[0].Cells["PrimerApellido"].Value.ToString(),
                    SegundoApellido = dataGridView1.SelectedRows[0].Cells["SegundoApellido"].Value.ToString(),
                    FechaNacimiento = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["FechaNacimiento"].Value),
                    FechaContratacion = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["FechaContratacion"].Value)
                };

                FrmEditarAdministrador frmEditar = new FrmEditarAdministrador(admin);
                if (frmEditar.ShowDialog() == DialogResult.OK)
                {
                    LogAdministrador log = new LogAdministrador();
                    string mensaje = log.EditarAdministrador(frmEditar.Administrador);
                    MessageBox.Show(mensaje);
                    CargarAdministradores();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un administrador para editar.");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Identificacion"].Value);
                LogAdministrador log = new LogAdministrador();
                string mensaje = log.EliminarAdministrador(id);
                MessageBox.Show(mensaje);
                CargarAdministradores();
            }
            else
            {
                MessageBox.Show("Seleccione un administrador para eliminar.");
            }

        }
    }
}
