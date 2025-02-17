using System; // Importa funcionalidades basicas del sistema
using System.Windows.Forms; // Importa componentes de Windows Forms
using Capa_Log_Negocio; // Importa la logica de negocio
using Capa_Entidades; // Importa las entidades del sistema

namespace Capa_Interfaz // Espacio de nombres para la capa de interfaz
{
    public partial class FrmRegistrarCliente : Form // Formulario para registrar clientes
    {
        private LogCliente logica = new Capa_Log_Negocio.LogCliente(); // Instancia de la logica de negocio

        public FrmRegistrarCliente() // Constructor del formulario
        {
            InitializeComponent(); // Inicializa los componentes visuales
        }

        private void btnRegistrar_Click(object sender, EventArgs e) // Evento al hacer clic en "Registrar"
        {
            try
            {
                // Valida que ningun campo este vacio
                if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtSegundoApellido.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                // Valida que la identificacion sea un numero valido
                if (!int.TryParse(txtIdentificacion.Text, out int identificacion))
                {
                    MessageBox.Show("La identificacion debe ser un numero valido.");
                    return;
                }

                string nombre = txtNombre.Text.Trim(); // Obtiene el nombre sin espacios extra
                string primerApellido = txtPrimerApellido.Text.Trim(); // Obtiene el primer apellido
                string segundoApellido = txtSegundoApellido.Text.Trim(); // Obtiene el segundo apellido
                DateTime fechaNacimiento = dtpFechaNacimiento.Value; // Obtiene la fecha de nacimiento
                bool jugadorEnLinea = cmbJugadorEnLinea.SelectedItem.ToString() == "Si"; // Obtiene si es jugador en linea

                // Registra cliente y mostrar mensaje de confirmacion
                string mensaje = logica.RegistrarCliente(identificacion, nombre, primerApellido, segundoApellido, fechaNacimiento, jugadorEnLinea);
                MessageBox.Show(mensaje);

                // Limpia los campos despues del registro
                txtIdentificacion.Clear();
                txtNombre.Clear();
                txtPrimerApellido.Clear();
                txtSegundoApellido.Clear();
                dtpFechaNacimiento.Value = DateTime.Today;
                cmbJugadorEnLinea.SelectedIndex = -1;
            }
            catch (Exception ex) // Captura errores inesperados
            {
                MessageBox.Show("Error: " + ex.Message); // Muestra un mensaje de error
            }
        }
    }
}