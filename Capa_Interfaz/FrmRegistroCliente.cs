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
    // Formulario para registrar clientes
    public partial class FrmRegistroCliente : Form
    {
        private LogCliente logica = new LogCliente();

        public FrmRegistroCliente()
        {
            InitializeComponent();
        }

        // Evento del boton para registrar un cliente
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int identificacion = int.Parse(txtIdentificacion.Text);
                string nombre = txtNombre.Text;
                string primerApellido = txtPrimerApellido.Text;
                string segundoApellido = txtSegundoApellido.Text;
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;
                bool jugadorEnLinea = cmbJugadorEnLinea.SelectedItem.ToString() == "Si";

                string mensaje = logica.RegistroCliente(identificacion, nombre, primerApellido, segundoApellido, fechaNacimiento, jugadorEnLinea);
                MessageBox.Show(mensaje);

                // Limpiar los campos despues de registrar
                txtIdentificacion.Clear();
                txtNombre.Clear();
                txtPrimerApellido.Clear();
                txtSegundoApellido.Clear();
                dtpFechaNacimiento.Value = DateTime.Today;
                cmbJugadorEnLinea.SelectedIndex = -1;
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Agregue valores numericos en la identificacion.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }
    }
}
