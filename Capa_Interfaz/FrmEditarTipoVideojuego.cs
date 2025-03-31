using System;
using System.Windows.Forms;
using Capa_Entidades;

namespace Capa_Interfaz
{
    public partial class FrmEditarTipoVideojuego : Form
    {
        public TipoVideojuegoEntidad TipoVideojuego { get; private set; }

        public FrmEditarTipoVideojuego(TipoVideojuegoEntidad tipoVideojuego)
        {
            InitializeComponent();
            TipoVideojuego = tipoVideojuego;
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Cargar los datos del tipo de videojuego
            txtId.Text = TipoVideojuego.Id.ToString();
            txtNombre.Text = TipoVideojuego.Nombre;
            txtDescripcion.Text = TipoVideojuego.Descripcion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación básica de campos requeridos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Todos los campos son requeridos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar las propiedades del objeto
            TipoVideojuego.Nombre = txtNombre.Text;
            TipoVideojuego.Descripcion = txtDescripcion.Text;

            // Indicar que la edición fue exitosa y cerrar el formulario
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
