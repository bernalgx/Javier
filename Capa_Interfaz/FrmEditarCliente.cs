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
using Capa_Entidades;

namespace Capa_Interfaz
{
    public partial class FrmEditarCliente : Form // Define la clase FrmEditarCliente que hereda de Form
    {
        public ClienteEntidad Cliente { get; private set; } // Propiedad para almacenar el cliente a editar

        public FrmEditarCliente(ClienteEntidad cliente) // Constructor de la clase FrmEditarCliente
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            Cliente = cliente; // Asigna el cliente pasado como parametro a la propiedad Cliente
            CargarDatosCliente(); // Llama al metodo CargarDatosCliente
            ConfigurarControles(); // Llama al metodo ConfigurarControles
        }

        private void CargarDatosCliente() // Metodo para cargar los datos del cliente en los controles del formulario
        {
            txtIdentificacion.Text = Cliente.Identificacion.ToString(); // Asigna el valor de la identificacion del cliente al TextBox txtIdentificacion
            txtNombre.Text = Cliente.Nombre; // Asigna el valor del nombre del cliente al TextBox txtNombre
            txtPrimerApellido.Text = Cliente.PrimerApellido; // Asigna el valor del primer apellido del cliente al TextBox txtPrimerApellido
            txtSegundoApellido.Text = Cliente.SegundoApellido; // Asigna el valor del segundo apellido del cliente al TextBox txtSegundoApellido
            dtpFechaNacimiento.Value = Cliente.FechaNacimiento; // Asigna el valor de la fecha de nacimiento del cliente al DateTimePicker dtpFechaNacimiento
            cmbJugadorEnLinea.SelectedItem = Cliente.JugadorEnLinea ? "Si" : "No"; // Asigna el valor de la propiedad JugadorEnLinea del cliente al ComboBox cmbJugadorEnLinea
        }

        private void ConfigurarControles() // Metodo para configurar los controles del formulario
        {
            // Configurar controles
            txtIdentificacion.Enabled = false; // La identificacion no se puede modificar

            // Configurar DateTimePicker
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short; // Establece el formato corto de fecha para el DateTimePicker dtpFechaNacimiento
            dtpFechaNacimiento.ShowUpDown = false; // Deshabilita el control de seleccion de fecha en el DateTimePicker dtpFechaNacimiento

            // Configurar ComboBox
            cmbJugadorEnLinea.Items.Clear(); // Limpia los items del ComboBox cmbJugadorEnLinea
            cmbJugadorEnLinea.Items.Add("Si"); // Agrega el item "Si" al ComboBox cmbJugadorEnLinea
            cmbJugadorEnLinea.Items.Add("No"); // Agrega el item "No" al ComboBox cmbJugadorEnLinea
        }

        private void btnGuardar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Guardar
        {
            if (ValidarCampos()) // Verifica si los campos son validos
            {
                ActualizarCliente(); // Llama al metodo ActualizarCliente
                DialogResult = DialogResult.OK; // Establece el resultado del dialogo como OK
                Close(); // Cierra el formulario
            }
        }

        private bool ValidarCampos() // Metodo para validar los campos del formulario
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoApellido.Text)) // Verifica si los campos nombre, primer apellido y segundo apellido estan vacios
            {
                MessageBox.Show("Todos los campos son requeridos.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestra un mensaje de advertencia
                return false; // Retorna false si los campos no son validos
            }

            return true; // Retorna true si los campos son validos
        }

        private void ActualizarCliente() // Metodo para actualizar los datos del cliente
        {
            Cliente.Nombre = txtNombre.Text; // Asigna el valor del TextBox txtNombre a la propiedad Nombre del cliente
            Cliente.PrimerApellido = txtPrimerApellido.Text; // Asigna el valor del TextBox txtPrimerApellido a la propiedad PrimerApellido del cliente
            Cliente.SegundoApellido = txtSegundoApellido.Text; // Asigna el valor del TextBox txtSegundoApellido a la propiedad SegundoApellido del cliente
            Cliente.FechaNacimiento = dtpFechaNacimiento.Value.Date; // Asigna el valor del DateTimePicker dtpFechaNacimiento a la propiedad FechaNacimiento del cliente
            Cliente.JugadorEnLinea = cmbJugadorEnLinea.SelectedItem.ToString() == "Si"; // Asigna el valor del ComboBox cmbJugadorEnLinea a la propiedad JugadorEnLinea del cliente
        }

        private void btnCancelar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Cancelar
        {
            DialogResult = DialogResult.Cancel; // Establece el resultado del dialogo como Cancel
            Close(); // Cierra el formulario
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)