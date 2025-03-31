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

namespace Capa_Interfaz
{
    public partial class FrmEditarCliente : Form
    {
        public ClienteEntidad Cliente { get; private set; }

        public FrmEditarCliente(ClienteEntidad cliente)
        {
            InitializeComponent();
            Cliente = cliente;
            CargarDatosCliente();
            ConfigurarControles();
        }

        private void CargarDatosCliente()
        {
            txtIdentificacion.Text = Cliente.Identificacion.ToString();
            txtNombre.Text = Cliente.Nombre;
            txtPrimerApellido.Text = Cliente.PrimerApellido;
            txtSegundoApellido.Text = Cliente.SegundoApellido;
            dtpFechaNacimiento.Value = Cliente.FechaNacimiento;
            cmbJugadorEnLinea.SelectedItem = Cliente.JugadorEnLinea ? "Si" : "No";
        }

        private void ConfigurarControles()
        {
            // Configurar controles
            txtIdentificacion.Enabled = false; // La identificación no se puede modificar

            // Configurar DateTimePicker
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.ShowUpDown = false;

            // Configurar ComboBox
            cmbJugadorEnLinea.Items.Clear();
            cmbJugadorEnLinea.Items.Add("Si");
            cmbJugadorEnLinea.Items.Add("No");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ActualizarCliente();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoApellido.Text))
            {
                MessageBox.Show("Todos los campos son requeridos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ActualizarCliente()
        {
            Cliente.Nombre = txtNombre.Text;
            Cliente.PrimerApellido = txtPrimerApellido.Text;
            Cliente.SegundoApellido = txtSegundoApellido.Text;
            Cliente.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            Cliente.JugadorEnLinea = cmbJugadorEnLinea.SelectedItem.ToString() == "Si";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
