// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using Capa_Acceso_Datos;
using Capa_Entidades;
using System;
using System.Windows.Forms;

namespace Capa_Interfaz
{
    public partial class FrmEditarVideojuego : Form // Define la clase FrmEditarVideojuego que hereda de Form
    {
        public VideojuegoEntidad Videojuego { get; private set; } // Propiedad para almacenar el videojuego a editar

        public FrmEditarVideojuego(VideojuegoEntidad videojuego) // Constructor de la clase FrmEditarVideojuego
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            Videojuego = videojuego; // Asigna el videojuego pasado como parametro a la propiedad Videojuego
            CargarDatos(); // Llama al metodo CargarDatos
        }

        private void CargarDatos() // Metodo para cargar los datos del videojuego en los controles del formulario
        {
            // Cargar la lista de tipos de videojuegos
            var datos = new DatosTipoVideojuego(); // Crea una instancia de DatosTipoVideojuego
            var lista = datos.ObtenerTodos(); // Obtiene la lista de tipos de videojuegos

            cmbTipoVideojuego.DataSource = lista; // Asigna la lista de tipos de videojuegos al DataSource del ComboBox cmbTipoVideojuego
            cmbTipoVideojuego.DisplayMember = "Nombre"; // Establece la propiedad DisplayMember del ComboBox cmbTipoVideojuego
            cmbTipoVideojuego.ValueMember = "Id"; // Establece la propiedad ValueMember del ComboBox cmbTipoVideojuego

            // Cargar los demas campos del formulario
            txtNombre.Text = Videojuego.Nombre; // Asigna el valor del nombre del videojuego al TextBox txtNombre
            txtDesarrollador.Text = Videojuego.Desarrollador; // Asigna el valor del desarrollador del videojuego al TextBox txtDesarrollador
            txtLanzamiento.Text = Videojuego.Lanzamiento.ToString(); // Asigna el valor del lanzamiento del videojuego al TextBox txtLanzamiento

            // Configurar el ComboBox para "Fisico" o "Digital"
            var formatoList = new[]
            {
                    new { Text = "Fisico", Value = true },
                    new { Text = "Digital", Value = false }
                };

            cmbFisico.DataSource = formatoList; // Asigna la lista de formatos al DataSource del ComboBox cmbFisico
            cmbFisico.DisplayMember = "Text"; // Establece la propiedad DisplayMember del ComboBox cmbFisico
            cmbFisico.ValueMember = "Value"; // Establece la propiedad ValueMember del ComboBox cmbFisico

            // Seleccionar el valor actual del videojuego
            cmbFisico.SelectedValue = Videojuego.Fisico; // Asigna el valor de la propiedad Fisico del videojuego al ComboBox cmbFisico
            cmbTipoVideojuego.SelectedValue = Videojuego.Id_TipoVideojuego; // Asigna el valor de la propiedad Id_TipoVideojuego del videojuego al ComboBox cmbTipoVideojuego
        }

        private void button1_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Guardar
        {
            // Validacion basica de campos requeridos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDesarrollador.Text)) // Verifica si los campos nombre y desarrollador estan vacios
            {
                MessageBox.Show("Los campos Nombre y Desarrollador son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestra un mensaje de advertencia
                return; // Sale del metodo
            }

            // Validar que el lanzamiento sea un numero valido
            if (!int.TryParse(txtLanzamiento.Text, out int lanzamiento)) // Verifica si el valor del campo lanzamiento es un numero valido
            {
                MessageBox.Show("El año de lanzamiento debe ser un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestra un mensaje de advertencia
                return; // Sale del metodo
            }

            // Actualizar las propiedades del objeto
            Videojuego.Nombre = txtNombre.Text; // Asigna el valor del TextBox txtNombre a la propiedad Nombre del videojuego
            Videojuego.Desarrollador = txtDesarrollador.Text; // Asigna el valor del TextBox txtDesarrollador a la propiedad Desarrollador del videojuego
            Videojuego.Lanzamiento = lanzamiento; // Asigna el valor del lanzamiento al videojuego

            // Asignar el valor booleano a partir del ComboBox de formato
            if (cmbFisico.SelectedItem != null && cmbFisico.SelectedItem.ToString().Contains("Fisico")) // Verifica si el valor seleccionado en el ComboBox cmbFisico es "Fisico"
            {
                Videojuego.Fisico = true; // Asigna true a la propiedad Fisico del videojuego
            }
            else
            {
                Videojuego.Fisico = false; // Asigna false a la propiedad Fisico del videojuego
            }

            // Actualizar el tipo de videojuego
            if (cmbTipoVideojuego.SelectedValue != null) // Verifica si hay un valor seleccionado en el ComboBox cmbTipoVideojuego
            {
                Videojuego.Id_TipoVideojuego = Convert.ToInt32(cmbTipoVideojuego.SelectedValue); // Asigna el valor seleccionado en el ComboBox cmbTipoVideojuego a la propiedad Id_TipoVideojuego del videojuego
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de videojuego.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestra un mensaje de advertencia
                return; // Sale del metodo
            }

            // Si todo es correcto, se indica que la edicion fue exitosa y se cierra el formulario
            DialogResult = DialogResult.OK; // Establece el resultado del dialogo como OK
            Close(); // Cierra el formulario
        }

        private void button2_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Cancelar
        {
            DialogResult = DialogResult.Cancel; // Establece el resultado del dialogo como Cancel
            Close(); // Cierra el formulario
        }

        private void FrmEditarVideojuego_Load(object sender, EventArgs e) // Evento que se ejecuta al cargar el formulario
        {
            // Metodo vacio, se puede agregar logica si es necesario
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)