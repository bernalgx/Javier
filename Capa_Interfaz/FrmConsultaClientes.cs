using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Log_Negocio;

namespace Capa_Interfaz
{
    public partial class FrmConsultaClientes : Form
    {
        private LogCliente logicaCliente = new LogCliente();

        public FrmConsultaClientes()
        {
            InitializeComponent();
            CargarClientes();
            ConfigurarDataGridView();
        }

        private void CargarClientes()
        {
            try
            {
                var clientes = logicaCliente.ObtenerClientesDesdeBD();
                dgvClientes.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            // Configurar columnas
            dgvClientes.Columns["Identificacion"].HeaderText = "Identificación";
            dgvClientes.Columns["Nombre"].HeaderText = "Nombre";
            dgvClientes.Columns["PrimerApellido"].HeaderText = "Primer Apellido";
            dgvClientes.Columns["SegundoApellido"].HeaderText = "Segundo Apellido";
            dgvClientes.Columns["FechaNacimiento"].HeaderText = "Fecha Nacimiento";
            dgvClientes.Columns["JugadorEnLinea"].HeaderText = "Jugador en Línea";

            // Formato de columnas
            dgvClientes.Columns["FechaNacimiento"].DefaultCellStyle.Format = "d"; // Formato corto de fecha
            dgvClientes.Columns["JugadorEnLinea"].DefaultCellStyle.Format = "Si;No"; // Mostrar Si/No para booleanos

            // Hacer que el DataGridView sea de solo lectura
            dgvClientes.ReadOnly = true;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;

            // Selección de fila completa
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                var clienteSeleccionado = ObtenerClienteSeleccionado();
                var frmEditar = new FrmEditarCliente(clienteSeleccionado);

                if (frmEditar.ShowDialog() == DialogResult.OK)
                {
                    string resultado = logicaCliente.EditarCliente(frmEditar.Cliente);
                    MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private ClienteEntidad ObtenerClienteSeleccionado()
        {
            DataGridViewRow fila = dgvClientes.SelectedRows[0];
            return new ClienteEntidad
            {
                Identificacion = Convert.ToInt32(fila.Cells["Identificacion"].Value),
                Nombre = fila.Cells["Nombre"].Value.ToString(),
                PrimerApellido = fila.Cells["PrimerApellido"].Value.ToString(),
                SegundoApellido = fila.Cells["SegundoApellido"].Value.ToString(),
                FechaNacimiento = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value),
                JugadorEnLinea = Convert.ToBoolean(fila.Cells["JugadorEnLinea"].Value)
            };
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int identificacion = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Identificacion"].Value);
                    string resultado = logicaCliente.EliminarCliente(identificacion);
                    MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
