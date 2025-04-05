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
using Capa_Log_Negocio;
using Capa_Entidades;

namespace Capa_Interfaz
{
    public partial class FrmRegistroAdministrador : Form // Define la clase FrmRegistroAdministrador que hereda de Form
    {
        private LogAdministrador logica = new LogAdministrador(); // Declara una variable privada de tipo LogAdministrador e inicializa una nueva instancia

        public FrmRegistroAdministrador() // Constructor de la clase FrmRegistroAdministrador
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        private void FrmRegistroAdministrador_Load(object sender, EventArgs e) // Evento que se ejecuta al cargar el formulario
        {
            dtpNacimiento.MaxDate = DateTime.Today.AddYears(-18); // Establece la fecha maxima del DateTimePicker dtpNacimiento a 18 años antes de la fecha actual
            dtpContratacion.MaxDate = DateTime.Today; // Establece la fecha maxima del DateTimePicker dtpContratacion a la fecha actual
        }

        private void InitializeComponent() // Metodo para inicializar los componentes del formulario
        {
            txtNombre = new TextBox(); // Crea una nueva instancia de TextBox
            lblNombre = new Label(); // Crea una nueva instancia de Label
            txtIdentificacion = new TextBox(); // Crea una nueva instancia de TextBox
            lblId = new Label(); // Crea una nueva instancia de Label
            lblPrimerApellido = new Label(); // Crea una nueva instancia de Label
            txtPrimerApellido = new TextBox(); // Crea una nueva instancia de TextBox
            lblSegundoApellido = new Label(); // Crea una nueva instancia de Label
            txtSegundoApellido = new TextBox(); // Crea una nueva instancia de TextBox
            dtpNacimiento = new DateTimePicker(); // Crea una nueva instancia de DateTimePicker
            label1 = new Label(); // Crea una nueva instancia de Label
            label2 = new Label(); // Crea una nueva instancia de Label
            dtpContratacion = new DateTimePicker(); // Crea una nueva instancia de DateTimePicker
            btnRegistrar = new Button(); // Crea una nueva instancia de Button
            SuspendLayout(); // Suspende el diseño del formulario

            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 155); // Establece la ubicacion del TextBox txtNombre
            txtNombre.Name = "txtNombre"; // Establece el nombre del TextBox txtNombre
            txtNombre.Size = new Size(151, 23); // Establece el tamaño del TextBox txtNombre
            txtNombre.TabIndex = 0; // Establece el indice de tabulacion del TextBox txtNombre

            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true; // Establece que el tamaño del Label lblNombre se ajuste automaticamente
            lblNombre.Location = new Point(127, 115); // Establece la ubicacion del Label lblNombre
            lblNombre.Name = "lblNombre"; // Establece el nombre del Label lblNombre
            lblNombre.Size = new Size(54, 15); // Establece el tamaño del Label lblNombre
            lblNombre.TabIndex = 1; // Establece el indice de tabulacion del Label lblNombre
            lblNombre.Text = "Nombre:"; // Establece el texto del Label lblNombre

            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(79, 57); // Establece la ubicacion del TextBox txtIdentificacion
            txtIdentificacion.Name = "txtIdentificacion"; // Establece el nombre del TextBox txtIdentificacion
            txtIdentificacion.Size = new Size(151, 23); // Establece el tamaño del TextBox txtIdentificacion
            txtIdentificacion.TabIndex = 2; // Establece el indice de tabulacion del TextBox txtIdentificacion

