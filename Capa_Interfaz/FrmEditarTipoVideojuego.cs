// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using System;
using System.Windows.Forms;
using Capa_Entidades;

namespace Capa_Interfaz
{
    public partial class FrmEditarTipoVideojuego : Form // Define la clase FrmEditarTipoVideojuego que hereda de Form
    {
        public TipoVideojuegoEntidad TipoVideojuego { get; private set; } // Propiedad para almacenar el tipo de videojuego a editar

        public FrmEditarTipoVideojuego(TipoVideojuegoEntidad tipoVideojuego) // Constructor de la clase FrmEditarTipoVideojuego
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            TipoVideojuego = tipoVideojuego; // Asigna el tipo de videojuego pasado como parametro a la propiedad TipoVideojuego
            CargarDatos(); // Llama al metodo CargarDatos
        }

        private void CargarDatos() // Metodo para cargar los datos del tipo de videojuego en los controles del formulario
        {
            // Cargar los datos del tipo de videojuego
            txtId.Text = TipoVideojuego.Id.ToString(); // Asigna el valor del ID del tipo de videojuego al TextBox txtId
            txtNombre.Text = TipoVideojuego.Nombre; // Asigna el valor del nombre del tipo de videojuego al TextBox txtNombre
            txtDescripcion.Text = TipoVideojuego.Descripcion; // Asigna el valor de la descripcion del tipo de videojuego al TextBox txtDescripcion
        }

        private void btnGuardar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Guardar
        {
            // Validacion basica de campos requeridos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text)) // Verifica si los campos nombre y descripcion estan vacios
            {
                MessageBox.Show("Todos los campos son requeridos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestra un mensaje de advertencia
                return; // Sale del metodo
            }

            // Actualizar las propiedades del objeto
            TipoVideojuego.Nombre = txtNombre.Text; // Asigna el valor del TextBox txtNombre a la propiedad Nombre del tipo de videojuego
            TipoVideojuego.Descripcion = txtDescripcion.Text; // Asigna el valor del TextBox txtDescripcion a la propiedad Descripcion del tipo de videojuego

            // Indicar que la edicion fue exitosa y cerrar el formulario
            DialogResult = DialogResult.OK; // Establece el resultado del dialogo como OK
            Close(); // Cierra el formulario
        }

        private void btnCancelar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Cancelar
        {
            DialogResult = DialogResult.Cancel; // Establece el resultado del dialogo como Cancel
            Close(); // Cierra el formulario
        }
    }
}


//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
