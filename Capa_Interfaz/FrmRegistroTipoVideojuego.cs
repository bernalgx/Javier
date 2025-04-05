// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using System;
using System.Windows.Forms;
using Capa_Log_Negocio;

namespace Capa_Interfaz
{
    public partial class FrmRegistroTipoVideojuego : Form // Define la clase FrmRegistroTipoVideojuego que hereda de Form
    {
        private readonly LogTipoVideojuego _logica; // Declara una variable privada y de solo lectura de tipo LogTipoVideojuego

        // Constructor con parametro requerido
        public FrmRegistroTipoVideojuego(LogTipoVideojuego logica)
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            _logica = logica; // Asigna la instancia de LogTipoVideojuego pasada como parametro a la variable _logica
        }

        // Constructor sin parametros (opcional)
        public FrmRegistroTipoVideojuego() : this(new LogTipoVideojuego()) // Llama al constructor con parametro requerido, creando una nueva instancia de LogTipoVideojuego
        {
        }

        private void btnRegistrar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Registrar
        {
            string nombre = txtNombre.Text; // Obtiene el texto del TextBox txtNombre
            string descripcion = txtDescripcion.Text; // Obtiene el texto del TextBox txtDescripcion

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion)) // Verifica si los campos nombre y descripcion estan vacios
            {
                MessageBox.Show("Todos los campos son requeridos.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestra un mensaje de advertencia
                return; // Sale del metodo
            }

            string resultado = _logica.RegistrarTipoVideojuego(nombre, descripcion); // Llama al metodo RegistrarTipoVideojuego de la logica de negocio y almacena el resultado
            MessageBox.Show(resultado); // Muestra el resultado en un MessageBox

            if (resultado.Contains("correctamente")) // Verifica si el resultado contiene la palabra "correctamente"
            {
                txtNombre.Clear(); // Limpia el TextBox txtNombre
                txtDescripcion.Clear(); // Limpia el TextBox txtDescripcion
                txtNombre.Focus(); // Establece el foco en el TextBox txtNombre
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Cancelar
        {
            this.Close(); // Cierra el formulario
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)