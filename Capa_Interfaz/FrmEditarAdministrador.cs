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
    public partial class FrmEditarAdministrador : Form // Define la clase FrmEditarAdministrador que hereda de Form
    {
        public AdministradorEntidad Administrador { get; private set; } // Propiedad para almacenar el administrador a editar

        public FrmEditarAdministrador(AdministradorEntidad admin) // Constructor de la clase FrmEditarAdministrador
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            Administrador = admin; // Asigna el administrador pasado como parametro a la propiedad Administrador
        }

        private void FrmEditarAdministrador_Load(object sender, EventArgs e) // Evento que se ejecuta al cargar el formulario
        {
            txtIdentificacion.Text = Administrador.Identificacion.ToString(); // Asigna el valor de la identificacion del administrador al TextBox txtIdentificacion
            txtIdentificacion.ReadOnly = true; // Establece el TextBox txtIdentificacion como solo lectura
            txtNombre.Text = Administrador.Nombre; // Asigna el valor del nombre del administrador al TextBox txtNombre
            txtPrimerApellido.Text = Administrador.PrimerApellido; // Asigna el valor del primer apellido del administrador al TextBox txtPrimerApellido
            txtSegundoApellido.Text = Administrador.SegundoApellido; // Asigna el valor del segundo apellido del administrador al TextBox txtSegundoApellido
            dtpNacimiento.Value = Administrador.FechaNacimiento; // Asigna el valor de la fecha de nacimiento del administrador al DateTimePicker dtpNacimiento
            dtpContratacion.Value = Administrador.FechaContratacion; // Asigna el valor de la fecha de contratacion del administrador al DateTimePicker dtpContratacion
        }

        private void btnGuardar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Guardar
        {
            Administrador.Nombre = txtNombre.Text; // Asigna el valor del TextBox txtNombre a la propiedad Nombre del administrador
            Administrador.PrimerApellido = txtPrimerApellido.Text; // Asigna el valor del TextBox txtPrimerApellido a la propiedad PrimerApellido del administrador
            Administrador.SegundoApellido = txtSegundoApellido.Text; // Asigna el valor del TextBox txtSegundoApellido a la propiedad SegundoApellido del administrador
            Administrador.FechaNacimiento = dtpNacimiento.Value; // Asigna el valor del DateTimePicker dtpNacimiento a la propiedad FechaNacimiento del administrador
            Administrador.FechaContratacion = dtpContratacion.Value; // Asigna el valor del DateTimePicker dtpContratacion a la propiedad FechaContratacion del administrador

            DialogResult = DialogResult.OK; // Establece el resultado del dialogo como OK
        }

        private void btnCancelar_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Cancelar
        {
            DialogResult = DialogResult.Cancel; // Establece el resultado del dialogo como Cancel
            Close(); // Cierra el formulario
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)