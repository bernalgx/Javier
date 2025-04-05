// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using System;
using System.Windows.Forms;
using Capa_Acceso_Datos;
using Capa_Entidades;
using Capa_Log_Negocio;

namespace Capa_Interfaz
{
    public partial class FrmRegistroTienda : Form // Define la clase FrmRegistroTienda que hereda de Form
    {
        private LogTienda logicaTienda = new LogTienda(); // Declara una variable privada de tipo LogTienda e inicializa una nueva instancia
        private LogAdministrador logicaAdministrador = new LogAdministrador(); // Declara una variable privada de tipo LogAdministrador e inicializa una nueva instancia

        public FrmRegistroTienda() // Constructor de la clase FrmRegistroTienda
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            CargarAdministradores(); // Llama al metodo CargarAdministradores
            ConfigurarComboboxActiva(); // Llama al metodo ConfigurarComboboxActiva
        }

        private void CargarAdministradores() // Metodo para cargar los administradores en el ComboBox
        {
            try
            {
                var administradores = logicaAdministrador.ObtenerAdministradoresDesdeBD(); // Obtiene la lista de administradores desde la logica de negocio
                cmbAdministrador.DataSource = administradores; // Asigna la lista de administradores al DataSource del ComboBox cmbAdministrador
                cmbAdministrador.DisplayMember = "NombreCompleto"; // Establece la propiedad DisplayMember del ComboBox cmbAdministrador
                cmbAdministrador.ValueMember = "Identificacion"; // Establece la propiedad ValueMember del ComboBox cmbAdministrador
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error al cargar administradores: " + ex.Message); // Muestra un mensaje de error
            }
        }

        private void ConfigurarComboboxActiva() // Metodo para configurar el ComboBox cmbActiva
        {
            cmbActiva.Items.Clear(); // Limpia los items del ComboBox cmbActiva
            cmbActiva.Items.Add("Si"); // Agrega el item "Si" al ComboBox cmbActiva
            cmbActiva.Items.Add("No"); // Agrega el item "No" al ComboBox cmbActiva
            cmbActiva.SelectedIndex = 0; // Establece el indice seleccionado del ComboBox cmbActiva en 0
        }

        private void btnRegistrar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Registrar
        {
            try
            {
                // Validar campos requeridos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    cmbAdministrador.SelectedItem == null) // Verifica si los campos nombre, direccion, telefono y administrador estan vacios
                {
                    MessageBox.Show("Todos los campos son requeridos."); // Muestra un mensaje de advertencia
                    return; // Sale del metodo
                }

                // Crear objeto TiendaEntidad
                TiendaEntidad nuevaTienda = new TiendaEntidad
                {
                    Nombre = txtNombre.Text, // Asigna el valor del TextBox txtNombre a la propiedad Nombre de la tienda
                    Direccion = txtDireccion.Text, // Asigna el valor del TextBox txtDireccion a la propiedad Direccion de la tienda
                    Telefono = txtTelefono.Text, // Asigna el valor del TextBox txtTelefono a la propiedad Telefono de la tienda
                    Activa = cmbActiva.SelectedItem.ToString() == "Si", // Asigna el valor del ComboBox cmbActiva a la propiedad Activa de la tienda
                    Id_Administrador = Convert.ToDecimal(cmbAdministrador.SelectedValue) // Asigna el valor del ComboBox cmbAdministrador a la propiedad Id_Administrador de la tienda
                };

                // Registrar en la base de datos
                DatosTienda datos = new DatosTienda(); // Crea una instancia de DatosTienda
                string mensaje = datos.Crear(nuevaTienda); // Llama al metodo Crear de DatosTienda y almacena el mensaje
                MessageBox.Show(mensaje); // Muestra el mensaje en un MessageBox

                // Limpiar campos
                LimpiarFormulario(); // Llama al metodo LimpiarFormulario
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error: " + ex.Message); // Muestra un mensaje de error
            }
        }

        private void LimpiarFormulario() // Metodo para limpiar los campos del formulario
        {
            txtNombre.Clear(); // Limpia el TextBox txtNombre
            txtDireccion.Clear(); // Limpia el TextBox txtDireccion
            txtTelefono.Clear(); // Limpia el TextBox txtTelefono
            cmbAdministrador.SelectedIndex = -1; // Restablece el indice seleccionado del ComboBox cmbAdministrador
            cmbActiva.SelectedIndex = 0; // Restablece el indice seleccionado del ComboBox cmbActiva
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)