            // 
            // lblId
            // 
            lblId.AutoSize = true; // Establece que el tamaño del Label lblId se ajuste automaticamente
            lblId.Location = new Point(112, 24); // Establece la ubicacion del Label lblId
            lblId.Name = "lblId"; // Establece el nombre del Label lblId
            lblId.Size = new Size(82, 15); // Establece el tamaño del Label lblId
            lblId.TabIndex = 3; // Establece el indice de tabulacion del Label lblId
            lblId.Text = "Identificacion:"; // Establece el texto del Label lblId

            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true; // Establece que el tamaño del Label lblPrimerApellido se ajuste automaticamente
            lblPrimerApellido.Location = new Point(112, 210); // Establece la ubicacion del Label lblPrimerApellido
            lblPrimerApellido.Name = "lblPrimerApellido"; // Establece el nombre del Label lblPrimerApellido
            lblPrimerApellido.Size = new Size(92, 15); // Establece el tamaño del Label lblPrimerApellido
            lblPrimerApellido.TabIndex = 4; // Establece el indice de tabulacion del Label lblPrimerApellido
            lblPrimerApellido.Text = "Primer Apellido:"; // Establece el texto del Label lblPrimerApellido

            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(79, 249); // Establece la ubicacion del TextBox txtPrimerApellido
            txtPrimerApellido.Name = "txtPrimerApellido"; // Establece el nombre del TextBox txtPrimerApellido
            txtPrimerApellido.Size = new Size(151, 23); // Establece el tamaño del TextBox txtPrimerApellido
            txtPrimerApellido.TabIndex = 5; // Establece el indice de tabulacion del TextBox txtPrimerApellido

            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true; // Establece que el tamaño del Label lblSegundoApellido se ajuste automaticamente
            lblSegundoApellido.Location = new Point(100, 299); // Establece la ubicacion del Label lblSegundoApellido
            lblSegundoApellido.Name = "lblSegundoApellido"; // Establece el nombre del Label lblSegundoApellido
            lblSegundoApellido.Size = new Size(104, 15); // Establece el tamaño del Label lblSegundoApellido
            lblSegundoApellido.TabIndex = 6; // Establece el indice de tabulacion del Label lblSegundoApellido
            lblSegundoApellido.Text = "Segundo Apellido:"; // Establece el texto del Label lblSegundoApellido

            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(79, 333); // Establece la ubicacion del TextBox txtSegundoApellido
            txtSegundoApellido.Name = "txtSegundoApellido"; // Establece el nombre del TextBox txtSegundoApellido
            txtSegundoApellido.Size = new Size(151, 23); // Establece el tamaño del TextBox txtSegundoApellido
            txtSegundoApellido.TabIndex = 7; // Establece el indice de tabulacion del TextBox txtSegundoApellido

            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Location = new Point(60, 429); // Establece la ubicacion del DateTimePicker dtpNacimiento
            dtpNacimiento.Name = "dtpNacimiento"; // Establece el nombre del DateTimePicker dtpNacimiento
            dtpNacimiento.Size = new Size(200, 23); // Establece el tamaño del DateTimePicker dtpNacimiento
            dtpNacimiento.TabIndex = 8; // Establece el indice de tabulacion del DateTimePicker dtpNacimiento

            // 
            // label1
            // 
            label1.AutoSize = true; // Establece que el tamaño del Label label1 se ajuste automaticamente
            label1.Location = new Point(100, 389); // Establece la ubicacion del Label label1
            label1.Name = "label1"; // Establece el nombre del Label label1
            label1.Size = new Size(122, 15); // Establece el tamaño del Label label1
            label1.TabIndex = 9; // Establece el indice de tabulacion del Label label1
            label1.Text = "Fecha de Nacimiento:"; // Establece el texto del Label label1

            // 
            // label2
            // 
            label2.AutoSize = true; // Establece que el tamaño del Label label2 se ajuste automaticamente
            label2.Location = new Point(101, 494); // Establece la ubicacion del Label label2
            label2.Name = "label2"; // Establece el nombre del Label label2
            label2.Size = new Size(129, 15); // Establece el tamaño del Label label2
            label2.TabIndex = 10; // Establece el indice de tabulacion del Label label2
            label2.Text = "Fecha de Contratacion:"; // Establece el texto del Label label2

            // 
            // dtpContratacion
            // 
            dtpContratacion.Location = new Point(60, 536); // Establece la ubicacion del DateTimePicker dtpContratacion
            dtpContratacion.Name = "dtpContratacion"; // Establece el nombre del DateTimePicker dtpContratacion
            dtpContratacion.Size = new Size(200, 23); // Establece el tamaño del DateTimePicker dtpContratacion
            dtpContratacion.TabIndex = 11; // Establece el indice de tabulacion del DateTimePicker dtpContratacion

            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(119, 596); // Establece la ubicacion del Button btnRegistrar
            btnRegistrar.Name = "btnRegistrar"; // Establece el nombre del Button btnRegistrar
            btnRegistrar.Size = new Size(75, 53); // Establece el tamaño del Button btnRegistrar
            btnRegistrar.TabIndex = 12; // Establece el indice de tabulacion del Button btnRegistrar
            btnRegistrar.Text = "Registrar"; // Establece el texto del Button btnRegistrar
            btnRegistrar.UseVisualStyleBackColor = true; // Establece que el Button btnRegistrar use el estilo visual del sistema operativo
            btnRegistrar.Click += btnRegistrar_Click_1; // Asocia el evento Click del Button btnRegistrar con el metodo btnRegistrar_Click_1

