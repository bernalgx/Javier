using Capa_Acceso_Datos;
using Capa_Entidades;
using Capa_Log_Negocio;
using System;
using System.Windows.Forms;

namespace Capa_Interfaz
{
    public partial class FrmEditarTienda : Form
    {
        public TiendaEntidad Tienda { get; private set; }
        private LogAdministrador logicaAdministrador = new LogAdministrador();

        public FrmEditarTienda(TiendaEntidad tienda)
        {
            InitializeComponent();
            Tienda = tienda;
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Cargar administradores en el ComboBox
            var administradores = logicaAdministrador.ObtenerAdministradoresDesdeBD();
            cmbAdministrador.DataSource = administradores;
            cmbAdministrador.DisplayMember = "NombreCompleto";
            cmbAdministrador.ValueMember = "Identificacion";

            // Cargar los demás campos del formulario
            txtNombre.Text = Tienda.Nombre;
            txtDireccion.Text = Tienda.Direccion;
            txtTelefono.Text = Tienda.Telefono;
            cmbActiva.SelectedItem = Tienda.Activa ? "Si" : "No";
            cmbAdministrador.SelectedValue = Tienda.Id_Administrador;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validación basica de campos requeridos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                cmbAdministrador.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar las propiedades del objeto
            Tienda.Nombre = txtNombre.Text;
            Tienda.Direccion = txtDireccion.Text;
            Tienda.Telefono = txtTelefono.Text;
            Tienda.Activa = cmbActiva.SelectedItem.ToString() == "Si";
            Tienda.Id_Administrador = (int)cmbAdministrador.SelectedValue;

            // Si todo es correcto, se indica que la edición fue exitosa
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
