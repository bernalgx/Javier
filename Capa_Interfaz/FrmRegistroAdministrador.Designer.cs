using System; // Importa funcionalidades basicas del sistema
using System.Windows.Forms; // Importa componentes de Windows Forms
using Capa_Log_Negocio; // Importa la logica de negocio
using Capa_Entidades; // Importa las entidades del sistema

namespace Capa_Interfaz // Espacio de nombres para la capa de interfaz
{
    public partial class FrmRegistrarAdministrador : Form // Formulario para registrar administradores
    {
        private LogicaAdministrador logica = new LogicaAdministrador(); // Instancia de la logica de negocio

        public FrmRegistrarAdministrador() // Constructor del formulario
        {
            InitializeComponent(); // Inicializa los componentes visuales
        }

        private void btnRegistrar_Click(object sender, EventArgs e) // Evento al hacer clic en "Registrar"
        {
            try
            {
                int identificacion = int.Parse(txtIdentificacion.Text); // Obtiene la identificacion
                string nombre = txtNombre.Text; // Obtiene el nombre
                string primerApellido = txtPrimerApellido.Text; // Obtiene el primer apellido
                string segundoApellido = txtSegundoApellido.Text; // Obtiene el segundo apellido
                DateTime fechaNacimiento = dtpFechaNacimiento.Value; // Obtiene la fecha de nacimiento
                DateTime fechaContratacion = dtpFechaContratacion.Value; // Obtiene la fecha de contratacion

                // Llama al metodo para registrar el administrador y muestra el mensaje resultante
                string mensaje = logica.RegistrarAdministrador(identificacion, nombre, primerApellido, segundoApellido, fechaNacimiento, fechaContratacion);
                MessageBox.Show(mensaje);

                // Limpia los campos del formulario despues del registro
                txtIdentificacion.Clear();
                txtNombre.Clear();
                txtPrimerApellido.Clear();
                txtSegundoApellido.Clear();
                dtpFechaNacimiento.Value = DateTime.Today;
                dtpFechaContratacion.Value = DateTime.Today;
            }
            catch (Exception ex) // Captura errores durante el registro
            {
                MessageBox.Show("Error: " + ex.Message); // Muestra un mensaje de error
            }
        }
    }
}