            // 
            // FrmRegistroAdministrador
            // 
            ClientSize = new Size(325, 676); // Establece el tamaño del formulario
            Controls.Add(btnRegistrar); // Agrega el Button btnRegistrar a los controles del formulario
            Controls.Add(dtpContratacion); // Agrega el DateTimePicker dtpContratacion a los controles del formulario
            Controls.Add(label2); // Agrega el Label label2 a los controles del formulario
            Controls.Add(label1); // Agrega el Label label1 a los controles del formulario
            Controls.Add(dtpNacimiento); // Agrega el DateTimePicker dtpNacimiento a los controles del formulario
            Controls.Add(txtSegundoApellido); // Agrega el TextBox txtSegundoApellido a los controles del formulario
            Controls.Add(lblSegundoApellido); // Agrega el Label lblSegundoApellido a los controles del formulario
            Controls.Add(txtPrimerApellido); // Agrega el TextBox txtPrimerApellido a los controles del formulario
            Controls.Add(lblPrimerApellido); // Agrega el Label lblPrimerApellido a los controles del formulario
            Controls.Add(lblId); // Agrega el Label lblId a los controles del formulario
            Controls.Add(txtIdentificacion); // Agrega el TextBox txtIdentificacion a los controles del formulario
            Controls.Add(lblNombre); // Agrega el Label lblNombre a los controles del formulario
            Controls.Add(txtNombre); // Agrega el TextBox txtNombre a los controles del formulario
            Name = "FrmRegistroAdministrador"; // Establece el nombre del formulario
            ResumeLayout(false); // Reanuda el diseño del formulario
            PerformLayout(); // Aplica el diseño del formulario
        }

        private TextBox txtNombre; // Declara un TextBox para el nombre
        private Label lblNombre; // Declara un Label para el nombre
        private TextBox txtIdentificacion; // Declara un TextBox para la identificacion
        private Label lblId; // Declara un Label para la identificacion
        private Label lblPrimerApellido; // Declara un Label para el primer apellido
        private TextBox txtPrimerApellido; // Declara un TextBox para el primer apellido
        private Label lblSegundoApellido; // Declara un Label para el segundo apellido
        private TextBox txtSegundoApellido; // Declara un TextBox para el segundo apellido
        private DateTimePicker dtpNacimiento; // Declara un DateTimePicker para la fecha de nacimiento
        private Label label1; // Declara un Label para la fecha de nacimiento
        private Label label2; // Declara un Label para la fecha de contratacion
        private DateTimePicker dtpContratacion; // Declara un DateTimePicker para la fecha de contratacion
        private Button btnRegistrar; // Declara un Button para registrar

        private void btnRegistrar_Click_1(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el boton Registrar
        {
            try
            {
                int identificacion = int.Parse(txtIdentificacion.Text); // Convierte el texto del TextBox txtIdentificacion a un entero
                string nombre = txtNombre.Text; // Obtiene el texto del TextBox txtNombre
                string primerApellido = txtPrimerApellido.Text; // Obtiene el texto del TextBox txtPrimerApellido
                string segundoApellido = txtSegundoApellido.Text; // Obtiene el texto del TextBox txtSegundoApellido
                DateTime nacimiento = dtpNacimiento.Value; // Obtiene el valor del DateTimePicker dtpNacimiento
                DateTime contratacion = dtpContratacion.Value; // Obtiene el valor del DateTimePicker dtpContratacion

                string mensaje = logica.RegistroAdministrador(
                    identificacion,
                    nombre,
                    primerApellido,
                    segundoApellido,
                    nacimiento,
                    contratacion
                ); // Llama al metodo RegistroAdministrador de la logica de negocio y almacena el mensaje

                MessageBox.Show(mensaje); // Muestra el mensaje en un MessageBox

                // Limpiar campos
                txtIdentificacion.Clear(); // Limpia el TextBox txtIdentificacion
                txtNombre.Clear(); // Limpia el TextBox txtNombre
                txtPrimerApellido.Clear(); // Limpia el TextBox txtPrimerApellido
                txtSegundoApellido.Clear(); // Limpia el TextBox txtSegundoApellido
                dtpNacimiento.Value = DateTime.Today.AddYears(-18); // Restablece el valor del DateTimePicker dtpNacimiento
                dtpContratacion.Value = DateTime.Today; // Restablece el valor del DateTimePicker dtpContratacion
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                MessageBox.Show("Error: " + ex.Message); // Muestra un mensaje de error
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)