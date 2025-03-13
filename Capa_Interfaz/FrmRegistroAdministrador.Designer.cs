//namespace Capa_Interfaz
//{
//    partial class FrmRegistroAdministrador
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            identificacion = new Label();
//            txtIdentificacion = new TextBox();
//            Nombre = new Label();
//            txtNombre = new TextBox();
//            PrimerApellido = new Label();
//            txtPrimerApellido = new TextBox();
//            segundoApellido = new Label();
//            txtSegundoApellido = new TextBox();
//            fechaNacimiento = new Label();
//            dtpFechaNacimiento = new DateTimePicker();
//            fechaContratacion = new Label();
//            btnRegistrar = new Button();
//            dtpFechaContratacion = new DateTimePicker();
//            SuspendLayout();
//            // 
//            // identificacion
//            // 
//            identificacion.AutoSize = true;
//            identificacion.Location = new Point(326, 9);
//            identificacion.Name = "identificacion";
//            identificacion.Size = new Size(82, 15);
//            identificacion.TabIndex = 0;
//            identificacion.Text = "Identificación:";
//            // 
//            // txtIdentificacion
//            // 
//            txtIdentificacion.Location = new Point(268, 39);
//            txtIdentificacion.Name = "txtIdentificacion";
//            txtIdentificacion.Size = new Size(198, 23);
//            txtIdentificacion.TabIndex = 1;
//            txtIdentificacion.TextChanged += this.txtIdentificacion_TextChanged;
//            // 
//            // Nombre
//            // 
//            Nombre.AutoSize = true;
//            Nombre.Location = new Point(340, 96);
//            Nombre.Name = "Nombre";
//            Nombre.Size = new Size(54, 15);
//            Nombre.TabIndex = 2;
//            Nombre.Text = "Nombre:";
//            // 
//            // txtNombre
//            // 
//            txtNombre.Location = new Point(268, 125);
//            txtNombre.Name = "txtNombre";
//            txtNombre.Size = new Size(198, 23);
//            txtNombre.TabIndex = 3;
//            // 
//            // PrimerApellido
//            // 
//            PrimerApellido.AutoSize = true;
//            PrimerApellido.Location = new Point(316, 184);
//            PrimerApellido.Name = "PrimerApellido";
//            PrimerApellido.Size = new Size(92, 15);
//            PrimerApellido.TabIndex = 4;
//            PrimerApellido.Text = "Primer Apellido:";
//            // 
//            // txtPrimerApellido
//            // 
//            txtPrimerApellido.Location = new Point(268, 224);
//            txtPrimerApellido.Name = "txtPrimerApellido";
//            txtPrimerApellido.Size = new Size(198, 23);
//            txtPrimerApellido.TabIndex = 5;
//            // 
//            // segundoApellido
//            // 
//            segundoApellido.AutoSize = true;
//            segundoApellido.Location = new Point(306, 284);
//            segundoApellido.Name = "segundoApellido";
//            segundoApellido.Size = new Size(104, 15);
//            segundoApellido.TabIndex = 6;
//            segundoApellido.Text = "Segundo Apellido:";
//            // 
//            // txtSegundoApellido
//            // 
//            txtSegundoApellido.Location = new Point(268, 324);
//            txtSegundoApellido.Name = "txtSegundoApellido";
//            txtSegundoApellido.Size = new Size(198, 23);
//            txtSegundoApellido.TabIndex = 7;
//            // 
//            // fechaNacimiento
//            // 
//            fechaNacimiento.AutoSize = true;
//            fechaNacimiento.Location = new Point(302, 370);
//            fechaNacimiento.Name = "fechaNacimiento";
//            fechaNacimiento.Size = new Size(122, 15);
//            fechaNacimiento.TabIndex = 8;
//            fechaNacimiento.Text = "Fecha de Nacimiento:";
//            // 
//            // dtpFechaNacimiento
//            // 
//            dtpFechaNacimiento.Location = new Point(268, 410);
//            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
//            dtpFechaNacimiento.Size = new Size(200, 23);
//            dtpFechaNacimiento.TabIndex = 9;
//            // 
//            // fechaContratacion
//            // 
//            fechaContratacion.AutoSize = true;
//            fechaContratacion.Location = new Point(295, 471);
//            fechaContratacion.Name = "fechaContratacion";
//            fechaContratacion.Size = new Size(129, 15);
//            fechaContratacion.TabIndex = 10;
//            fechaContratacion.Text = "Fecha de Contratación:";
//            // 
//            // btnRegistrar
//            // 
//            btnRegistrar.Location = new Point(596, 471);
//            btnRegistrar.Name = "btnRegistrar";
//            btnRegistrar.Size = new Size(99, 61);
//            btnRegistrar.TabIndex = 11;
//            btnRegistrar.Text = "Registrar";
//            btnRegistrar.UseVisualStyleBackColor = true;
//            btnRegistrar.Click += btnRegistrar_Click;
//            // 
//            // dtpFechaContratacion
//            // 
//            dtpFechaContratacion.Location = new Point(266, 507);
//            dtpFechaContratacion.Name = "dtpFechaContratacion";
//            dtpFechaContratacion.Size = new Size(200, 23);
//            dtpFechaContratacion.TabIndex = 12;
//            // 
//            // FrmRegistroAdministrador
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(800, 569);
//            Controls.Add(dtpFechaContratacion);
//            Controls.Add(btnRegistrar);
//            Controls.Add(fechaContratacion);
//            Controls.Add(dtpFechaNacimiento);
//            Controls.Add(fechaNacimiento);
//            Controls.Add(txtSegundoApellido);
//            Controls.Add(segundoApellido);
//            Controls.Add(txtPrimerApellido);
//            Controls.Add(PrimerApellido);
//            Controls.Add(txtNombre);
//            Controls.Add(Nombre);
//            Controls.Add(txtIdentificacion);
//            Controls.Add(identificacion);
//            Name = "FrmRegistroAdministrador";
//            Text = "Form1";
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private Label identificacion;
//        private TextBox txtIdentificacion;
//        private Label Nombre;
//        private TextBox txtNombre;
//        private Label PrimerApellido;
//        private TextBox txtPrimerApellido;
//        private Label segundoApellido;
//        private TextBox txtSegundoApellido;
//        private Label fechaNacimiento;
//        private DateTimePicker dtpFechaNacimiento;
//        private Label fechaContratacion;
//        private Button btnRegistrar;
//        private DateTimePicker dtpFechaContratacion;
//    }
//}