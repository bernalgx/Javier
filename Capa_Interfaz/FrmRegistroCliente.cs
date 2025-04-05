// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Acceso_Datos;
using Capa_Entidades;

namespace Capa_Interfaz
{
    public partial class FrmRegistroCliente : Form // Define la clase FrmRegistroCliente que hereda de Form
    {
        public FrmRegistroCliente() // Constructor de la clase FrmRegistroCliente
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            ConfigurarControles(); // Llama al metodo ConfigurarControles
        }

        private void ConfigurarControles() // Metodo para configurar los controles del formulario
        {
            // Configurar DateTimePicker para mostrar solo fecha
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short; // Establece el formato corto de fecha para el DateTimePicker dtpFechaNacimiento
            dtpFechaNacimiento.ShowUpDown = false; // Deshabilita el control de seleccion de fecha en el DateTimePicker dtpFechaNacimiento

            // Configurar ComboBox para JugadorEnLinea
            cmbJugadorEnLinea.Items.Clear(); // Limpia los items del ComboBox cmbJugadorEnLinea
            cmbJugadorEnLinea.Items.Add("Si"); // Agrega el item "Si" al ComboBox cmbJugadorEnLinea
            cmbJugadorEnLinea.Items.Add("No"); // Agrega el item "No" al ComboBox cmbJugadorEnLinea
            cmbJugadorEnLinea.SelectedIndex = 0; // Establece el indice seleccionado del ComboBox cmbJugadorEnLinea en 0
        }

        private void btnRegistrar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Registrar
        {
            try
            {
                // Validar campos requeridos
                if (!ValidarCampos()) // Llama al metodo ValidarCampos y verifica si los campos son validos
                    return; // Sale del metodo si los campos no son validos

                // Crear objeto ClienteEntidad
                ClienteEntidad nuevoCliente = new ClienteEntidad
                {
                    Identificacion = int.Parse(txtIdentificacion.Text), // Asigna el valor del TextBox txtIdentificacion a la propiedad Identificacion del cliente
                    Nombre = txtNombre.Text, // Asigna el valor del TextBox txtNombre a la propiedad Nombre del cliente
                    PrimerApellido = txtPrimerApellido.Text, // Asigna el valor del TextBox txtPrimerApellido a la propiedad PrimerApellido del cliente
                    SegundoApellido = txtSegundoApellido.Text, // Asigna el valor del TextBox txtSegundoApellido a la propiedad SegundoApellido del cliente
                    FechaNacimiento = dtpFechaNacimiento.Value.Date, // Asigna el valor del DateTimePicker dtpFechaNacimiento a la propiedad FechaNacimiento del cliente
                    JugadorEnLinea = cmbJugadorEnLinea.SelectedItem.ToString() == "Si" // Asigna el valor del ComboBox cmbJugadorEnLinea a la propiedad JugadorEnLinea del cliente
                };

                // Registrar en la base de datos
                DatosCliente datos = new DatosCliente(); // Crea una instancia de DatosCliente
                string mensaje = datos.Crear(nuevoCliente); // Llama al metodo Crear de DatosCliente y almacena el mensaje
                MessageBox.Show(mensaje); // Muestra el mensaje en un MessageBox

                // Limpiar campos si el registro fue exitoso
                if (mensaje.Contains("correctamente")) // Verifica si el mensaje contiene la palabra "correctamente"
                    LimpiarFormulario(); // Llama al metodo LimpiarFormulario
            }
            catch (FormatException) // Captura cualquier excepcion de formato
            {
                MessageBox.Show("La identificacion debe ser un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Muestra un mensaje de error
            }
            catch (Exception ex) // Captura cualquier otra excepcion
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Muestra un mensaje de error
            }
        }

        private bool ValidarCampos() // Metodo para validar los campos del formulario
        {
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoApellido.Text)) // Verifica si los campos identificacion, nombre, primer apellido y segundo apellido estan vacios
            {
                MessageBox.Show("Todos los campos son requeridos.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestra un mensaje de advertencia
                return false; // Retorna false si los campos no son validos
            }

            return true; // Retorna true si los campos son validos
        }

        private void LimpiarFormulario() // Metodo para limpiar los campos del formulario
        {
            txtIdentificacion.Clear(); // Limpia el TextBox txtIdentificacion
            txtNombre.Clear(); // Limpia el TextBox txtNombre
            txtPrimerApellido.Clear(); // Limpia el TextBox txtPrimerApellido
            txtSegundoApellido.Clear(); // Limpia el TextBox txtSegundoApellido
            dtpFechaNacimiento.Value = DateTime.Today; // Restablece el valor del DateTimePicker dtpFechaNacimiento
            cmbJugadorEnLinea.SelectedIndex = 0; // Restablece el indice seleccionado del ComboBox cmbJugadorEnLinea
            txtIdentificacion.Focus(); // Establece el foco en el TextBox txtIdentificacion
        }
    }

}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)