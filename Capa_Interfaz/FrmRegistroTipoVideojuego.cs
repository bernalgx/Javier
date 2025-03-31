using System;
using System.Windows.Forms;
using Capa_Log_Negocio;

namespace Capa_Interfaz
{
    public partial class FrmRegistroTipoVideojuego : Form
    {
        private readonly LogTipoVideojuego _logica;

        // Constructor con parámetro requerido
        public FrmRegistroTipoVideojuego(LogTipoVideojuego logica)
        {
            InitializeComponent();
            _logica = logica;
        }

        // Constructor sin parámetros (opcional)
        public FrmRegistroTipoVideojuego() : this(new LogTipoVideojuego())
        {
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Todos los campos son requeridos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resultado = _logica.RegistrarTipoVideojuego(nombre, descripcion);
            MessageBox.Show(resultado);

            if (resultado.Contains("correctamente"))
            {
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtNombre.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
