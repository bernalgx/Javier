// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using Capa_Acceso_Datos;
using Capa_Entidades;
using Capa_Log_Negocio;
using System;
using System.Windows.Forms;

namespace Capa_Interfaz
{
    public partial class FrmEditarTienda : Form // Define la clase FrmEditarTienda que hereda de Form
    {
        public TiendaEntidad Tienda { get; private set; } // Propiedad para almacenar la tienda a editar
        private LogAdministrador logicaAdministrador = new LogAdministrador(); // Declara una variable privada de tipo LogAdministrador e inicializa una nueva instancia

        public FrmEditarTienda(TiendaEntidad tienda) // Constructor de la clase FrmEditarTienda
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            Tienda = tienda; // Asigna la tienda pasada como parametro a la propiedad Tienda
            CargarDatos(); // Llama al metodo CargarDatos
        }

        private void CargarDatos() // Metodo para cargar los datos de la tienda en los controles del formulario
        {
            // Cargar administradores en el ComboBox
            var administradores = logicaAdministrador.ObtenerAdministradoresDesdeBD(); // Obtiene la lista de administradores desde la logica de negocio
            cmbAdministrador.DataSource = administradores; // Asigna la lista de administradores al DataSource del ComboBox cmbAdministrador
            cmbAdministrador.DisplayMember = "NombreCompleto"; // Establece la propiedad DisplayMember del ComboBox cmbAdministrador
            cmbAdministrador.ValueMember = "Identificacion"; // Establece la propiedad ValueMember del ComboBox cmbAdministrador

            // Cargar los demas campos del formulario
            txtNombre.Text = Tienda.Nombre; // Asigna el valor del nombre de la tienda al TextBox txtNombre
            txtDireccion.Text = Tienda.Direccion; // Asigna el valor de la direccion de la tienda al TextBox txtDireccion
            txtTelefono.Text = Tienda.Telefono; // Asigna el valor del telefono de la tienda al TextBox txtTelefono
            cmbActiva.SelectedItem = Tienda.Activa ? "Si" : "No"; // Asigna el valor de la propiedad Activa de la tienda al ComboBox cmbActiva
            cmbAdministrador.SelectedValue = Tienda.Id_Administrador; // Asigna el valor de la propiedad Id_Administrador de la tienda al ComboBox cmbAdministrador
        }

        private void button1_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Guardar
        {
            // Validacion basica de campos requeridos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                cmbAdministrador.SelectedItem == null) // Verifica si los campos nombre, direccion, telefono y administrador estan vacios
            {
                MessageBox.Show("Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestra un mensaje de advertencia
                return; // Sale del metodo
            }

            // Actualizar las propiedades del objeto
            Tienda.Nombre = txtNombre.Text; // Asigna el valor del TextBox txtNombre a la propiedad Nombre de la tienda
            Tienda.Direccion = txtDireccion.Text; // Asigna el valor del TextBox txtDireccion a la propiedad Direccion de la tienda
            Tienda.Telefono = txtTelefono.Text; // Asigna el valor del TextBox txtTelefono a la propiedad Telefono de la tienda
            Tienda.Activa = cmbActiva.SelectedItem.ToString() == "Si"; // Asigna el valor del ComboBox cmbActiva a la propiedad Activa de la tienda
            Tienda.Id_Administrador = (int)cmbAdministrador.SelectedValue; // Asigna el valor del ComboBox cmbAdministrador a la propiedad Id_Administrador de la tienda

            // Si todo es correcto, se indica que la edicion fue exitosa
            DialogResult = DialogResult.OK; // Establece el resultado del dialogo como OK
            Close(); // Cierra el formulario
        }

        private void button2_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Cancelar
        {
            DialogResult = DialogResult.Cancel; // Establece el resultado del dialogo como Cancel
            Close(); // Cierra el formulario
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)