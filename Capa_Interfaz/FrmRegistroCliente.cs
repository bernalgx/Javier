using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Acceso_Datos;
using Capa_Entidades;

namespace Capa_Interfaz
{
    public partial class FrmRegistroCliente : Form
    {
        public FrmRegistroCliente()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            // Configurar DateTimePicker para mostrar solo fecha
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.ShowUpDown = false;

            // Configurar ComboBox para JugadorEnLinea
            cmbJugadorEnLinea.Items.Clear();
            cmbJugadorEnLinea.Items.Add("Si");
            cmbJugadorEnLinea.Items.Add("No");
            cmbJugadorEnLinea.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos requeridos
                if (!ValidarCampos())
                    return;

                // Crear objeto ClienteEntidad
                ClienteEntidad nuevoCliente = new ClienteEntidad
                {
                    Identificacion = int.Parse(txtIdentificacion.Text),
                    Nombre = txtNombre.Text,
                    PrimerApellido = txtPrimerApellido.Text,
                    SegundoApellido = txtSegundoApellido.Text,
                    FechaNacimiento = dtpFechaNacimiento.Value.Date,
                    JugadorEnLinea = cmbJugadorEnLinea.SelectedItem.ToString() == "Si"
                };

                // Registrar en la base de datos
                DatosCliente datos = new DatosCliente();
                string mensaje = datos.Crear(nuevoCliente);
                MessageBox.Show(mensaje);

                // Limpiar campos si el registro fue exitoso
                if (mensaje.Contains("correctamente"))
                    LimpiarFormulario();
            }
            catch (FormatException)
            {
                MessageBox.Show("La identificación debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoApellido.Text))
            {
                MessageBox.Show("Todos los campos son requeridos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            cmbJugadorEnLinea.SelectedIndex = 0;
            txtIdentificacion.Focus();
        }
    }

}
    