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
    public partial class FrmRegistroAdministrador : Form
    {
        private LogAdministrador logica = new LogAdministrador();

        public FrmRegistroAdministrador()
        {
            InitializeComponent();
        }
        private void FrmRegistroAdministrador_Load(object sender, EventArgs e)
        {

            dtpNacimiento.MaxDate = DateTime.Today.AddYears(-18);
            dtpContratacion.MaxDate = DateTime.Today;
        }
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtIdentificacion = new TextBox();
            lblId = new Label();
            lblPrimerApellido = new Label();
            txtPrimerApellido = new TextBox();
            lblSegundoApellido = new Label();
            txtSegundoApellido = new TextBox();
            dtpNacimiento = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dtpContratacion = new DateTimePicker();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 155);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 23);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(127, 115);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(79, 57);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(151, 23);
            txtIdentificacion.TabIndex = 2;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(112, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(82, 15);
            lblId.TabIndex = 3;
            lblId.Text = "Identificacion:";
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Location = new Point(112, 210);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(92, 15);
            lblPrimerApellido.TabIndex = 4;
            lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(79, 249);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(151, 23);
            txtPrimerApellido.TabIndex = 5;
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Location = new Point(100, 299);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(104, 15);
            lblSegundoApellido.TabIndex = 6;
            lblSegundoApellido.Text = "Segundo Apellido:";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(79, 333);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(151, 23);
            txtSegundoApellido.TabIndex = 7;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Location = new Point(60, 429);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(200, 23);
            dtpNacimiento.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 389);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 9;
            label1.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 494);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 10;
            label2.Text = "Fecha de Contratacion:";
            // 
            // dtpContratacion
            // 
            dtpContratacion.Location = new Point(60, 536);
            dtpContratacion.Name = "dtpContratacion";
            dtpContratacion.Size = new Size(200, 23);
            dtpContratacion.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(119, 596);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 53);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // FrmRegistroAdministrador
            // 
            ClientSize = new Size(325, 676);
            Controls.Add(btnRegistrar);
            Controls.Add(dtpContratacion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpNacimiento);
            Controls.Add(txtSegundoApellido);
            Controls.Add(lblSegundoApellido);
            Controls.Add(txtPrimerApellido);
            Controls.Add(lblPrimerApellido);
            Controls.Add(lblId);
            Controls.Add(txtIdentificacion);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "FrmRegistroAdministrador";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtIdentificacion;
        private Label lblId;
        private Label lblPrimerApellido;
        private TextBox txtPrimerApellido;
        private Label lblSegundoApellido;
        private TextBox txtSegundoApellido;
        private DateTimePicker dtpNacimiento;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpContratacion;
        private Button btnRegistrar;

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    int identificacion = int.Parse(txtIdentificacion.Text);
                    string nombre = txtNombre.Text;
                    string primerApellido = txtPrimerApellido.Text;
                    string segundoApellido = txtSegundoApellido.Text;
                    DateTime nacimiento = dtpNacimiento.Value;
                    DateTime contratacion = dtpContratacion.Value;

                    string mensaje = logica.RegistroAdministrador(
                        identificacion,
                        nombre,
                        primerApellido,
                        segundoApellido,
                        nacimiento,
                        contratacion
                    );

                    MessageBox.Show(mensaje);

                    // Limpiar campos
                    txtIdentificacion.Clear();
                    txtNombre.Clear();
                    txtPrimerApellido.Clear();
                    txtSegundoApellido.Clear();
                    dtpNacimiento.Value = DateTime.Today.AddYears(-18);
                    dtpContratacion.Value = DateTime.Today;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}

